
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteDrive.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalhesView : ContentPage
    {
        public Veiculo Veiculo { get; set; }

        private const decimal VALOR_FREIO_ABS = 800;
        private const decimal VALOR_AR_CONDICIONADO = 1000;
        private const decimal VALOR_TRAVA_ELETRICA = 1500;


        private bool temFreioAbs;
        public bool TemFreioAbs { get { return temFreioAbs; } set { temFreioAbs = value; OnPropertyChanged(nameof(InfoValorTotal)); } }
        public string InfoFreioAbs { get { return $"Freio ABS - R$ {VALOR_FREIO_ABS}"; } }

        private bool temArCondicionado;
        public bool TemArCondicionado { get { return temArCondicionado; } set { temArCondicionado = value; OnPropertyChanged(nameof(InfoValorTotal)); } }
        public string InfoArCondicionado { get { return $"Ar Condicionado - R$ {VALOR_AR_CONDICIONADO}"; } }

        private bool temTravaEletrica;
        public bool TemTravaEletrica { get { return temTravaEletrica; } set { temTravaEletrica = value; OnPropertyChanged(nameof(InfoValorTotal)); } }
        public string InfoTravaEletrica { get { return $"Trava Elétrica - R$ {VALOR_TRAVA_ELETRICA}"; } }

        private decimal valorTotal;
        public string InfoValorTotal 
        { 
            get { return $"Valor total: R$ {CalcularValor()}";} 
            set { valorTotal = CalcularValor(); }  
        }


        public DetalhesView(Veiculo veiculo)
        {
            InitializeComponent();

            this.Veiculo = veiculo;

            //set titulo na página (sem binding)
            //this.Title = veiculo.Modelo;
            
            this.BindingContext = this;
        }

        private void btProximo_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AgendamentoView(Veiculo, this));
        }

        private decimal CalcularValor()
        {
            return Veiculo.Valor + (TemArCondicionado ? VALOR_AR_CONDICIONADO : 0) + (TemFreioAbs ? VALOR_FREIO_ABS : 0) + (TemTravaEletrica ? VALOR_TRAVA_ELETRICA : 0);
        }
    }


}