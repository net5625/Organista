using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Organista.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Organista
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddDbContext<ModelContext>
            (options => options.UseSQLite("Data Source=rejestr.db;"));

            services.AddTransient(typeof(MainWindow));
        }
    }
}
