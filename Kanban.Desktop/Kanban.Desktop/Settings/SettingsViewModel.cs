using ReactiveUI.Fody.Helpers;
using Ui.Wpf.Common;
using Ui.Wpf.Common.ViewModels;

namespace Kanban.Desktop.Settings
{
    public class SettingsViewModel : ViewModelBase, ISettingsViewModel
    {
        public void Initialize(ViewRequest viewRequest)
        {
        }
        
        public bool UseDynamicDimensionts { get; set; }
    }
}