namespace AulaPOOCartao
{
    public class Mastercard : Cartao
    {
        public int parcelas { get; set; }

        public void ComprarComDesconto (float desconto) {
           System.Console.WriteLine($"Compra realizada com {parcelas} parcelas e R$ {desconto} de desconto.");
        }
    }
}