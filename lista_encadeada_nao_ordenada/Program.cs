using System;
using System.Collections.Generic;

namespace lista_encadeada_nao_ordenada
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Lista();

            list.inserirFinalLista(20);
            list.inserirFinalLista(60);
            list.inserirFinalLista(40);
            list.inserirFinalLista(30);
            list.imprimeLista();
            list.removeItemLista(40);
            list.imprimeLista();
            Console.Read();

        }
    }

    public class NO
    {
        public int num { get; set; }
        public NO prox { get; set; }
    }

    public class Lista
    {
        private NO no, final;
        public void inserirInicioLista(int value)
        {
            NO novo = new NO();
            novo.num = value;
            if (no == null)
            {
                no = novo;
                final = novo;
                novo.prox = null;

            }
            else
            {

                novo.prox = no;
                no = novo;

            }


        }
        public void inserirFinalLista(int value)
        {

            NO novo = new NO();
            novo.num = value;
            if (no == null)
            {
                no = novo;
                final = novo;
                novo.prox = null;

            }
            final.prox = novo;
            final = novo;
            final.prox = null;



        }
        public void imprimeLista()
        {
            NO contador;
            for (contador = no; contador != null; contador = contador.prox)
            {
                Console.WriteLine($"{contador.num} ");
            }

        }

        public void removeItemLista(int val)
        {
            NO aux = no;
            NO anterior = null;

            while (aux != null)
            {
                if (val == aux.num)
                {
                    if (aux == no)
                    {
                        no = aux.prox;
                        aux = no;
                    }
                    else if (aux == final)
                    {
                        anterior.prox = null;
                        final = anterior;
                    }
                    else
                    {
                        anterior.prox = aux.prox;
                        aux = anterior.prox;
                    }
                }
                anterior = aux;
                aux = aux.prox;
            }
        }
    }
}
