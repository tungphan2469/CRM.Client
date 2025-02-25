namespace CRM.UI;

public static class AppColors
{
    public static readonly Color ThemeBlue = Color.FromArgb("#2F76E6");
    public static readonly Color IconButtonColor = Color.FromArgb("#989898");
    public static readonly Color TableBorderColor = Color.FromArgb("#04A2AA");
    public static readonly Color WhiteText = Color.FromArgb("#FFFFFF");
    public static readonly Color BlackText = Color.FromArgb("#000000");

    public static readonly Color Purple = Color.FromRgb(0x57, 0x5F, 0xCC);
    public static readonly Color Pink = Color.FromRgb(0xFF, 0x5C, 0x9E);
    public static readonly Color White = Color.FromArgb("#ffffff");
    public static readonly Color Black = Color.FromArgb("#333333");
    public static readonly Color Grey = Color.FromArgb("#989898");
    public static readonly Color Gray = Color.FromArgb("#808080");
    public static readonly Color Green = Color.FromArgb("#19BD56");
    public static readonly Color Red = Color.FromArgb("#DC362E");
    public static readonly Color Blue = Color.FromArgb("#110F72");
    public static readonly Color Yellow = Color.FromArgb("#F1B237");
    public static readonly Color LittleBlue = Color.FromArgb("#eff1fe");
    public static readonly Color LinkBlue = Color.FromArgb("#4951d4");
    public static readonly Color PlaceholderGrey = Color.FromArgb("#e6e6e6");
    public static readonly Color WhiteLight = Color.FromArgb("#f9fafb");
    public static readonly Color Gradient = Color.FromArgb("#2754C8");
    public static readonly Color Inactive = Color.FromArgb("#E0E0E0");
    public static readonly Color offbackground = Color.FromArgb("#FCFCFC");
    public static readonly Color primarytext = Color.FromArgb("#333333");
    public static readonly Color bgpopup = Color.FromArgb("#F2F2F2");
    public static readonly Color clstoke = Color.FromArgb("#DDDDDD");
    public static readonly Color LightGray = Color.FromArgb("#D3D3D3");
    public static readonly Brush DeepBlue = new LinearGradientBrush
    {
        StartPoint = new Point(0, 0),
        EndPoint = new Point(1, 1),
        GradientStops =
        [
            new GradientStop { Color = Color.FromArgb("#2754C8"), Offset = 0.0f },
            new GradientStop { Color = Color.FromArgb("#110F72"), Offset = 1.0f }
        ]
    };

    public static readonly Color BorderGrey = Color.FromArgb("#e6e6e6");
    public static readonly Color BackgroundWhite = Color.FromArgb("#FFFFFF");
    public static readonly Color PopBackground = Black.WithAlpha(0.25f);
    public static readonly Color PopOtherBackground = Color.FromArgb("#f0f5fa");
    public static readonly Color PopBorder = Color.FromArgb("#ededee").WithAlpha(0.5f);
    public static readonly Color bgmyaccount = Color.FromArgb("#F7F8FA");
    public static readonly Color clswitch = Color.FromArgb("#34C754");
    public static readonly Color clfailed = Color.FromArgb("#DC362E");
    public static readonly Color TextNote = Color.FromArgb("#808080");
    public static readonly Color TextBlue = Color.FromArgb("#2754C8");
    public static readonly Color EntryBackground = Color.FromArgb("#F6F6F6");
    public static readonly Color BorderColor = Color.FromArgb("#40FFFFFF");

    public static readonly Color Secondary1 = Color.FromRgb(0xFF, 0xF8, 0xF3);
    public static readonly Color LightBlue = Color.FromRgb(0x73, 0x9E, 0xF1);
    public static readonly Color LightYellow = Color.FromRgb(0xFA, 0xBF, 0x48);
    public static readonly Color BrColor = Color.FromRgb(0xF9, 0xFA, 0xFE);
    public static readonly Color Background = Color.FromRgb(0xE5, 0xE5, 0xE5);

    public static readonly Color Grey10 = Color.FromRgb(0xEB, 0xEC, 0xF4);
    public static readonly Color Grey20 = Color.FromRgb(0xDA, 0xDB, 0xE7);
    public static readonly Color Grey30 = Color.FromRgb(0xC7, 0xC7, 0xD7);
    public static readonly Color Grey40 = Color.FromRgb(0x93, 0x93, 0xAB);
    public static readonly Color Grey50 = Color.FromRgb(0x55, 0x56, 0x70);
    public static readonly Color Grey60 = Color.FromRgb(0x59, 0x59, 0x59);
}
