using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsumerProducer
{
    class Monitor
    {
        private static int bufferSize = 0;
        private static int counter = 0;
        private static bool noInterested= false;

        private static List<double> list = new List<double>();

        public static void append(double x)=>agregarAzync(x);
        public static void take() => consumirAsync();

        private static async Task agregarAzync(double x)
        {
            bufferSize = list.Count;
            while (counter.Equals(bufferSize) && noInterested ==true) await Task.Delay(1000);
            noInterested = true;
            list.Add(x);
            counter++;
            noInterested = false;
        }

        private static async Task consumirAsync()
        {
            while (counter.Equals(0)||counter<0 && noInterested==true) await Task.Delay(1000);
            noInterested = true;
            double x = consulta();
            list.Remove(x);
            counter--;
            noInterested = false;
        }

        private static int consulta() { Random ran = new Random(); return ran.Next(list.Count); }

    }
}
