using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IoTClient.Clients.PLC;
using IoTClient.Enums;
using SyngentaGatewayApp.Events;

namespace SyngentaGatewayApp.Services
{
    public class PlcServices
    {
        public event DataSentHandler OnDataSentHandler;

        public void SendDataPLC(MitsubishiClient client, uint registerStart, uint lengthRegister, string data)
        {
            // DataPlan
            byte[] b_format_data = new byte[(uint)lengthRegister * 2];
            for (int i = 0; i < b_format_data.Length; i++)
            {
                b_format_data[i] = (byte)' ';
            }
            byte[] b_data = Encoding.ASCII.GetBytes(data);

            for (int i = 0; i < b_data.Length; i++)
            {
                b_format_data[i] = (byte)b_data[i];
            }
            client.Write($"D{registerStart}", b_format_data);
        }


        public void SendDataPLC(MitsubishiClient client, uint registerStart, Int32 data)
        {
            if (client != null)
            {
                client.Write($"D{registerStart}", data, DataTypeEnum.Int32);
            }

        }
        public void SendDataPLC(MitsubishiClient client, uint registerStart, bool data)
        {
            if (client != null)
            {
                client.Write($"M{registerStart}", data, DataTypeEnum.Bool);
            }

        }

        public int ReadValuePLC(MitsubishiClient client, ushort registerStart, ushort length)
        {
            var blockData = ReadDataPLC(client, registerStart, length);
            var DataLogReverse = blockData.Select(x => x.Value).Reverse().ToArray();
            if (length == 1)
            {
                return DataLogReverse.FirstOrDefault();
            }
            return 0;
        }

        public List<KeyValuePair<string, short>> ReadDataPLC(MitsubishiClient client, ushort registerStart, ushort length)
        {
            return client.ReadInt16($"D{registerStart}", length).Value;
        }

        public string ReadDataPLC(MitsubishiClient client, uint registerStart, uint lengthRegister)
        {
            var b_datas = client.Read($"D{(ushort)registerStart}", (ushort)(lengthRegister * 2)).Value;
            if (b_datas == null) return "NAN";
            return Encoding.UTF8.GetString(b_datas).Replace("\0", "").Trim();
        }
    }
}
