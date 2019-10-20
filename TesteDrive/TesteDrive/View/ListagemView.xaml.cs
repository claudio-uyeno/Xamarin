using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace TesteDrive.View
{
    [DesignTimeVisible(false)]
    public partial class ListagemView : ContentPage
    {
        public IList<Veiculo> Veiculos { get; set; }

        public ListagemView()
        {
            InitializeComponent();

            listaVeiculos.ItemsSource = new List<Veiculo>
            {
                new Veiculo {Modelo = "Modelo 1", Valor = 40000},
                new Veiculo {Modelo = "Modelo 2", Valor = 30000},
                new Veiculo {Modelo = "Modelo 3", Valor = 50000}
            };

            this.BindingContext = this;
        }

        private void listaVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            //adiciona nova página a pilha de navegação
            Navigation.PushAsync(new DetalhesView(veiculo));
        }
    }
}
