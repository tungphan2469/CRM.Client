namespace CRM.UI.Component;

public partial class PopupActivityButton : ContentView
{
    public PopupActivityButton()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty LabelProperty = BindableProperty.Create(
    nameof(Label),
    typeof(string),
    typeof(PopupActivityButton),
    string.Empty,
    BindingMode.TwoWay);

    public string Label
    {
        get => (string)GetValue(LabelProperty);
        set => SetValue(LabelProperty, value);
    }
}