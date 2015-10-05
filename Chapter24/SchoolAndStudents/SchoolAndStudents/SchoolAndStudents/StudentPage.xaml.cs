using System;
using Xamarin.Forms;
using ElPasoHighSchool;

namespace SchoolAndStudents
{
    public partial class StudentPage : ContentPage
    {
        public StudentPage(Student student)
        {
            InitializeComponent();
            BindingContext = student;
        }
    }
}
