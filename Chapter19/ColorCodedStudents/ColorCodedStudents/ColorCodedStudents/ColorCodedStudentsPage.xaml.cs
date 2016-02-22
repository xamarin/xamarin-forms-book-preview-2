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

            InitializeComponent();
        }
    }
}
