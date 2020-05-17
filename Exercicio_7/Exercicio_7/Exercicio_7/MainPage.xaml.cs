using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercicio_7
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        double valor = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_calcular_juros_Clicked(object sender, EventArgs e)
        {
            if(!double.TryParse(txt_valor.Text, out valor))
            {
                DisplayAlert("Atenção", "Digite um valor válido", "Fechar");
            }
            else
            {
                int i = 2;
                string resultado = "O valor do mês 1 é R$ "+ Math.Round(valor, 2) +"\n";
                while (i<=12)
                {
                    valor += valor * 0.05;
                    resultado += "O valor do mês " + i + " é R$ " + Math.Round(valor, 2) +"\n";
                    i++;
                }

                txt_resultado.Text = resultado;
            }
        }
    }
}
