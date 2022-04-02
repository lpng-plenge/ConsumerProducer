using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CPCode
{
    class ProducerConsumer
    {
        //Solucion 2 Varios Productores     
        Thread[] _consumidor;
        Thread[] _productor;
        Thread[] _singleConsumidor;
        Thread[] _singleProductor;

        Queue<int> _productos = new Queue<int>();
        Random ran = new Random();
        
        readonly object _noVacio = new object();

        private int _contador = 0,_timeConsumer=0, _timeProducer=0,_bufferSize = 0, _numConsumer=0, _numProducer=0, _productoEliminado=0, _productoAgregado=0;
        private int _contadorConsumidor = 0, _consumidorActual, _contadorProductor=0, _productorActual;

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
        //Clientes
        private void Produce()
        {
            while (_contador<_bufferSize)//seguir produciendo hasta que diga lo contrario
            {
                setContadorProductor(getProducer());
                lock (_noVacio)
                {
                    //while (_contador == _bufferSize) Monitor.Wait(_noVacio);
                    //Inicio Seccion Critica
                    _productorActual = getContadorProductor();
                    Console.WriteLine($"Entro cliente: {getProductorActual()}");
                    setProductoAgregado();
                    Console.WriteLine($"Se ha sentado en la silla: {getProductoAgregado()}");
                    //Final Seccion Critica
                    _contador++;
                    Monitor.Pulse(_noVacio);
                }
                Thread.Sleep(getTimeProductor());//se duerme al terminar de producir
            }
        }
        //Barbero
        private void  Consume()
        {
            while (true) //seguir cortando hasta que se diga lo contrario
            {
                setContadorConsumidor(getConsumer());
                //Colocar todos los hilos en 0
                lock (_noVacio)
                {
                    while (_contador == 0) Monitor.Wait(_noVacio);
                    //Inicio Seccion Critica
                    _consumidorActual = getContadorConsumidor();
                    Console.WriteLine($"Entro cliente: {getConsumidorActual()}");
                    setProductoTomado();
                    Console.WriteLine($"Ha cortado el cabello del cliente: {getProductoEliminado()}");
                    //Final Seccion Critica
                    _contador--;
                }
                Thread.Sleep(getTimeConsumidores());//si esta bloqueado a dormir
                //if (_contador <= 0) return;
            }
        }

        private void setProductoAgregado()
        {
            this._productoAgregado = ran.Next(100);
            _productos.Enqueue(this._productoAgregado);
        }

        private void setProductoTomado()
        {
            int primerElemento=0;
            this._productoEliminado = _productos.ElementAt(primerElemento);
            _productos.Dequeue();
        }

        //PUBLICOS 
        public void Comenzar()
        {
            //Descomentar Si es Un Solo Productor(_singleProductor = new Thread(Produce)).Start();
            _productor = new Thread[getProducer()];
            for (int i = 0; i < getProducer(); i++)
            {
                (_productor[i] = new Thread(Produce)).Start();
            }
            //Descomentar Si es Un Solo Consumidor(_singleConsumidor = new Thread(Consume)).Start();
            _consumidor = new Thread[getConsumer()];
            for (int i = 0; i < getConsumer(); i++)
            {
                (_consumidor[i] = new Thread(Consume)).Start();
            }
        }
        public void AgregarProductor()
        {
            setProducer(getProducer() + 1);
            Thread _singleProductor = new Thread(Produce);
            _singleProductor.Start();
        }
        public void AgregarConsumidor()
        {
            setConsumer(getConsumer() + 1);
            Thread _singleConsumidor = new Thread(Consume);
            _singleConsumidor.Start();
        }

        public void Detener()
        {
            foreach (Thread consumidor in _consumidor) consumidor.Abort();
            foreach (Thread productor in _productor) productor.Abort();

        }

        public void Finalizar(bool esperarConsumidores)
        {
            if (esperarConsumidores)
            {
                foreach (Thread consumidor in _consumidor) consumidor.Join();
                foreach (Thread productor in _productor) productor.Join();
            }
            Detener();
        }

        //Gets
        public int[] getQueue()
        {
            int[] buffer ;
            if (_productos.Count != null)
            {
                buffer = new int[_productos.Count];
                for (int i = 0; i < _productos.Count; i++)
                {
                    buffer[i] = _productos.ElementAt(i);
                }
            }
            else
            {
                buffer = null;
            }
            return buffer;
        }
        public int getQueueLong()
        {
            return this._productos.Count;
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
        public int getBuffer()
        {
            return this._bufferSize;
        }
        public int getContadorConsumidor()
        {
            return this._contadorConsumidor;
        }
        public int getConsumidorActual()
        {
            return this._consumidorActual;
        }
        public int getContadorProductor()
        {
            return this._contadorProductor;
        }
        public int getProductorActual()
        {
            return this._productorActual;
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

        public void setContadorConsumidor(int x)
        {
            if (this._contadorConsumidor >= x) this._contadorConsumidor = 0;
            this._contadorConsumidor++;
        }
        public void setContadorProductor(int x)
        {
            if (this._contadorProductor >= x) this._contadorProductor = 0;
            this._contadorProductor++;
        }
    }
}
