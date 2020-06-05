using System.Windows;
using Kalum2020v1.ModelsViews;
using MahApps.Metro.Controls;

namespace Kalum2020v1.Views
{
    public partial class InstructorView : MetroWindow
    {
        private InstructorViewModel model;
        public InstructorView()
        {
            InitializeComponent();
            model = new InstructorViewModel();
            this.DataContext=model;
        }
    }
}