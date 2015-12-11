using System.Windows;

public partial class MainWindow : Window
{
    private TestViewModel viewModel;
    private ValidateIsNot validateIsNot;
    public MainWindow()
    {
        DataContextChanged += MainWindow_DataContextChanged;
        InitializeComponent();
        viewModel = new TestViewModel();
        DataContext = viewModel;
    }

    private void MainWindow_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
        validateIsNot = new ValidateIsNot(87);
        NulleableMultiBinding.ValidationRules.Add(validateIsNot);
    }
}