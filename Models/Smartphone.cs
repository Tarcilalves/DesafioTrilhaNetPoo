using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTrilhaNetPoo.Models
{
     public abstract class Smartphone
    {

           // Construtor
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {//parâmetros do tipo 
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;            
        }

        //Atributos
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }



     
        //Métodos

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao(string v)
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}