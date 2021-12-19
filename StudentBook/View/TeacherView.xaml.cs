using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using System.Windows.Controls;
using System.Windows.Input;

namespace StudentBook.View
{
    public partial class TeacherView : UserControl
    {
        public TeacherView()
        {
            InitializeComponent();
        }

        public ICommand ChangeToInitialViewCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    Messenger.Default.Send<SwitchViewMessage>(new SwitchViewMessage { ViewName = "InitialView" });
                });
            }
        }
    }
}
