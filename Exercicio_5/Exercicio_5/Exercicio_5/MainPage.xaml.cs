using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercicio_5
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int dia = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_calcula_dia_Clicked(object sender, EventArgs e)
        {
            if(!int.TryParse(txt_dia.Text, out dia))
            {
                DisplayAlert("Atenção", "Digite um valor válido", "Fechar");
            }else if (dia<1 || dia>7 )
            {
                DisplayAlert("Atenção", "Digite um valor entre 1 e 7", "Fechar");
            }
            else
            {
                if (dia==1 || dia==7 )
                {
                    DisplayAlert("Aviso", "Fim de semana", "Fechar");
                }
                else
                {
                    DisplayAlert("Aviso", "Dia de semana", "Fechar");
                }
            }
        }
    }
}
