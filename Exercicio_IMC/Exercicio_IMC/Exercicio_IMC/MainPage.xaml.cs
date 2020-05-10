using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercicio_IMC
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        double altura = 0;
        double peso = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void txt_calcularIMC_Clicked(object sender, EventArgs e)
        {
            double resultado = 0;
            string peso_resultado;

            if (!double.TryParse(txt_altura.Text, out altura))
            {
                DisplayAlert("Atenção", "Informe um valor correto para a altura", "Fechar");
            }else if (!double.TryParse(txt_peso.Text, out peso))
            {
                DisplayAlert("Atenção", "Informe um valor correto para o peso", "Fechar");
            }
            else
            {
                resultado = peso / (altura * altura);
                if (resultado < 18.5)
                {
                    peso_resultado = "abaixo do normal.";
                }
                else if(resultado >= 18.5 && resultado <= 24.9)
                {
                    peso_resultado = "normal.";
                }
                else if (resultado > 24.9 && resultado <= 29.9)
                {
                    peso_resultado = "acima do normal.";
                }
                else if (resultado > 29.9 && resultado <= 34.9)
                {
                    peso_resultado = "acima do normal - obesidade grau I.";
                }
                else if (resultado > 34.9 && resultado <= 39.9)
                {
                    peso_resultado = "acima do normal - obesidade grau II.";
                }
                else
                {
                    peso_resultado = "acima do normal - obesidade grau III ou mórbida.";
                }
                txt_resultado.Text = $"O valor do imc é {resultado}. Seu peso está {peso_resultado}";
            }
        }
    }
}
