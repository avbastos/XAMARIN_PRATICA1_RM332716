using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.ControlesBasicos
{
    public partial class MainPage : ContentPage
    {

        private Configuracao _vmConfig;
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Clicked(object sender, EventArgs e)
        {

            if (_vmConfig != null && _vmConfig.SendEmail)
            {
                DisplayAlert("Atenção", $"Email enviado para {_vmConfig.Email}", "OK");
            }
            else
            {
                DisplayAlert("Atenção"
                       , "E-mail não autorizado!"
                       , "OK");
            }
        }

        private void BtnConfig_Clicked(object sender, EventArgs e)
        {
            if (_vmConfig == null)
                _vmConfig = new Configuracao();

            Navigation.PushAsync(new ConfigPage() { BindingContext = _vmConfig });
        }
    }
}
