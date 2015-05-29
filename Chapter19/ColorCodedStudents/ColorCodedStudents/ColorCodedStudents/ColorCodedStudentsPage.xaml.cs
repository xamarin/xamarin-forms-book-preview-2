using System;
using Xamarin.Forms;

namespace ColorCodedStudents
{
    public partial class ColorCodedStudentsPage : ContentPage
    {
        public ColorCodedStudentsPage()
        {
            // Ensure links to libraries.
            new ElPasoHighSchool.SchoolViewModel();
            new Xamarin.FormsBook.Toolkit.ThresholdToObjectConverter<Color>();

            InitializeComponent();
        }
    }
}
