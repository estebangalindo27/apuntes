using apuntes.Models;
using CommunityToolkit.Mvvm.Input;

namespace apuntes.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}