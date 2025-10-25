using MVVM_JDDLG.MVVM.ViewsModels;

namespace MVVM_JDDLG.MVVM.Views;

public partial class PersonView : ContentPage
{
    public PersonView()
    {
        InitializeComponent();

        BindingContext = new PersonViewModelcs();
    }
}