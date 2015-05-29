using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace StudentList
{
    public partial class StudentListPage : ContentPage
    {
        public StudentListPage()
        {
            // Ensure link to library.
            new ElPasoHighSchool.SchoolViewModel();

            InitializeComponent();
        }
    }
}
