using CommunityToolkit.Mvvm.ComponentModel;

namespace CRM.Utilities.MVVM;

public abstract class BaseFormModel : ObservableValidator
{
    protected virtual string[] ValidatableAndSupportPropertyNames => [];

    public virtual bool IsValid()
    {
        ValidateAllProperties();

        foreach (var propertyName in ValidatableAndSupportPropertyNames) OnPropertyChanged(propertyName);

        return !HasErrors;
    }
}