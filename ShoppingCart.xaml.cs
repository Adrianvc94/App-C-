using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Base21
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class shoppingCart : ContentPage
    {
        public shoppingCart()
        {
            InitializeComponent();
            btnBack.Clicked += BtnBack_Clicked;
        }

        private void BtnBack_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Page1());
        }
    }
}
