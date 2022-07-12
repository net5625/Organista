using Organista.ViewModels;
using System;
using System.Windows.Input;

namespace Organista.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private readonly MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if(parameter is null || parameter.ToString() == "Time")
            {
                viewModel.SelectedViewModel = new WorkTimeViewModel();
            }
            else if(parameter.ToString() == "Set")
            {
                viewModel.SelectedViewModel = new AddSetViewModel();
            }
            else if(parameter.ToString() == "See")
            {
                viewModel.SelectedViewModel = new EnteredSetsViewModel();
            }
            else if(parameter.ToString() == "Save")
            {
                viewModel.SelectedViewModel = new SaveWorkViewModel();
            }
            else if(parameter.ToString() == "Setting")
            {
                viewModel.SelectedViewModel = new SettingsViewModel();
            }
            else if(parameter.ToString() == "Exit")
            {
                Environment.Exit(0);
            }
            else
            {
                viewModel.SelectedViewModel = new WorkTimeViewModel();
            }
        }
    }
}
