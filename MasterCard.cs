namespace Encapsulamento
{
    public class MasterCard : Cartao
    {
        public int parcelas {get; set;}

        public void ComprarComDescontoMastercard(float desconto){
            // Utilizando o encapsulamento "protected"
            cvv = "456";

            System.Console.WriteLine($"Compra realizada com {parcelas} parcelas e R$ {desconto} de desconto");
        }
    }
}