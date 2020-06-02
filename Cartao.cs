
namespace Encapsulamento
{
    public class Cartao
    {
        public string numero {get; set;}
        public string titular {get; set;}
        public string bandeira {get; set;}
        public string token = "asdasd45454s5ad4545a8a7ds98a7sd89a7sd987asd98a7sd89";
        public string cvv {get; set;} 

        public void AprovarCompra(){
            System.Console.WriteLine("Aprovado!");
        }  

        private bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }

        protected bool ValidarCompra(){
            return true;
        }
    }
}