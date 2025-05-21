using Master.Entities;
using Master.Repository.Implementation;
using Master.Repository.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Master
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider
        {
            get; private set;
        }

        protected override void OnStartup(StartupEventArgs e)
        {


            var services = new ServiceCollection();
            ConfigureServices(services);

            ServiceProvider = services.BuildServiceProvider();

            base.OnStartup(e);
        }


        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IPartnerRepository, PartnerRepository>();
 




            services.AddDbContext<MasterPolBsvContext>();


        }
    }
}
