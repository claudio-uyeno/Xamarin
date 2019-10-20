using Java.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteDrive.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgendamentoView : ContentPage
    {
        private readonly Veiculo veiculo;
        private readonly DetalhesView detalhesView;

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        private DateTime data = DateTime.Now;
        public DateTime Data { get { return data; } set { data = value; } }
        public Timestamp Hora { get; set; }

        public AgendamentoView(Veiculo veiculo, DetalhesView detalhes)
        {
            InitializeComponent();

            this.veiculo = veiculo;
            this.detalhesView = detalhes;
            this.Title = $"Agendamento ({veiculo.Modelo})";

            this.BindingContext = this;
        }

        private void Agendar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Agendamento enviado!", $"Veiculo: {veiculo.Modelo}. {detalhesView.InfoValorTotal}", "Ok");
        }
    }
}