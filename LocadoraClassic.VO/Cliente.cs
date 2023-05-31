using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.VO
{
    public class Cliente
    {
        public int Id {  get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Whatsapp { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }

            
        public Cliente() 
        { 
        }
        public Cliente(int id)
        {
            Id = id;   
        }
        public Cliente(string nome, string endereco, string whatsapp)
        {
            Nome = nome;
            Endereco = endereco;
            Whatsapp = whatsapp;
        }

        public Cliente(string cPF, string rG)
        {
            CPF = cPF;
            RG = rG;
        }
    }
}
