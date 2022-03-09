using System;
using System.Threading;

namespace ConsumerProducer
{
    class Program
    {
        Random random = new Random();
        //MUTEX
        private static Mutex mut = new Mutex();
        private static int numThreads = 2; //cambiar con la interfaz

        //List Prueba 1
        static void Main(string[] args)
        {
            //call the threads producer and consumer 
               
        }

        private void producer()
        {
            while (true)
            {
                double x = random.Next(1000);
                Monitor.append(x);        
            }
        }

        private void consumer()
        {
            while (true)
            {
                Monitor.take();
            }
        }
    }
}
