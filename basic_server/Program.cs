using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace C_Hasz_2
{
    public class Program
    {
        string msg;
        HttpListener listener;
        string path;
        int port;
        Thread thread;

        public Program(int newPort, string newPath)
        {
                port = newPort;
                path = newPath;
                thread = new Thread(this.listening);
                thread.Start();
        }
        public void listening()
        {
            //Random rngGenerator = new Random();
            try
            {
                string catPath = this.path;
                string filePath = "";

                listener = new HttpListener();
                listener.Prefixes.Add("http://localhost:" + port + "/");
                listener.Start();
                string url;
                while (true)
                {
               
                    /*int randomSite = rngGenerator.Next(1, 5);
                    switch(randomSite) {
                        case 1:
                            msg = test();
                            break;
                        case 2:
                            msg = test2();
                            break;
                        case 3:
                            msg = test3();
                            break;
                        case 4:
                            msg = test4();
                            break;
                    }*/
                    
                    Console.WriteLine("waiting...");
                    HttpListenerContext context = listener.GetContext();
                    HttpListenerRequest request = context.Request;
                    url = request.RawUrl;
                    if(url != "/")
                    {
                        url = url.TrimStart('/');
                        filePath = String.Concat(catPath, url);
                    }
                    else
                    {
                        filePath = String.Concat(catPath, "index.html");
                        if (!File.Exists(filePath))
                        {
                            filePath = "index.html";
                        }
                    }
                    if (File.Exists(filePath))
                    {
                        Console.WriteLine(filePath);
                    }
                    else
                    {
                        filePath = String.Concat(catPath, "404.html");
                        if (!File.Exists(filePath))
                        {
                            filePath = "404.html";
                        }
                    }
                    msg = File.ReadAllText(filePath);

                    using (Stream stream = context.Response.OutputStream)
                    {
                        using (StreamWriter writer = new StreamWriter(stream))
                        {
                            Console.WriteLine(url);
                            writer.Write(msg);
                        }
                    }
                    Console.WriteLine("msg sent...");
                }
            }
            catch(WebException e)
            {
                Console.WriteLine(e.Status);
                msg = "500";
            }
        }

        public void stop()
        {
                thread.Abort();
                listener.Stop();
        }

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
