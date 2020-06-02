namespace Encapsulamento
{
    public class MasterCard : Cartao
    {
        public int parcelas {get; set;}

        public void ComprarComDescontoMastercard(float desconto){
            
            cvv = "665";

            System.Console.WriteLine($"Compra realizada com {parcelas} parcelas e R$ {desconto} de desconto");
        }
    }
}