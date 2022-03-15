using System;
using System.Collections.Generic;
using System.Linq;
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
        Random ran = new Random();
        
        readonly object _noVacio = new object();

        private int _contador = 0,_timeConsumer=0, _timeProducer=0,_bufferSize = 0, _numConsumer=0, _numProducer=0, _productoEliminado=0, _productoAgregado=0;

        //CONS
        public ProducerConsumer(int consumidor, int productor, int bS, int timeC, int timeP)
        {
            setBufferSize(bS);
            setConsumer(consumidor);
            setProducer(productor);
            setTimeConsumidores(timeC);
            setTimeProductores(timeP);   
        }

        //PRIVADOS
        private void Produce()
        {
            while (_productos.Count < _bufferSize)//seguir produciendo hasta que diga lo contrario
            {
                //seccion critica
                lock (_noVacio)
                {
                    while (_contador == _bufferSize) Monitor.Wait(_noVacio);
                    setProductoAgregado();
                    Thread.Sleep(getTimeProductor());
                    //Console.WriteLine($"Duracion: {getTimeProductor()}\n");
                    _contador++;                    
                    Monitor.Pulse(_noVacio);
                }

            }
        }

        private void Consume()
        {
            while (_productos.Count>= 0) //seguir consumiendo hasta que se diga lo contrario
            {
                //seccion critica
                lock (_noVacio){
                    while (_contador== 0) Monitor.Wait(_noVacio);
                    setProductoTomado();
                    Thread.Sleep(getTimeConsumidores());
                    //Console.WriteLine($"Duracion: {getTimeConsumidores()}\n");
                    _contador--;
                    Monitor.Pulse(_noVacio);
                }
            }
        }
        
        private void setProductoAgregado()
        {
            Console.WriteLine("Se esta produciendo...");
            this._productoAgregado = ran.Next(500);
            _productos.Enqueue(this._productoAgregado);
            Console.WriteLine($"Se ha producido el producto: {this._productoAgregado}");
        }

        private void setProductoTomado()
        {
            //Se elimina el primero que se agrego a la cola
            int contador=0;
            Console.WriteLine("Entro un consumidor");
            this._productoEliminado = _productos.ElementAt(contador);
            Console.WriteLine($"Se ha consumido el producto : {this._productoEliminado}");
            _productos.Dequeue();
        }

        //PUBLICOS 

        public void Comenzar()
        {

            //Descomentar Si es Un Solo Productor(_productor = new Thread(Produce)).Start();

            _productor = new Thread[getProducer()];
            for (int i = 0; i < getProducer(); i++)
            {
                (_productor[i] = new Thread(Produce)).Start();
            }

            _consumidor = new Thread[getConsumer()];
            for (int i = 0; i < getConsumer(); i++)
            {
                (_consumidor[i] = new Thread(Consume)).Start();
            }
        }

        public void Apagar(bool esperarConsumidores)
        {
            // Wait for workers to finish
            if (esperarConsumidores)
                foreach (Thread consumidor in _consumidor)
                    consumidor.Join();
        }
        //Gets
        public void getQueue()
        {
            Console.WriteLine("Valores de la cola: ");
            foreach (Object ob in _productos) Console.WriteLine($" {ob}");
            Console.WriteLine("\n");
        }
        public int getProductoEliminado()
        {
            return this._productoEliminado;
        }
        public int getProductoAgregado()
        {
            return this._productoAgregado;
        }
        public int getTimeProductor()
        {
            return this._timeProducer;
        }
        public int getTimeConsumidores()
        {
            return this._timeConsumer;
        }
        public int getConsumer()
        {
            return this._numConsumer;
        }
        public int getProducer()
        {
            return this._numProducer;
        }
        //Sets
        public void setTimeProductores(int timeP)
        {
            this._timeProducer = Math.Abs(timeP / getProducer());
        }

        public void setTimeConsumidores( int timeC)
        {
            this._timeConsumer = Math.Abs(timeC/getConsumer());
        }
        
        public void setConsumer(int c)
        {
            this._numConsumer = c;
        }

        public void setProducer(int p)
        {
            this._numProducer = p;
        }

        public void setBufferSize(int x)
        {
            this._bufferSize = x;
        }
    }
}
