namespace FactoryMethodSample
{
    public class CartaoVisaInfinite : CartaoDeCredito
    {
        public CartaoVisaInfinite(string nome, int limiteTotal)
            : base(nome, "Visa Infinite", limiteTotal)
        {
            Numero = GerarNumeroCartao();
        }


        public override string GerarNumeroCartao()
        {
            var rnd = new Random();
            int cardNumber1 = rnd.Next(4001, 4799);
            int cardNumber2 = rnd.Next(1000, 9999);
            int cardNumber3 = rnd.Next(1000, 9999);
            int cardNumber4 = rnd.Next(1000, 9999);

            return $"{cardNumber1}{cardNumber2}{cardNumber3}{cardNumber4}";
        }

        public override void Cashback()
        {
            Console.WriteLine("Após a compra o usuário recebeu 2,5% de cashback");
        }
    }
}
