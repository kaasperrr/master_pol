using CommunityToolkit.Mvvm.Input;
using Master.Entities;
using Master.Repository.Interface;
using Master.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Master.ViewModel
{
    public class PartnerViewModel : BaseViewModel
    {
        private int _idPartner;
        private string _name = null!;
        private int _idPartnerType;
        private int? _rating;
        private string? _address;
        private string? _directorFirstName;
        private string? _directorMiddleName;
        private string? _directorLastName;
        private string? _phone;
        private string? _email;
        private Partner _selectedPartner;
        private ObservableCollection<Partner> _partnerList;
        private Visibility _isPartnerUpdateVisible;

        public int IdPartner
        {
            get => _idPartner;
            set => SetProperty(ref _idPartner, value);
        }

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public int IdPartnerType
        {
            get => _idPartnerType;
            set => SetProperty(ref _idPartnerType, value);
        }

        public int? Rating
        {
            get => _rating;
            set => SetProperty(ref _rating, value);
        }

        public string? Address
        {
            get => _address;
            set => SetProperty(ref _address, value);
        }

        public string? DirectorFirstName
        {
            get => _directorFirstName;
            set => SetProperty(ref _directorFirstName, value);
        }

        public string? DirectorMiddleName
        {
            get => _directorMiddleName;
            set => SetProperty(ref _directorMiddleName, value);
        }

        public string? DirectorLastName
        {
            get => _directorLastName;
            set => SetProperty(ref _directorLastName, value);
        }

        public string? Phone
        {
            get => _phone;
            set => SetProperty(ref _phone, value);
        }

        public string? Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        public Partner SelectedPartner
        {
            get => _selectedPartner;
            set {
                SetProperty(ref _selectedPartner, value);
                    IsPartnerUpdateVisible = Visibility.Visible;
                    
                    }
        }

        private Visibility IsPartnerUpdateVisible {
            get => _isPartnerUpdateVisible;
            set => SetProperty(ref _isPartnerUpdateVisible, value);


        }



        public ObservableCollection<Partner> PartnerList
        {
            get => _partnerList;
            set=> SetProperty(ref _partnerList, value);
        }


        private readonly IPartnerRepository _partnerRepository;

        public ICommand UpdatePartnerCommand { get; }

        public PartnerViewModel(IPartnerRepository partnerRepository)
        {
            _partnerRepository = partnerRepository;
            IsPartnerUpdateVisible = Visibility.Collapsed;
            UpdatePartnerCommand = new AsyncRelayCommand<object>(UpdatePartner);
            LoadPartner();
            
        }

        public async Task LoadPartner()
        {
            var partners = await _partnerRepository.GetListPartnerAsync();
            PartnerList = new ObservableCollection<Partner>(partners);
        }

        private async Task UpdatePartner(object param)
        {
            
            try
            {
                if (param is Partner partner)
                {
                    await _partnerRepository.UpdatePartnerAsnc(partner);
                    LoadPartner();
                }
                MessageBox.Show("Запись успешно обновлена!");
            }
            catch { 
            }
        }


    }
}
