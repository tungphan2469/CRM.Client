using System.Windows.Input;

namespace CRM.UI.Component;

public partial class ConfirmPopup : ContentView
{
    public ConfirmPopup()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty TitleProperty = BindableProperty.Create(
    nameof(Title),
    typeof(string),
    typeof(ConfirmPopup),
    string.Empty,
    BindingMode.TwoWay);

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public static readonly BindableProperty MessageProperty = BindableProperty.Create(
    nameof(Message),
    typeof(string),
    typeof(ConfirmPopup),
    string.Empty,
    BindingMode.TwoWay);

    public string Message
    {
        get => (string)GetValue(MessageProperty);
        set => SetValue(MessageProperty, value);
    }

    public static readonly BindableProperty ConfirmCommandProperty = BindableProperty.Create(
    nameof(ConfirmCommand),
    typeof(ICommand),
    typeof(ConfirmPopup),
    default(ICommand),
    BindingMode.TwoWay);

    public ICommand ConfirmCommand
    {
        get => (ICommand)GetValue(ConfirmCommandProperty);
        set => SetValue(ConfirmCommandProperty, value);
    }

    public static readonly BindableProperty CancelCommandProperty = BindableProperty.Create(
    nameof(CancelCommand),
    typeof(ICommand),
    typeof(ConfirmPopup),
    default(ICommand),
    BindingMode.TwoWay);

    public ICommand CancelCommand
    {
        get => (ICommand)GetValue(CancelCommandProperty);
        set => SetValue(CancelCommandProperty, value);
    }

    public static readonly BindableProperty IsOpenProperty = BindableProperty.Create(
   nameof(IsOpen),
   typeof(bool),
   typeof(ConfirmPopup),
   false,
   BindingMode.TwoWay);

    public bool IsOpen
    {
        get => (bool)GetValue(IsOpenProperty);
        set => SetValue(IsOpenProperty, value);
    }
}