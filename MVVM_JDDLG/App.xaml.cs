using MVVM_JDDLG.MVVM.Views;

namespace MVVM_JDDLG
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ComandosView ();
        }
    }
}
