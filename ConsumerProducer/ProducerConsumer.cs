using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace ConsumerProducer
{
    class ProducerConsumer
    {
        //Solucion 2 Varios Productores     
        Thread[] _consumidor;
        //Thread _consumidor;
        Thread[] _productor;
        Queue<int> _productos = new Queue<int>();
        
        readonly object _bloqueo = new object();
        private int _contador = 0,_timeConsumer, _timeProducer,_bufferSize = 0, _numConsumer, _numProducer;

        //Constructor
        public ProducerConsumer(int consumidor, int productor, int bS, int timeC, int timeP)
        {
            //Calling Methods
            setBufferSize(bS);
            setConsumer(consumidor);
            setProducer(productor);
            setTimeConsumidores(timeC);
            setTimeProductores(timeP);   
        }

        public void Comenzar()
        {

            //Un Solo Productor(_productor = new Thread(Produce)).Start();
            _productor = new Thread[getProducer()];
            for (int i =0; i<getProducer(); i++)
            {
                (_productor[i] = new Thread(Produce)).Start();
            }

            //Consumidores
            _consumidor = new Thread[getConsumer()];
            for (int i = 0; i < getConsumer(); i++)
            {
                (_consumidor[i] = new Thread(Consume)).Start();
            }
        }

        private void Consume()
        {
            int productoEliminado = 0;
            while (_contador>=0) //seguir consumiendo hasta que se diga lo contrario
            {
                //seccion critica
                lock (_bloqueo){
                    while (_productos.Count == 0) Monitor.Wait(_bloqueo);
                    Console.WriteLine("Entro un consumidor");
                    productoEliminado = _productos.Count;
                    _productos.Dequeue();
                    _contador--;
                    
                    //Duracion del Hilo
                    Thread.Sleep(getTimeConsumidores());
                    Console.WriteLine($"Se ha consumido el producto : {productoEliminado}");
                    Console.WriteLine($"Duracion: {getTimeConsumidores()}\n");
                }
            }
        }

        private void Produce()
        {
            while (_contador<_bufferSize)//seguir produciendo hasta que diga lo contrario
            {
                //seccion critica
                lock (_bloqueo) {
                    while (_productos.Count == _bufferSize) Monitor.Wait(_bloqueo);
                    Console.WriteLine("Se esta produciendo...");
                    _productos.Enqueue(_contador);
                    _contador++;

                    //Duracion del Hilo
                    Thread.Sleep(getTimeProductor());
                    Console.WriteLine($"Se ha producido el producto: {_productos.Count}");
                    Console.WriteLine($"Duracion: {getTimeProductor()}\n");
                    
                    //Notificar
                    Monitor.Pulse(_bloqueo);
                }

            }
        }

        public void setTimeProductores(int timeP)
        {
            this._timeProducer = Math.Abs(timeP / getProducer());
        }

        public  int getTimeProductor()
        {
            return this._timeProducer;
        }

        public void setBufferSize(int x)
        {
             this._bufferSize= x;
        }
        public void setTimeConsumidores( int timeC)
        {
            this._timeConsumer = Math.Abs(timeC/getConsumer());
        }
        public int getTimeConsumidores()
        {
            return this._timeConsumer;
        }
        public void setConsumer(int c)
        {
            this._numConsumer = c;
        }
        public int getConsumer()
        {
            return this._numConsumer;
        }
        public void setProducer(int p)
        {
            this._numProducer = p;
        }
        public int getProducer()
        {
            return this._numProducer;
        }
    }
}
