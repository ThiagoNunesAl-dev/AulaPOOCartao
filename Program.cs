using System;

namespace AulaPOOCartao
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao card = new Cartao();
            card.numero = "1111 1111 1111 1111";
            card.titular = "Ednaldo Pereira";
            card.bandeira = "MasterCard";
            card.AprovarCompra();

            Mastercard master = new Mastercard();
            master.parcelas = 3;
            master.ComprarComDesconto(100f);
        }
    }
}
