using CRM.UI;
using CRM.UI.Component;
using Microsoft.Maui.Controls.Shapes;
using Telerik.Maui.Controls;
using Telerik.Maui.Controls.DataGrid;

namespace CRM.UI;

//Border: Border
//Label: Label
//Width,Height: VisualElement
//Button: Button

public partial class Styles
{
    public readonly static Shadow Shadow1 = new Shadow()
    {
        Offset = new Point(0, 4),
        Brush = new SolidColorBrush(AppColors.Purple),
        Opacity = 0.1f
    };
    public readonly static Shadow Shadow2 = new Shadow()
    {
        Offset = new Point(0, 4),
        Brush = new SolidColorBrush(AppColors.Purple),
        Opacity = 0.1f
    };

    public static readonly Style BorderMd = CreateStyle<Border>()
        .Set(Border.StrokeProperty, AppColors.Green)
        .Set(Border.StrokeThicknessProperty, 1)
        .Set(Border.StrokeShapeProperty, new RoundRectangle
        {
            CornerRadius = new CornerRadius(16)
        });

    public static readonly Style LabelGradent = CreateStyle<Label>()
       .Set(Label.TextColorProperty, AppColors.Gradient)
       .Set(Label.FontFamilyProperty, FontNames.InterRegular);

    static readonly Style ButtonBase = CreateStyle<Button>()
        .Set(VisualElement.BackgroundColorProperty, AppColors.Purple)
        .Set(Button.TextColorProperty, AppColors.Secondary1)
        .Set(VisualElement.MaximumHeightRequestProperty, Dimens.ButtonHeight)
        .Set(VisualElement.MaximumWidthRequestProperty, Dimens.ButtonWidth)
        .Set(Button.CornerRadiusProperty, Dimens.ButtonCornerRadius)
        .Set(Button.FontSizeProperty, Dimens.FontSizeT5)
        .Set(Button.FontFamilyProperty, FontNames.ArchiaSemiBold);

    public static readonly Style ButtonPrimary = CreateStyle<Button>()
        .BaseOn(ButtonBase)
        .Set(VisualElement.BackgroundColorProperty, AppColors.Purple)
        .Set(Button.TextColorProperty, AppColors.Secondary1)
        .Set(VisualElement.MinimumHeightRequestProperty, Dimens.ButtonHeight)
        .Set(VisualElement.HeightRequestProperty, Dimens.ButtonHeight)
        .Set(VisualElement.WidthRequestProperty, Dimens.ButtonWidth);

    public static readonly Style ButtonSecondary = CreateStyle<Button>()
        .BaseOn(ButtonPrimary)
        .Set(VisualElement.BackgroundColorProperty, AppColors.Grey20)
        .Set(Button.TextColorProperty, AppColors.Grey50);

    public static readonly Style ButtonFlat = CreateStyle<Button>()
        .BaseOn(ButtonPrimary)
        .Set(VisualElement.BackgroundColorProperty, Colors.Transparent)
        .Set(Button.TextColorProperty, AppColors.Grey50)
        ;

    public static readonly Style ButtonAccent = CreateStyle<Button>()
        .BaseOn(ButtonPrimary)
        .Set(VisualElement.BackgroundColorProperty, AppColors.Pink);

    public static readonly Style ButtonPrimarySm = CreateStyle<Button>()
        .BaseOn(ButtonBase)
        .Set(VisualElement.HeightRequestProperty, Dimens.ButtonHeightSm)
        .Set(VisualElement.MaximumHeightRequestProperty, Dimens.ButtonHeightSm)
        .Set(VisualElement.MinimumHeightRequestProperty, Dimens.ButtonHeightSm)
        .Set(VisualElement.MaximumWidthRequestProperty, Dimens.ButtonWidth)
        .Set(Button.TextColorProperty, AppColors.White)
        ;
    public static readonly Style ButtonSecondarySm = CreateStyle<Button>()
        .BaseOn(ButtonPrimarySm)
        .Set(VisualElement.BackgroundColorProperty, AppColors.Grey20)
        .Set(Button.TextColorProperty, AppColors.Grey50);

    public static readonly Style ButtonFlatSm = CreateStyle<Button>()
        .BaseOn(ButtonPrimarySm)
        .Set(VisualElement.BackgroundColorProperty, Colors.Transparent)
        .Set(Button.TextColorProperty, AppColors.Grey50)
        ;
    public static readonly Style ButtonAccentSm = CreateStyle<Button>()
        .BaseOn(ButtonPrimarySm)
        .Set(VisualElement.BackgroundColorProperty, AppColors.Pink)
        ;

    public static readonly Style ButtonPrimaryXs = CreateStyle<Button>()
        .BaseOn(ButtonBase)
        .Set(VisualElement.HeightRequestProperty, Dimens.ButtonHeightXs)
        .Set(VisualElement.MaximumHeightRequestProperty, Dimens.ButtonHeightXs)
        .Set(VisualElement.MinimumHeightRequestProperty, Dimens.ButtonHeightXs)
        .Set(VisualElement.MaximumWidthRequestProperty, Dimens.ButtonWidth)
        .Set(Button.CornerRadiusProperty, Dimens.ButtonCornerRadiusXs)
        .Set(Button.FontSizeProperty, Dimens.FontSizeT6)
        .Set(Button.TextColorProperty, AppColors.Grey50)
        ;
    public static readonly Style ButtonFlatXs = CreateStyle<Button>()
        .BaseOn(ButtonPrimaryXs)
        .Set(VisualElement.BackgroundColorProperty, Colors.Transparent)
        .Set(Button.TextColorProperty, AppColors.Grey50)
        ;
    public static readonly Style ButtonAccentXs = CreateStyle<Button>()
        .BaseOn(ButtonPrimaryXs)
        .Set(VisualElement.BackgroundColorProperty, AppColors.Pink)
        ;
    public static readonly Style ButtonOutlinedXs = CreateStyle<Button>()
        .BaseOn(ButtonPrimaryXs)
        .Set(Button.FontSizeProperty, Dimens.FontSizeT6)
        .Set(Button.TextColorProperty, AppColors.Pink)
        .Set(Button.BorderColorProperty, AppColors.Pink)
        .Set(Button.BorderWidthProperty, 1)
        .Set(Button.BackgroundColorProperty, Colors.Transparent)
        ;

}

public partial class Styles
{
    //Visual State example
    public static Style ProgressBarStyle => new Style(typeof(ProgressBar))
    {
        Setters =
        {
            new Setter
            {
                Property = ProgressBar.ProgressColorProperty,
                Value = Application.Current?.RequestedTheme == AppTheme.Dark ? AppColors.White : AppColors.ThemeBlue
            },
            new Setter{ Property = VisualStateManager.VisualStateGroupsProperty,
                Value = new VisualStateGroupList
                {
                    new VisualStateGroup
                    {
                        Name = "CommonStates",
                        States =
                        {
                            new VisualState
                            {
                                Name = "Normal"
                            },
                            new VisualState
                            {
                                Name = "Disabled",
                                Setters =
                                {
                                    new Setter{
                                        Property = ProgressBar.ProgressColorProperty,
                                        Value = Application.Current?.RequestedTheme == AppTheme.Dark ? AppColors.BorderGrey : AppColors.LightGray
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    };

    /// <summary>
    /// Style for Popup Entry
    /// </summary>
    public static Style PopupEntryStyle => new(typeof(RadEntry))
    {
        Setters =
        {
        new Setter { Property = RadEntry.FontSizeProperty, Value = 14 },
        new Setter { Property = RadEntry.CornerRadiusProperty, Value = 0 },
        new Setter { Property = RadEntry.BackgroundColorProperty, Value = Color.FromArgb("#EBECEF") },
        new Setter { Property = RadEntry.ClearButtonVisibilityProperty, Value = ClearButtonVisibility.WhileEditing },
        new Setter { Property = RadEntry.PlaceholderColorProperty, Value = Color.FromArgb("#99000000") },
        new Setter { Property = RadEntry.BorderBrushProperty, Value = Colors.Transparent }
        }
    };

    /// <summary>
    /// Style for Popup Entry Label
    /// </summary>
    public static Style PopupEntryLabelStyle => new(typeof(Label))
    {
        Setters =
        {
            new Setter { Property = Label.PaddingProperty, Value = 12 },
            new Setter { Property = Label.TextColorProperty, Value = Colors.Black },
            new Setter { Property = Label.FontFamilyProperty, Value = "RobotoSB" },
            new Setter { Property = Label.LineBreakModeProperty, Value = LineBreakMode.WordWrap }
        }
    };

    /// <summary>
    /// Style for Popup Border Button
    /// </summary>
    public static Style PopupBorderButtonStyle => new(typeof(Border))
    {
        Setters =
        {
            new Setter { Property = Border.StrokeThicknessProperty, Value = 0 },
            new Setter { Property = VisualElement.BackgroundColorProperty, Value = Color.FromArgb("#EBECEF") },
            new Setter { Property = Border.StrokeProperty, Value = Colors.Transparent },
            new Setter { Property = Border.HorizontalOptionsProperty, Value = LayoutOptions.Center },
            new Setter { Property = VisualElement.HeightRequestProperty, Value = 34 },
            new Setter { Property = VisualElement.WidthRequestProperty, Value = 168 }
        }
    };

    /// <summary>
    /// Style for Popup Border Button Label
    /// </summary>
    public static Style PopupBorderButtonLabelStyle => new(typeof(Label))
    {
        Setters =
        {
            new Setter { Property = Label.TextProperty, Value = "Share" },
            new Setter { Property = Label.TextColorProperty, Value = Color.FromArgb("#45536C") },
            new Setter { Property = Label.FontSizeProperty, Value = 12 },
            new Setter { Property = Label.FontFamilyProperty, Value = "RobotoSB" },
            new Setter { Property = Label.MarginProperty, Value = new Thickness(10, 0, 0, 0) },
            new Setter { Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.Start },
            new Setter { Property = Label.VerticalOptionsProperty, Value = LayoutOptions.Center },
            new Setter { Property = Label.LineBreakModeProperty, Value = LineBreakMode.WordWrap }
        }
    };

    /// <summary>
    /// Style for Home table header
    /// </summary>
    public static Style HomeTableColumnHeaderStyle => new(typeof(DataGridColumnHeaderAppearance))
    {
        Setters =
        {
            new Setter { Property = DataGridColumnHeaderAppearance.TextHorizontalOptionsProperty, Value = LayoutOptions.Center },
            new Setter { Property = DataGridColumnHeaderAppearance.SortIndicatorHorizontalOptionsProperty, Value = LayoutOptions.Center },
            new Setter { Property = DataGridColumnHeaderAppearance.BorderColorProperty, Value = Colors.Transparent }
        }
    };

    /// <summary>
    /// Style for Home table cell
    /// </summary>
    public static Style HomeTableCellStyle => new(typeof(DataGridTextCellAppearance))
    {
        Setters =
        {
            new Setter { Property = DataGridTextCellAppearance.HorizontalTextAlignmentProperty, Value = TextAlignment.Center }
        }
    };

    /// <summary>
    /// Home title text style
    /// </summary>
    public static Style HomeTitleLabelStyle => new(typeof(Label))
    {
        Setters =
        {
            new Setter { Property = Label.TextColorProperty, Value = Colors.Black },
            new Setter { Property = Label.FontSizeProperty, Value = 16 },
            new Setter { Property = Label.FontAttributesProperty, Value = FontAttributes.Bold },
            new Setter { Property = Label.FontFamilyProperty, Value = "RobotoREG" },
            new Setter { Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.Start },
            new Setter { Property = Label.MarginProperty, Value = new Thickness(14, 0, 0, 0) }
        }
    };

    /// <summary>
    /// Home table style
    /// </summary>
    public static Style HomeTableStyle => new(typeof(RadDataGrid))
    {
        Setters =
        {
            new Setter { Property = RadDataGrid.BorderBrushProperty, Value = Colors.Transparent },
            new Setter { Property = RadDataGrid.AutoGenerateColumnsProperty, Value = false },
            new Setter { Property = RadDataGrid.UserFilterModeProperty, Value = DataGridUserFilterMode.Disabled },
            new Setter { Property = RadDataGrid.UserEditModeProperty, Value = DataGridUserEditMode.None },
            new Setter { Property = RadDataGrid.UserGroupModeProperty, Value = DataGridUserGroupMode.Disabled },
            new Setter { Property = RadDataGrid.UserSortModeProperty, Value = DataGridUserSortMode.None },
            new Setter { Property = RadDataGrid.SelectionModeProperty, Value = DataGridSelectionMode.None },
            new Setter { Property = RadDataGrid.GridLinesVisibilityProperty, Value = GridLinesVisibility.Horizontal },
            new Setter { Property = RadDataGrid.GridLinesThicknessProperty, Value = 1.4 }
        }
    };

    /// <summary>
    /// "See all" label style
    /// </summary>
    public static Style LabelSeeAllStyle => new(typeof(Label))
    {
        Setters =
        {
            new Setter { Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.End },
            new Setter { Property = Label.VerticalOptionsProperty, Value = LayoutOptions.End },
            new Setter { Property = Label.TextColorProperty, Value = Color.FromArgb("#A2A2A2") },
            new Setter { Property = Label.FontSizeProperty, Value = 12 },
            new Setter { Property = Label.FontFamilyProperty, Value = "RobotoREG" },
            new Setter { Property = Label.MarginProperty, Value = new Thickness(14, 0, 0, 0) }
        }
    };

    /// <summary>
    /// Home Alt Data frame style
    /// </summary>
    public static Style HomeAltDataFrameStyle => new(typeof(DataFrame))
    {
        Setters =
        {
            new Setter { Property = DataFrame.PaddingProperty, Value = new Thickness(8) },
            new Setter { Property = DataFrame.HeightRequestProperty, Value = 108 },
            new Setter { Property = DataFrame.DataFrameBackgroundColorProperty, Value = AppColors.ThemeBlue },
            new Setter { Property = DataFrame.DataInfoFontSizeProperty, Value = 32 },
            new Setter { Property = DataFrame.DataInfoColorProperty, Value = Color.FromArgb("#FFFFFF")  },
            new Setter { Property = DataFrame.DataTitleColorProperty, Value = Color.FromArgb("#FFFFFF")  },
        }
    };

    //DataInfoFontSize="32"
    //DataFrameBackgroundColor="White"
    //DataInfoColor="{x:Static ui:AppColors.ThemeBlue}"
    //DataTitleColor="Black"
    //Padding="8"
    //HeightRequest="108"
    public static Style HomeDataFrameStyle => new(typeof(DataFrame))
    {
        Setters =
        {
            new Setter { Property = DataFrame.PaddingProperty, Value = new Thickness(8) },
            new Setter { Property = DataFrame.HeightRequestProperty, Value = 108 },
            new Setter { Property = DataFrame.DataFrameBackgroundColorProperty, Value = Color.FromArgb("#FFFFFF") },
            new Setter { Property = DataFrame.DataInfoFontSizeProperty, Value = 32 },
            new Setter { Property = DataFrame.DataInfoColorProperty, Value = AppColors.ThemeBlue  },
            new Setter { Property = DataFrame.DataTitleColorProperty, Value = Color.FromArgb("#000000")  },
        }
    };
}


public static partial class Styles
{
    public static Style CreateStyle<T>()
    {
        return new Style(typeof(T));
    }

    public static Style BaseOn(this Style style, Style basedOn)
    {
        style.BasedOn = basedOn;
        return style;
    }

    public static Style Set(this Style style, BindableProperty property, object value)
    {
        style.Setters.Add(new Setter
        {
            Property = property,
            Value = value
        });
        return style;
    }

    public static Style BindTrigger(this Style style, Binding binding, object value, params (BindableProperty p, object value)[] setters)
    {
        var dataTrigger = new DataTrigger(style.TargetType)
        {
            Binding = binding,
            Value = value
        };

        for (int i = 0; i < setters.Length; i++)
        {
            dataTrigger.Setters.Add(new Setter
            {
                Property = setters[i].p,
                Value = setters[i].value
            });
        }

        style.Triggers.Add(dataTrigger);

        return style;
    }
}
