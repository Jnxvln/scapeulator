using System.Windows.Input;

namespace Scapeulator.MVVM.Commands;

public class RelayCommand : ICommand
{
    
    public Action<object> _Execute { get; set; }
    public Predicate<object> _CanExecute { get; set; }

    public event EventHandler? CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }
    
    public RelayCommand(Action<object> execute, Predicate<object> canExecute)
    {
        _Execute = execute;
        _CanExecute = canExecute;
    }
    
    public bool CanExecute(object? parameter)
    {
        return _CanExecute == null || _CanExecute(parameter);
    }

    public void Execute(object? parameter)
    {
        _Execute(parameter);
    }
}