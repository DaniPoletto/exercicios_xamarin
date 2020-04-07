using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercicio_1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int num1;
        int num2;
        public MainPage()
        {
            InitializeComponent();
            num1 = 0;
            num2 = 0;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            int resultado = 0;

            if (!int.TryParse(txtNumero1.Text, out num1))
            {
                DisplayAlert("Atenção", "Informe um valor correto para o número 1", "Fechar");
            }

            else if (!int.TryParse(txtNumero2.Text, out num2))
            {
                DisplayAlert("Atenção", "Informe um valor correto para o número 2", "Fechar");
            }
            else
            {
                resultado = num1 + num2;
                txtResultado.Text = $"A soma de {num1} e {num2} é {resultado.ToString()}";
            }

        }
    }
}
