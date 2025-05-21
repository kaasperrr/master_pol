using Master.Repository.Interface;
using Master.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Master.Page
{
    /// <summary>
    /// Логика взаимодействия для PartnerPage.xaml
    /// </summary>
    public partial class PartnerPage : UserControl
    {
        private readonly IPartnerRepository _partnerRepository  = App.ServiceProvider.GetService<IPartnerRepository>();
        public PartnerPage()
        {
            InitializeComponent();
            DataContext = new PartnerViewModel(_partnerRepository);
        }
    }
}
