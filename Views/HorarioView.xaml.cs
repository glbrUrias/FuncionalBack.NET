using System.Windows;
using Kalum2020v1.ModelsViews;
using MahApps.Metro.Controls;

namespace Kalum2020v1.Views
{
    public partial class HorarioView : MetroWindow
    {
        private HorarioViewModel model;
        public HorarioView()
        {
            InitializeComponent();
            model = new HorarioViewModel();
            this.DataContext=model;
        }
    }
}