using System.Windows.Input;

namespace CRM.UI.Component;

public partial class PopupTextEntry : ContentView
{
	public PopupTextEntry()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty LabelProperty = BindableProperty.Create(
        nameof(Label),
        typeof(string),
        typeof(PopupInfo),
        string.Empty,
        BindingMode.TwoWay);

    

    public static readonly BindableProperty StringDataProperty = BindableProperty.Create(
        nameof(StringData),
        typeof(string),
        typeof(PopupInfo),
        string.Empty,
        BindingMode.TwoWay);

    public string StringData
    {
        get => (string)GetValue(StringDataProperty);
        set => SetValue(StringDataProperty, value);
    }

    public string Label
    {
        get => (string)GetValue(LabelProperty);
        set => SetValue(LabelProperty, value);
    }
}