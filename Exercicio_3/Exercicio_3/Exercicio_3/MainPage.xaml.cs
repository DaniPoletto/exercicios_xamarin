using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercicio_3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int numero = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void txt_calcular_divivisel_3_Clicked(object sender, EventArgs e)
        {
            int resultado = 0;
            if (!int.TryParse(txt_numero.Text, out numero))
            {
                DisplayAlert("Atenção", "Digite corretamente o número!", "Fechar");
            }
            else
            {
                resultado = numero % 3;
                if (resultado == 0)
                {
                    txt_resultado.Text = $"O número {numero} é divisivel por 3. ";
                }
                else
                {
                    txt_resultado.Text = $"O número {numero} não é divisivel por 3. ";
                }
            }

        }
    }
}
