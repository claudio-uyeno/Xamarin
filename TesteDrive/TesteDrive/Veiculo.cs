namespace TesteDrive
{
    public class Veiculo
    {
        public string Modelo { get; set; }
        public decimal Valor { get; set; }
        public string ValorTratado { get { return string.Format("R$ {0}", this.Valor); } }
    }
}
