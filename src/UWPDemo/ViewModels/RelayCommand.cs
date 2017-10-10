using System;
using System.Windows.Input;

public class RelayCommand : ICommand
{
    private readonly Action execute;
    private readonly Func<bool> canExecute;

    public event EventHandler CanExecuteChanged;

    public RelayCommand(Action execute)
        : this(execute, null)
    {
    }

    public RelayCommand(Action execute, Func<bool> canExecute)
    {
        if (execute == null)
        {
            throw new ArgumentNullException("execute");
        }

        this.execute = execute;
        this.canExecute = canExecute;
    }

    public bool CanExecute(object parameter)
    {
        return this.canExecute == null ? true : this.canExecute();
    }

    public void Execute(object parameter)
    {
        this.execute();
    }

    public void RaiseCanExecuteChanged()
    {
        var handler = CanExecuteChanged;
        if (handler != null)
        {
            handler(this, EventArgs.Empty);
        }
    }
}