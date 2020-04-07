using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercicio_2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        double saldo;
        public MainPage()
        {
            InitializeComponent();
            saldo = 0;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double resultado = 0;
            if (!double.TryParse(txtSaldo.Text, out saldo))
            {
                DisplayAlert("Atenção", "Informe um valor correto para o saldo", "Fechar");
            }
            else
            {
                resultado = saldo * 1.01;
                txtResultado.Text = $"O valor com 1% é {resultado}";
            }
        }
    }
}
