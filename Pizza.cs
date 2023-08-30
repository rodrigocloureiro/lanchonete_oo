namespace lanchonete_OO
{
    public class Pizza : Prato
    {
        private string _recheio;
        private string _borda;
        private string _molho;
         
        public Pizza(double precoVenda, string dataValidade, double peso, string recheio, string borda, string molho) : base(precoVenda, dataValidade, peso)
        {
            _recheio = recheio;
            _borda = borda;
            _molho = molho;
        }

        public string Recheio
        {
            get { return _recheio; }
            set { _recheio = value; }
        }

        public string Borda
        {
            get { return _borda; }
            set { _borda = value; }
        }

        public string Molho
        {
            get { return _molho; }
            set { _molho = value; }
        }
    }
}
