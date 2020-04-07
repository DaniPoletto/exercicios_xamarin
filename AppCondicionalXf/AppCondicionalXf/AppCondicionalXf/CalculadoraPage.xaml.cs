using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCondicionalXf
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculadoraPage : ContentPage
    {
        //variavel global
        double valor1,valor2;
        //vetor = array
        string[] operacoes = { "Adição", "Subtração", "Multiplicação", "Divisão" };

        public CalculadoraPage()
        {
            InitializeComponent();
            //Inicializando os valores
            valor1 = 0;
            valor2 = 0;
            pckOperacao.ItemsSource = operacoes;
            pckOperacao.SelectedIndex = 0;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            //declarar e inicializar variavel de escopo
            double resultado = 0;
            //entrada dos dados
            //validação

            if (!double.TryParse(txtValor1.Text, out valor1))
            {
                DisplayAlert("Atenção", "Informe um valor correto para o número 1", "Fechar");
            }

            else if (!double.TryParse(txtValor2.Text, out valor2))
            {
                DisplayAlert("Atenção", "Informe um valor correto para o número 2", "Fechar");
            }
            else
            {
                string operacao = pckOperacao.SelectedItem.ToString();
                switch (operacao)
                {
                    case "Adição":
                        resultado = valor1 + valor2;
                        break;
                    case "Subtração":
                        resultado = valor1 - valor2;
                        break;
                    case "Multiplicação":
                        resultado = valor1 * valor2;
                        break;
                    case "Divisão":
                        resultado = valor1 / valor2;
                        break;
                    default:
                        DisplayAlert("Atenção", "Operação selecionada inválida.", "Fechar");
                        break;
                }

                DisplayAlert("Atenção", $"Para a operação de {operacao} o resultado é {resultado}", "Fechar");
            }

        }
    }
}