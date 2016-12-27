using MugenMvvmToolkit.ViewModels;

namespace Core.ViewModels
{
    public class ChildViewModel : ViewModelBase
    {
        public int Number { get; private set; }

        public void Init(int number)
        {
            Number = number;
        }
    }

}