using System.Windows;
using Kalum2020v1.ModelsViews;
using MahApps.Metro.Controls;

namespace Kalum2020v1.Views
{
    public partial class CarreraTecnicaView : MetroWindow
    {
        private CarreraTecnicaViewModel model;
        public CarreraTecnicaView()
        {
            InitializeComponent();
            model = new CarreraTecnicaViewModel();
            this.DataContext=model;
        }
    }
}