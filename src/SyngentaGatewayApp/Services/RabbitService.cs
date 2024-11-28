using iSoft.Common.Models.ConfigModel.Subs;
using iSoft.RabbitMQ.Services;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SyngentaGatewayApp.Services
{
    public class RabbitService
    {
        string Host = Environment.GetEnvironmentVariable("RABBIT_MQ_HOST");
        string Port = Environment.GetEnvironmentVariable("RABBIT_MQ_PORT");
        string Username = Environment.GetEnvironmentVariable("RABBIT_MQ_USERNAME");
        string Password = Environment.GetEnvironmentVariable("RABBIT_MQ_PASSWORD");
        string Exchange = Environment.GetEnvironmentVariable("RABBIT_MQ_EXCHANGE");
        string QueueName = Environment.GetEnvironmentVariable("RABBIT_MQ_QUEUE");
        string RoutingKey = Environment.GetEnvironmentVariable("RABBIT_MQ_ROUTING_KEY");
        public IModel model;
        public IConnection connection;
        public ConnectionFactory factory;

        public void ConfigsRabbitMQ()
        {
            factory = new ConnectionFactory()
            {
                HostName = Host,
                Port = int.Parse(Port),
                UserName = Username,
                Password = Password,
                VirtualHost = "/"
            };
            try
            {
                {
                    connection = factory.CreateConnection();
                    model = connection.CreateModel();
                    // Create Exchange
                    model.ExchangeDeclare(Exchange, ExchangeType.Direct);
                    // Create Queue
                    model.QueueDeclare(QueueName, true, false, false, null);
                    // Bind Queue to Exchange
                    model.QueueBind(QueueName, Exchange, RoutingKey);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error ConfigsRabbitMQ",ex.Message);
            }
        }


        public void init()
        {
            try
            {
                if (IsConnect != true)
                {
                    connection = factory.CreateConnection();
                }
                else
                {
                    connection.Close();
                    connection = factory.CreateConnection();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void PushMessage(byte[] data)
        {
            lock (this)
            {
                try
                {
                    if ( data == null) return;
                    if(connection.IsOpen != true) init();
                    var properties = model.CreateBasicProperties();
                    model.BasicPublish(Exchange, RoutingKey, properties, data);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception Push Message" + "\n" + ex.StackTrace + "\n" + ex.Message + "\n");
                    init();
                }
            }
        }


        public bool IsConnect
        {
            get
            {
                var ping = new Ping();
                var resultPing = ping.Send(Host, 50);
                return resultPing.Status == IPStatus.Success && connection != null && connection.IsOpen == true;
            }
            set { }
        }








    }
}
