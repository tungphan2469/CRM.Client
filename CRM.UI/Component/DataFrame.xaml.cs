namespace CRM.UI.Component;

public partial class DataFrame : ContentView
{
    public DataFrame()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty DataInfoProperty = BindableProperty.Create(
        nameof(DataInfo),
        typeof(string),
        typeof(DataFrame),
        default(string),
        BindingMode.TwoWay);


    public static readonly BindableProperty DataTitleProperty = BindableProperty.Create(
       nameof(DataTitle),
       typeof(string),
       typeof(DataFrame),
       default(string),
       BindingMode.TwoWay);

    public static readonly BindableProperty DataInfoColorProperty = BindableProperty.Create(
       nameof(DataInfoColor),
       typeof(Color),
       typeof(DataFrame),
       Colors.Black,
       BindingMode.TwoWay);

    public static readonly BindableProperty DataTitleColorProperty = BindableProperty.Create(
       nameof(DataTitleColor),
       typeof(Color),
       typeof(DataFrame),
       Colors.Black,
       BindingMode.TwoWay);

    public static readonly BindableProperty DataFrameBackgroundColorProperty = BindableProperty.Create(
       nameof(DataFrameBackgroundColor),
       typeof(Color),
       typeof(DataFrame),
       Colors.Black,
       BindingMode.TwoWay);

    public static readonly BindableProperty DataInfoFontSizeProperty = BindableProperty.Create(
       nameof(DataInfoFontSize),
       typeof(int),
       typeof(DataFrame),
       1,
       BindingMode.TwoWay);

    public int DataInfoFontSize
    {
        get => (int)GetValue(DataInfoFontSizeProperty);
        set => SetValue(DataInfoFontSizeProperty, value);
    }
    public string DataInfo
    {
        get => (string)GetValue(DataInfoProperty);
        set => SetValue(DataInfoProperty, value);
    }
    public string DataTitle
    {
        get => (string)GetValue(DataTitleProperty);
        set => SetValue(DataTitleProperty, value);
    }

    public Color DataInfoColor
    {
        get => (Color)GetValue(DataInfoColorProperty);
        set => SetValue(DataInfoColorProperty, value);
    }
    public Color DataTitleColor
    {
        get => (Color)GetValue(DataTitleColorProperty);
        set => SetValue(DataTitleColorProperty, value);
    }
    public Color DataFrameBackgroundColor
    {
        get => (Color)GetValue(DataFrameBackgroundColorProperty);
        set => SetValue(DataFrameBackgroundColorProperty, value);
    }
}