using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace project_Game_Caro
{
    class SocketManager
    {
        #region Client
        Socket client;
        public bool ConnectServer()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), Port);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(iep);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Server
        Socket server;
        public void CreateServer()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), Port);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Bind(iep);
            server.Listen(10); // Đợi kết nối client trong 10s nếu ko có thì bỏ

            Thread AcceptClient = new Thread(() => { try { client = server.Accept(); } catch { } });
            AcceptClient.IsBackground = true; // Để khi chương trình tắt ngang thì Thread cũng tự tắt
            AcceptClient.Start();
        }
        #endregion

        #region Both
        public string IP = "127.0.0.1";
        public int Port = 9999;
        public bool IsServer = true;
        public const int BUFFER = 1024;

        private bool SendData(Socket target, byte[] data)
        {
            return target.Send(data) >0;
        }

        private bool ReceiveData(Socket target, byte[] data)
        {
            return target.Receive(data) >0;
        }

        public bool Send(object data)
        {
            byte[] sendedData = SerializeData(data);
            return SendData(client, sendedData);
        }

        public T Receive<T>()
        {
            byte[] receivedData = new byte[BUFFER]; // Tạo buffer có kích thước cố định
            int receivedBytes = client.Receive(receivedData); // Nhận số byte thực sự nhận được

            if (receivedBytes > 0)
            {
                byte[] actualData = new byte[receivedBytes]; // Tạo mảng mới vừa với dữ liệu nhận được
                Array.Copy(receivedData, actualData, receivedBytes); // Sao chép dữ liệu thực tế

                return (T)DeserializeData(actualData, typeof(T)); // Giải nén dữ liệu và cast sang kiểu T
            }

            return default(T); // Trả về giá trị mặc định nếu không nhận được dữ liệu
        }



        /// <summary>
        /// Nén đối tượng thành mảng byte[]
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public byte[] SerializeData(object o)
        {
            DataContractSerializer serializer = new DataContractSerializer(o.GetType());
            using (MemoryStream ms = new MemoryStream())
            {
                serializer.WriteObject(ms, o);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Giải nén mảng byte[] thành đối tượng object
        /// </summary>
        /// <param name="theByteArray"></param>
        /// <returns></returns>
        public object DeserializeData(byte[] data, Type objectType)
        {
            DataContractSerializer serializer = new DataContractSerializer(objectType);
            using (MemoryStream ms = new MemoryStream(data))
            {
                return serializer.ReadObject(ms);
            }
        }


        /// <summary>
        /// Lấy ra IP V4 của card mạng đang dùng
        /// </summary>
        /// <param name="_type"></param>
        /// <returns></returns>
        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";

            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                            output = ip.Address.ToString();
            return output;
        }

        public void CloseConnect()
        {
            try
            {
                server.Close();
                client.Close();
            }
            catch { }

        }
        #endregion
    }
}
