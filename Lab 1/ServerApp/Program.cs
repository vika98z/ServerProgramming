using System;
using System.Net;
using System.IO;

namespace ServerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpListener httpListener = new HttpListener();
            httpListener.Prefixes.Add("http://localhost:1234/");
            httpListener.Start();

            while (true)
            {
                Console.WriteLine("Ожидание подключений...");
                HttpListenerContext context = httpListener.GetContext();
                HttpListenerResponse response = context.Response;
                HttpListenerRequest request = context.Request;

                string path = request.RawUrl;

                if (path == "/")
                    path = "/index.html";

                string filename = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\")) + path;
                filename = filename.Replace("%20", " ");

                if (File.Exists(filename))
                {
                    response.StatusCode = 200;
                    var bytes = File.ReadAllBytes(filename);
                    response.ContentLength64 = bytes.Length;
                    response.OutputStream.Write(bytes, 0, bytes.Length);
                }
                else
                    response.StatusCode = 404;
                response.OutputStream.Close();

                using (StreamWriter writter = File.AppendText("../../../log.log"))
                {
                    writter.WriteLine(DateTime.Now + " " + request.RemoteEndPoint.Address + " " + request.HttpMethod + " " + path + " " + response.StatusCode);
                }
            }
        }
    }
}
