using MugenMvvmToolkit.ViewModels;

namespace Core.ViewModels
{
    public class MainViewModel : MultiViewModel
    {
        #region Overrides of ViewModelBase

        protected override void OnInitialized()
        {
            base.OnInitialized();
            for (var i = 0; i < 5; i++)
            {
                var vm = GetViewModel<ChildViewModel>();
                vm.Init(i + 1);
                AddViewModel(vm, false);
            }

            // set selected vm
            SelectedItem = ItemsSource[0];
        }

        #endregion
    }
}