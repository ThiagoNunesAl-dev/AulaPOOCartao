namespace AulaPOOCartao
{
    public class Cartao
    {
        public string numero { get; set; }
        public string titular { get; set; }
        public string bandeira { get; set; }
        private string token = "naoseicomoeumtoken";
        protected int cvv = 123;

        public void AprovarCompra() {
            System.Console.WriteLine("Compra aprovada!"); 
        }

        private bool ValidarToken() {
            if (token != null) {
                return true;
            }
            return false;
        }

        protected bool ValidarCompra() {
            return true;
        }
    }
}