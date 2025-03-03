using CRM.Library.Entities;
using System.Windows.Input;

namespace CRM.UI.Component;

public partial class PopupInfo : ContentView
{
    public PopupInfo()
    {
        InitializeComponent();

    }
    public static readonly BindableProperty CancelCommandProperty = BindableProperty.Create(
        nameof(CancelCommand),
        typeof(ICommand),
        typeof(PopupInfo),
        default(ICommand),
        BindingMode.TwoWay);


    public static readonly BindableProperty CloseCommandProperty = BindableProperty.Create(
        nameof(CloseCommand),
        typeof(ICommand),
        typeof(PopupInfo),
        default(ICommand),
        BindingMode.TwoWay);


    public static readonly BindableProperty IsOpenProperty = BindableProperty.Create(
        nameof(IsOpen),
        typeof(bool),
        typeof(PopupInfo),
        default(bool),
        BindingMode.TwoWay);

    public static readonly BindableProperty MessageProperty = BindableProperty.Create(
        nameof(Message),
        typeof(string),
        typeof(PopupInfo),
        default(string),
        BindingMode.TwoWay);

    public static readonly BindableProperty OkCommandProperty = BindableProperty.Create(
        nameof(OkCommand),
        typeof(ICommand),
        typeof(PopupInfo),
        default(ICommand),
        BindingMode.TwoWay);

    public static readonly BindableProperty OkTextProperty = BindableProperty.Create(
        nameof(OkText),
        typeof(string),
        typeof(PopupInfo),
        default(string),
        BindingMode.TwoWay);

    public static readonly BindableProperty PopupHeightProperty = BindableProperty.Create(
        nameof(PopupHeight),
        typeof(double),
        typeof(PopupInfo),
        default(double),
        BindingMode.TwoWay);

    public static readonly BindableProperty PopupWidthProperty = BindableProperty.Create(
        nameof(PopupWidth),
        typeof(double),
        typeof(PopupInfo),
        default(double),
        BindingMode.TwoWay);


    public static readonly BindableProperty TitlePopupProperty = BindableProperty.Create(
        nameof(TitlePopup),
        typeof(string),
        typeof(PopupInfo),
        default(string),
        BindingMode.TwoWay);

    public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create(
        nameof(CommandParameter),
        typeof(Role),
        typeof(PopupInfo),
        default(Role),
        BindingMode.TwoWay);

    public static readonly BindableProperty RoleInfoProperty = BindableProperty.Create(
        nameof(RoleInfo),
        typeof(Role),
        typeof(PopupInfo),
        default(Role),
        BindingMode.TwoWay);

    public static readonly BindableProperty CustomHeightProperty = BindableProperty.Create(
        nameof(CustomHeight),
        typeof(double),
        typeof(PopupInfo),
        default(double),
        BindingMode.TwoWay);

    public static readonly BindableProperty CustomWidthProperty = BindableProperty.Create(
        nameof(CustomWidth),
        typeof(double),
        typeof(PopupInfo),
        default(double),
        BindingMode.TwoWay);
    public double CustomWidth
    {
        get => (double)GetValue(CustomWidthProperty);
        set => SetValue(CustomWidthProperty, value);
    }

    public double CustomHeight
    {
        get => (double)GetValue(CustomHeightProperty);
        set => SetValue(CustomHeightProperty, value);
    }
    public Role RoleInfo
    {
        get => (Role)GetValue(RoleInfoProperty);
        set => SetValue(RoleInfoProperty, value);
    }
    public Role CommandParameter
    {
        get => (Role)GetValue(CommandParameterProperty);
        set => SetValue(CommandParameterProperty, value);
    }

    public ICommand CancelCommand
    {
        get => (ICommand)GetValue(CancelCommandProperty);
        set => SetValue(CancelCommandProperty, value);
    }


    public ICommand CloseCommand
    {
        get => (ICommand)GetValue(CloseCommandProperty);
        set => SetValue(CloseCommandProperty, value);
    }


    public double ContentWidth
    {
        get => (double)GetValue(PopupHeightProperty);
        set => SetValue(PopupHeightProperty, value);
    }

    public bool IsOpen
    {
        get => (bool)GetValue(IsOpenProperty);
        set => SetValue(IsOpenProperty, value);
    }

    public string Message
    {
        get => (string)GetValue(MessageProperty);
        set => SetValue(MessageProperty, value);
    }

    public ICommand OkCommand
    {
        get => (ICommand)GetValue(OkCommandProperty);
        set => SetValue(OkCommandProperty, value);
    }

    public string OkText
    {
        get => (string)GetValue(OkTextProperty);
        set => SetValue(OkTextProperty, value);
    }

    public double PopupHeight
    {
        get => (double)GetValue(PopupHeightProperty);
        set => SetValue(PopupHeightProperty, value);
    }

    public double PopupWidth
    {
        get => (double)GetValue(PopupWidthProperty);
        set => SetValue(PopupWidthProperty, value);
    }

    public string TitlePopup
    {
        get => (string)GetValue(TitlePopupProperty);
        set => SetValue(TitlePopupProperty, value);
    }
}