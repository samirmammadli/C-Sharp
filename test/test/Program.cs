using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Office.Core;


namespace test
{

    
    class Program
    {
        static void Main(string[] args)
        {

            var listener = new HttpListener();
            listener.Prefixes.Add("http://127.0.0.1:8080/");
            listener.Start();
            var context = listener.GetContext();
            var request = context.Request;
            var response = context.Response;
            Console.WriteLine(request);
        }
    }
}
