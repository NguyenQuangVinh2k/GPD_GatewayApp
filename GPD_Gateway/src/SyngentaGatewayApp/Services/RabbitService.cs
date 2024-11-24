using iSoft.Common.Models.ConfigModel.Subs;
using iSoft.RabbitMQ.Services;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyngentaGatewayApp.Services
{
    public class RabbitService
    {

        public string Address = "localhost";
        public int Port = 2712;
        public string Username = "admin";
        public string Password = "admin1";
        public string Exchange = "GPD_Exchange";
        public string QueueName = "GPD_Queue";
        public string RoutingKey = "GPD_RoutingKey";
        public IModel model;
        public IConnection connection;
        public ConnectionFactory factory;
        public void ConfigsRabbitMQ() 
        {
            factory = new ConnectionFactory() 
            {
                HostName = Address,
                Port = Port,
                UserName = Username,
                Password = Password,
                VirtualHost = "/"
            };
            try
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
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void init() 
        {
            try
            {
                if (connection.IsOpen != true)
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
            try
            {
                var properties = model.CreateBasicProperties();
                model.BasicPublish(Exchange, RoutingKey, properties, data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

    }
}
