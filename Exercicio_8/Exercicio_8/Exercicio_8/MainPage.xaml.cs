using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercicio_8
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            int i = 1, res_fat = 1;
            string res = "0! = 1\n";
            while (i<10)
            {
                res_fat *= i;
                res += i+"! = "+res_fat+"\n";
                i++;
            }
            txt_resultado.Text = res;
        }
    }
}
