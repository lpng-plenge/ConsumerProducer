using System;
using System.Threading;

namespace ConsumerProducer
{
    class Program
    {

       private static int _numeroConsumidores = 5;
       private static int _numeroProductores = 3;
       private static int _tamBuffer = 10;
       private static int _tiempoConsumidor = 5*1000;
       private static int _tiempoProductor = 1000;

        static void Main(string[] args)
        {
            //call the threads producer and consumer 
            ProducerConsumer pc = new ProducerConsumer(_numeroConsumidores, _numeroProductores, _tamBuffer, _tiempoConsumidor,_tiempoProductor);
            pc.Comenzar();
            pc.Apagar(true);

            Console.WriteLine("Termino");
        }
    }
  
    }
