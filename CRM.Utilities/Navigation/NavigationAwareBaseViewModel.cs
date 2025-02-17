﻿using System.Diagnostics;
using CRM.Utilities.MVVM;

namespace CRM.Utilities.Navigation;

public abstract class NavigationAwareBaseViewModel(IAppNavigator appNavigator)
    : BaseViewModel(appNavigator), IQueryAttributable
{
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.IsGoingBack())
        {
            Debug.WriteLine($"{GetType().Name}.{nameof(OnBack)}");
            OnBack(query);
        }
        else
        {
            Debug.WriteLine($"{GetType().Name}.{nameof(OnInit)}");
            OnInit(query);
        }
    }

    // ReSharper disable once UnusedParameter.Global
    protected virtual void OnBack(IDictionary<string, object> query)
    {
    }

    // ReSharper disable once UnusedParameter.Global
    protected virtual void OnInit(IDictionary<string, object> query)
    {
    }
}

public interface IOnBackAwareViewModel
{
    // ReSharper disable once UnusedMemberInSuper.Global
    // ReSharper disable once UnusedMethodReturnValue.Global
    // ReSharper disable once UnusedParameter.Global
    Task OnBackAsync(IDictionary<string, object> query);
}

public interface IOnInitAwareViewModel<in T>
{
    // ReSharper disable once UnusedMemberInSuper.Global
    // ReSharper disable once UnusedMethodReturnValue.Global
    // ReSharper disable once UnusedParameter.Global
    Task OnInitAsync(T args);
}

// ReSharper disable once UnusedType.Global
// ReSharper disable once UnusedType.Global
public abstract class NavigationAwareViewModel<TInit>(IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator), IOnInitAwareViewModel<TInit>, IOnBackAwareViewModel
{
    // ReSharper disable once UnusedParameter.Global
    // ReSharper disable once UnusedMethodReturnValue.Global
    public virtual Task OnBackAsync(IDictionary<string, object> query)
    {
        return Task.CompletedTask;
    }

    // ReSharper disable once UnusedParameter.Global
    // ReSharper disable once UnusedMethodReturnValue.Global
    public virtual Task OnInitAsync(TInit args)
    {
        return Task.CompletedTask;
    }

    protected override void OnInit(IDictionary<string, object> query)
    {
        var data = query.GetData<TInit>();
        if (data != null) OnInitAsync(data);
    }

    protected override void OnBack(IDictionary<string, object> query)
    {
        OnBackAsync(query);
    }
}

// ReSharper disable once UnusedType.Global
public abstract class OnBackAwareViewModel(IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator), IOnBackAwareViewModel
{
    // ReSharper disable once UnusedParameter.Global
    // ReSharper disable once UnusedMethodReturnValue.Global
    public virtual Task OnBackAsync(IDictionary<string, object> query)
    {
        return Task.CompletedTask;
    }

    protected override void OnBack(IDictionary<string, object> query)
    {
        OnBackAsync(query);
    }
}

// ReSharper disable once UnusedType.Global
public abstract class OnInitAwareViewModel<TInit>(IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator), IOnInitAwareViewModel<TInit>
{
    // ReSharper disable once UnusedParameter.Global
    // ReSharper disable once UnusedMethodReturnValue.Global
    public virtual Task OnInitAsync(TInit args)
    {
        return Task.CompletedTask;
    }

    protected override void OnInit(IDictionary<string, object> query)
    {
        var data = query.GetData<TInit>();
        if (data != null) OnInitAsync(data);
    }
}