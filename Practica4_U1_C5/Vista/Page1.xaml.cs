using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica4_U1_C5.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica4_U1_C5.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            BindingContext = new VMpage1(Navigation);
        }
    }
}