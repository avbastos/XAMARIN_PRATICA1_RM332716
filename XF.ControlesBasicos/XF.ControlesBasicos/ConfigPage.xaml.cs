using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.ControlesBasicos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConfigPage : ContentPage
	{
       
        public ConfigPage ()
		{
			InitializeComponent ();
            txtEmail.IsEnabled = swtSendEmail.On;
        }

        private void SwitchCell_OnChanged(object sender, ToggledEventArgs e)
        {
            txtEmail.IsEnabled = swtSendEmail.On;
            if (!swtSendEmail.On)
            {
                txtEmail.Text = null;
            }
        }
    }
}