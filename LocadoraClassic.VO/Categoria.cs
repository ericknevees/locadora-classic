using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.VO
{
    public class Categoria
    {
        public string Nome {get; set;}
        public string Valor_diaria { get; set;}

        public Categoria() 
        { 

        }
        public Categoria(string nome, string valor_diaria)
        {
            Nome = nome;
            Valor_diaria = valor_diaria;
        }
        public Categoria(string valor_diaria)
        {
            Valor_diaria = valor_diaria;
        }
    }
}
