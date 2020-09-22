using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FlyWeight
{
    public class NotasMusicais
    {
        public Dictionary<String, Nota> notasDic = new Dictionary<string, Nota>();

        public NotasMusicais() {
            notasDic.Add("do", new Do());
            notasDic.Add("re", new Re());
        }
       

        public Nota pega(String nome)
        {
            if (notasDic.ContainsKey(nome))
            {
               return notasDic.GetValueOrDefault(nome);
            }

            throw new InvalidOperationException();
        }
    }
}
