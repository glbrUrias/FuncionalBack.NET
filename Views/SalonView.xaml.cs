using System.Windows;
using Kalum2020v1.ModelsViews;
using MahApps.Metro.Controls;

namespace Kalum2020v1.Views
{
    public partial class SalonView : MetroWindow
    {
        private SalonViewModel model;
        public SalonView()
        {
            InitializeComponent();
            model = new SalonViewModel();
            this.DataContext=model;
        }
    }
}