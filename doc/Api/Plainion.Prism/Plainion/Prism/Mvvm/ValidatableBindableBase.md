
# Plainion.Prism.Mvvm.ValidatableBindableBase

**Namespace:** Plainion.Prism.Mvvm

**Assembly:** Plainion.Prism


## Constructors

### Constructor()


## Properties

### System.Boolean HasErrors

### Prism.Mvvm.ErrorsContainer`1[[Plainion.Prism.Mvvm.ValidationFailure, Plainion.Prism, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null]] ErrorsContainer


## Events

### System.EventHandler`1[[System.ComponentModel.DataErrorsChangedEventArgs, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]] ErrorsChanged


## Methods

### System.Collections.IEnumerable GetErrors(System.String propertyName)

### void OnErrorsChanged(System.ComponentModel.DataErrorsChangedEventArgs e)

### void SetErrors(System.Collections.Generic.IEnumerable`1[Plainion.Prism.Mvvm.ValidationFailure] errors,System.String propertyName)

### void SetError(Plainion.Prism.Mvvm.ValidationFailure error,System.String propertyName)

### void ClearErrors(System.String propertyName)
