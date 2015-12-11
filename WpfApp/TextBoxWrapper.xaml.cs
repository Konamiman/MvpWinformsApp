using System.Windows;
using System.Windows.Controls;

public partial class TextBoxWrapper : UserControl
{
    /// <summary>
    /// Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
    /// </summary>
    public static readonly DependencyProperty ValueProperty =
        DependencyProperty.Register("Value", typeof(double?), typeof(TextBoxWrapper),
            new FrameworkPropertyMetadata(0.0, OnValueChanged)
            {
                BindsTwoWayByDefault = true
            });

    private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        //Do something
    }

    public static readonly DependencyProperty AnotherPropertyProperty =
        DependencyProperty.RegisterAttached(
            "AnotherProperty", typeof(int), typeof(TextBoxWrapper));

    public int AnotherProperty
    {
        get { return (int)GetValue(AnotherPropertyProperty); }
        set { SetValue(AnotherPropertyProperty, value); }
    }

    public double? Value
    {
        get { return (double?)GetValue(ValueProperty); }
        set { SetValue(ValueProperty, value); }
    }

    public TextBoxWrapper()
    {
        InitializeComponent();
    }

    private void OnTextBoxWrapperLoaded(object sender, RoutedEventArgs e)
    {
        AddDefaultValidationRules();
    }

    private bool isRequired = false;
    private void AddDefaultValidationRules()
    {
        AddValidationBinding(new ValidateIsNot(87));
        AddValidationBinding(new ValidateIsBiggerThanTen());
    }

    private void AddValidationBinding(ValidationRule validationRule)
    {
        TextBoxBinding.ValidationRules.Add(validationRule);
    }
}