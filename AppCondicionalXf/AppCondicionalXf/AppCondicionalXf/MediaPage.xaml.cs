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
    public partial class MediaPage : ContentPage
    {
        //variaveis globais
        double numero1;
        double numero2;
        string aluno;

        //Metodo Construtor
        public MediaPage()
        {
            InitializeComponent();
            //Inicializa os valores
            numero1 = 0;
            numero2 = 0;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            aluno = txtNome.Text;
            numero1 = double.Parse(this.txtNumero1.Text);

            numero2 = double.Parse(this.txtNumero2.Text);

            //variaveis de escopo
            double resultado = (numero1 + numero2)/2;
            // DisplayAlert("Resultado", $"O resultado do aluno {aluno} é {resultado}", "Fechar");

            if (resultado >= 7)
            {
                txtResultado.Text = $"Aprovado com a média: {resultado.ToString()}";
            }
            else
            {
                txtResultado.Text = $"Reprovado com a média: {resultado.ToString()}";
            }

            //switch (resultado)
            //{
            //    case 7:
            //        txtResultado.Text = $"Aprovado com a média: {resultado.ToString()}";
            //        break;
            //    default:
            //        txtResultado.Text = $"Reprovado com a média: {resultado.ToString()}";
            //        break;
            //}

        }
    }
}