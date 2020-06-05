using System.Windows;
using Kalum2020v1.ModelsViews;
using MahApps.Metro.Controls;

namespace Kalum2020v1.Views
{
    public partial class ReligionView : MetroWindow
    {
        private ReligionViewModel model;
        public ReligionView()
        {
            InitializeComponent();
            model = new ReligionViewModel();
            this.DataContext=model;
        }
    }
}