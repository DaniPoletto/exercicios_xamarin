using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercicio_4
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int mes = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_temporada_Clicked(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_mes.Text, out mes))
            {
                DisplayAlert("Atenção", "Digite corretamente o mes", "Fechar");
            }else if (mes<1 || mes>12)
            {
                DisplayAlert("Atenção", "Digite um mes entre 1 e 12.", "Fechar");
            }
            else
            {
                if (mes==1 || mes==2 || mes==6 || mes==7 || mes==12 )
                {
                    txt_resultado.Text = $"O mês {mes} é de alta temporada";
                }
                else
                {
                    txt_resultado.Text = $"O mês {mes} é de baixa temporada";
                }
            }
        }
    }
}
