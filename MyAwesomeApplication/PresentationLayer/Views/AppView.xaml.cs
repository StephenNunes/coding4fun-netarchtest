using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MyAwesomeApplication.PresentationLayer.Views
{
    /// <summary>
    /// Interaction logic for AppView.xaml
    /// </summary>
    public partial class AppView : Application
    {
        public static void Main() 
        {
            AppView app = new AppView();
            app.InitializeComponent();
            app.Run();
        }
    }
}
