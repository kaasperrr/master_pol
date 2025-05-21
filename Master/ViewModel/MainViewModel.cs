using CommunityToolkit.Mvvm.Input;
using Master.Page;
using Master.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Master.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private object _currentPage;

        public object CurrentPage
        {
            get=> _currentPage;
            set => SetProperty(ref _currentPage, value);
        }

        public ICommand ShowHistoryPageCommand { get; }
        public ICommand ShowPartnerPageCommand { get; }
        public ICommand ShowAddPageCommand { get; }

        public MainViewModel() {
            ShowAddPageCommand = new RelayCommand(ShowAddPage);
            ShowPartnerPageCommand = new RelayCommand(ShowPartnerPage);
            ShowHistoryPageCommand = new RelayCommand(ShowHistoryPage);
            ShowPartnerPage();
        }

        private void ShowAddPage() {
            CurrentPage = new AddPage();
        }

        private void ShowPartnerPage()
        {
            CurrentPage = new PartnerPage();
        }

        private void ShowHistoryPage()
        {
            CurrentPage = new HistoryPage();
        }

    }
}
