using CommunityToolkit.Mvvm.Input;
using Master.Entities;
using Master.Repository.Interface;
using Master.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace Master.ViewModel
{
    public class AddViewModel : BaseViewModel
    {

        private string _name;
        private int _idPartnerType;
        private int? _rating;
        private string? _address;
        private string? _directorFirstName;
        private string? _directorMiddleName;
        private string? _directorLastName;
        private string? _phone;
        private string? _email;




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

       

        private readonly IPartnerRepository _partnerRepository;

        public ICommand AddPartnerCommand { get; }

        public AddViewModel(IPartnerRepository partnerRepository)
        {
            _partnerRepository = partnerRepository;
            AddPartnerCommand = new AsyncRelayCommand(AddPartner);

        }

      

        private async Task AddPartner()
        {
            try
            {
                var partner = new Partner
                {
                    Name = Name,
                    IdPartnerType = IdPartnerType,
                    Rating = Rating,
                    Address = Address,
                    DirectorFirstName = DirectorFirstName,
                    DirectorMiddleName = DirectorMiddleName,
                    DirectorLastName = DirectorLastName,
                    Phone = Phone,
                    Email = Email
                };
                await _partnerRepository.AddToDataBaseAsync(partner);
                MessageBox.Show("Партнер успешно добавлен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
