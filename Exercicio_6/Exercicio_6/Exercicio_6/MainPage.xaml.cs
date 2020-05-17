using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercicio_6
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int idade = 0, valor = 100;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_calcular_valor_plano_Clicked(object sender, EventArgs e)
        {
            valor = 100;
            if(!int.TryParse(txt_idade.Text, out idade))
            {
                DisplayAlert("Atenção", "Digite um valor válido!", "Fechar");
            }
            else
            {
                if (idade < 10)
                {
                    valor += 80;
                }else if (idade>=10 && idade<=30)
                {
                    valor += 50;
                }else if(idade>30 && idade <= 60)
                {
                    valor += 95;
                }
                else
                {
                    valor += 130;
                }

                txt_resultado.Text = "O valor a ser pago é " + valor;
            }
                
        }
    }
}
