using System;
using System.Collections.Generic;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            NotasMusicais notas = new NotasMusicais();
            List<Nota> doRe = new List<Nota>();

            //Só é preciso instanciar uma unica vez notas, sempre sera instanciado o mesmo endereco de memoria do objeto de Nota;
            doRe.Add(notas.pega("do"));
            doRe.Add(notas.pega("re"));
            doRe.Add(notas.pega("do"));


            foreach (Nota item in doRe)
            {
                Console.WriteLine(item.GetHashCode());
            }

            Console.ReadLine();
        }
    }
}
