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
            while (_contador<_bufferSize)//seguir produciendo hasta que diga lo contrario
            {
                Console.WriteLine("Productor en espera...\n");
                //seccion critica
                lock (_noVacio)
                {
                    while (_contador == _bufferSize) Monitor.Wait(_noVacio);
                    //Inicio Seccion Critica
                    Console.WriteLine("Entro un productor...");
                    setProductoAgregado();
                    Console.WriteLine($"Se ha producido el producto: {getProductoAgregado()}");
                    Console.WriteLine($"Duracion: {getTimeProductor()}\n");
                    //Final Seccion Critica
                    _contador++;
                    Monitor.Pulse(_noVacio);
                    Thread.Sleep(getTimeProductor());
                }
            }
        }

        private void Consume()
        {
            while (true) //seguir consumiendo hasta que se diga lo contrario
            {
                Console.WriteLine("Consumidor en espera...\n");
                lock (_noVacio){
                    while (_contador== 0) Monitor.Wait(_noVacio);
                    //Inicio Seccion Critica
                    Console.WriteLine("Entro un consumidor");
                    setProductoTomado();
                    Console.WriteLine($"Se ha consumido el producto : {getProductoEliminado()}");
                    Console.WriteLine($"Duracion: {getTimeConsumidores()}\n");
                    //Final Seccion Critica
                    _contador--;
                }
                Thread.Sleep(getTimeConsumidores());
                if (_contador <= 0) return;
            }
        }

        private void setProductoAgregado()
        {
            this._productoAgregado = ran.Next(100);
            _productos.Enqueue(this._productoAgregado);
        }

        private void setProductoTomado()
        {
            int ubicacion=0;
            this._productoEliminado = _productos.ElementAt(ubicacion);
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
            //Descomentar Si es Un Solo Consumidor(_consumidor = new Thread(Consume)).Start();
            _consumidor = new Thread[getConsumer()];
            for (int i = 0; i < getConsumer(); i++)
            {
                (_consumidor[i] = new Thread(Consume)).Start();
            }
        }

        public void Apagar(bool esperarConsumidores)
        {
            if (esperarConsumidores)
            {
                foreach (Thread consumidor in _consumidor) consumidor.Join();
                foreach (Thread productor in _productor) productor.Join();
            }
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
