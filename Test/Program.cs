using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //OrderStatus ObjOrderStatus = Newtonsoft.Json.JsonConvert.DeserializeObject<OrderStatus>(File.ReadAllText(@"C:\Users\dharm\source\repos\Test\Test\test.txt"));
            //if (ObjOrderStatus.new_state.ToLower() == "Completed".ToLower() || ObjOrderStatus.new_state.ToLower() == "Dispatched".ToLower() || ObjOrderStatus.new_state.ToLower() == "Food Ready".ToLower())
            //{
            //    if (ObjOrderStatus.new_state.ToLower() == "dispatched")
            //    {
            //        ObjOrderStatus.new_state = "Dispatched";
            //    }
            //    else if (ObjOrderStatus.new_state.ToLower() == "completed")
            //    {
            //        ObjOrderStatus.new_state = "Completed";
            //    }
            //}

                //try
                //{
                Credentials test123= ParseAuthorizationHeader("eyJQcm9wU3RyVXNlckNvZGUiOiIyIiwiUHJvcFN0ckdyb3VwSWQiOiJhOWwiLCJQcm9wU3RyQ2xpZW50SWQiOiIwMDEiLCJQcm9wU3RyUGFydG5lcktleSI6IlBvc2dvbGQiLCJQcm9wU3RyUG9zQ29kZSI6IjEiLCJQcm9wU3RyVXNlcm5hbWUiOiJhZG1pbiIsIlByb3BTdHJQYXNzd29yZCI6IjEyMzQ1NiIsIlByb3BTdHJLaW9za0NvZGUiOiIiLCJQcm9wU3RyTWFjSWQiOiJlM2E5NjdkODkxODBhZTNhIn0=");
            //    using (System.Net.WebResponse myResponse = System.Net.WebRequest.Create("https://www.google.com").GetResponse())
            //    {

            //    }
            //}
            //catch (System.Net.WebException)
            //{
            //    Console.WriteLine("test1");
            //}
            //548002
            test123.PropStrPosCode = "548002";
            string authInfo = Newtonsoft.Json.JsonConvert.SerializeObject(test123);
            authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            Console.WriteLine(DateTime.Now.ToString());
            Parallel.Invoke(() => funtest("1"), () => funtest("2"));
         //dynamic test=  funtest("1")
         //   funtest("2");
            Console.WriteLine(DateTime.Now.ToString());
            Console.ReadLine();

        }

        public class OrderStatus
        {

            public string new_state { get; set; }
            public string order_id { get; set; }
            public string prev_state { get; set; }
            public string timestamp { get; set; }
            public string store_id { get; set; }
            public long timestamp_unix { get; set; }
            public string message { get; set; }
        }
        public  static string funtest(string id)
        {
            // Task.Factory.StartNew(() =>
            // {
             Task.Run(() =>
           {
           File.WriteAllText("test" + id + ".txt", DateTime.Now.ToString());
            System.Threading.Thread.Sleep(30000);

        }).ConfigureAwait(false);

            return "test";

            }


        public static Credentials ParseAuthorizationHeader(string authHeader)
        {
            try
            {

                return Newtonsoft.Json.JsonConvert.DeserializeObject<Credentials>(Encoding.ASCII.GetString(Convert.FromBase64String(authHeader)));
            }
            catch
            {
                return new Credentials();
            }

        }
        public class Credentials
        {
            public string PropStrUserCode = "1";
            public string PropStrUsername { get; set; }
            public string PropStrPassword { get; set; }
            public string PropStrGroupId { get; set; }
            public string PropStrClientId { get; set; }
            public string PropStrPosCode = "";
            public string PropStrMacId = "";
            public string PropStrKioskCode = "";
        }
    }
}
