using MVVM_JDDLG.MVVM.ViewsModels;

namespace MVVM_JDDLG.MVVM.Views;

public partial class GenteView : ContentPage
{
    public GenteView()
    {
        InitializeComponent();
        BindingContext = new GenteViewsModel();
    }
}