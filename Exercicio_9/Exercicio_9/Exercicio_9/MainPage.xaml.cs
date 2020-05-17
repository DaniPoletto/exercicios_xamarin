using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercicio_9
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            int i = 0;
            string res = "";
            while (i <= 100)
            {
                if (i %2 !=0)
                {
                    res += "*\n";
                }
                else
                {
                    res += "**\n";
                }
                i++;
            }
            txt_resultado.Text = res;
        }
    }
}
