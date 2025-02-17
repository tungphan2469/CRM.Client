﻿using System.Diagnostics.CodeAnalysis;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CRM.UI;
using Font = Microsoft.Maui.Font;

namespace CRM.Utilities.Navigation;

[ExcludeFromCodeCoverage]
public class AppNavigator(IServiceProvider serviceProvider) : IAppNavigator
{
    private readonly IServiceProvider serviceProvider = serviceProvider;

    public Task GoBackAsync(bool animated = false, object? data = null)
    {
        return NavigateAsync(UriHelper.GoBackSegment, animated, data);
    }

    public Task NavigateAsync(string target, bool animated = false, object? args = null)
    {
        var navArgs = new Dictionary<string, object>()
        {
            { "source", Shell.Current.CurrentState.Location.OriginalString },
            { nameof(target), target },
            { nameof(animated), animated }
        };

        if (args is not null)
        {
            navArgs.Add(UriHelper.DataQueryParameterName, args);
        }

        if (target == UriHelper.GoBackSegment)
        {
            navArgs.Add(UriHelper.GoBackQueryParameterName, true);
        }

        return MainThread.InvokeOnMainThreadAsync(() => Shell.Current.GoToAsync(
            target,
            animated,
            navArgs
        ).ContinueWith(x =>
        {

        }));
    }



    public Task<bool> OpenUrlAsync(string url)
    {
        return Launcher.OpenAsync(url);
    }

    public Task ShareAsync(string text, string? title = null)
    {
        var request = new ShareTextRequest(text, title!);
        return Share.Default.RequestAsync(request);
    }

    public Task ShowSnackbarAsync(string message, Action? action = null, string? actionText = null)
    {
        var options = new SnackbarOptions
        {
            BackgroundColor = AppColors.Purple,
            TextColor = AppColors.White,
            ActionButtonTextColor = AppColors.Pink,
            CornerRadius = new CornerRadius(Dimens.ButtonCornerRadius),
            Font = Font.OfSize(FontNames.InterRegular, Dimens.FontSizeT6),
            ActionButtonFont = Font.OfSize(FontNames.InterBold, Dimens.FontSizeT6),
            CharacterSpacing = 0.5
        };
        var snackbar = Snackbar.Make(message, action, actionText ?? "OK", TimeSpan.FromSeconds(5), options);
        return snackbar.Show();
    }
}
