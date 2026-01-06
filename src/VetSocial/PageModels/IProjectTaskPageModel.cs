using CommunityToolkit.Mvvm.Input;
using VetSocial.Models;

namespace VetSocial.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}