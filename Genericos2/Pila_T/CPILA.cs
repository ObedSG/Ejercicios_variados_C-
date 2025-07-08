using System;

namespace Genericos
{

    class Pila<T>
    {
        private T valor;
        private int tam;
        List<T> Valores_Pila;
        public Pila(int tamanio)
        {
            tam = tamanio;
            Valores_Pila = new List<T>(tam);

        }



        public void push(T valor_enviado)
        {
            try
            {
                if (Valores_Pila.Count < tam)
                {
                    Valores_Pila.Add(valor_enviado);
                }
                else
                System.Console.WriteLine("fuera del rango,");
    



            } catch
            {
                                    throw new OperationCanceledException("la pila esta llena, no acepta mas valores");


            }
            }
            


        public List<T> pop(int indice)
        {
            if (Valores_Pila.Count == 0)
            {
                System.Console.WriteLine("\tLA PILA ESTA VACIA\n");
            }
            Valores_Pila.RemoveAt(Valores_Pila.Count - 1);
            {

            }
            return Valores_Pila;
        }
        public List<T> pop()
        {
            if (Valores_Pila.Count == 0)
            {
                System.Console.WriteLine("\tLA PILA ESTA VACIA\n");
            }
            Valores_Pila.RemoveAt(Valores_Pila.Count - 1);
            {

            }
            return Valores_Pila;
        }

        public T peak()
        {

            return Valores_Pila.Last();
        }

    }
}