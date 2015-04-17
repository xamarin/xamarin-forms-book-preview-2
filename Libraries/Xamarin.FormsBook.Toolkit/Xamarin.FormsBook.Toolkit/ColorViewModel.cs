using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Xamarin.FormsBook.Toolkit
{
    public class ColorViewModel : INotifyPropertyChanged
    {
        Color color;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Red
        {
            set 
            {
                if (color.R != value)
                    Color = Color.FromRgba(value, color.G, color.B, color.A);
            }
            get 
            {
                return color.R; 
            }
        }

        public double Green
        {
            set
            {
                if (color.G != value)
                    Color = Color.FromRgba(color.R, value, color.B, color.A);
            }
            get
            {
                return color.G;
            }
        }

        public double Blue
        {
            set
            {
                if (color.B != value)
                    Color = Color.FromRgba(color.R, color.G, value, color.A);
            }
            get
            {
                return color.B;
            }
        }

        public double Alpha
        {
            set
            {
                if (color.A != value)
                    Color = Color.FromRgba(color.R, color.G, color.B, value);
            }
            get
            {
                return color.A;
            }
        }

        public double Hue
        {
            set
            {
                if (color.Hue != value)
                    Color = Color.FromHsla(value, color.Saturation, color.Luminosity, color.A);
            }
            get
            {
                return color.Hue;
            }
        }

        public double Saturation
        {
            set
            {
                if (color.Saturation != value)
                    Color = Color.FromHsla(color.Hue, value, color.Luminosity, color.A);
            }
            get
            {
                return color.Saturation;
            }
        }

        public double Luminosity
        {
            set
            {
                if (color.Luminosity != value)
                    Color = Color.FromHsla(color.Hue, color.Saturation, value, color.A);
            }
            get
            {
                return color.Luminosity;
            }
        }

        public Color Color
        {
            set
            {
                Color oldColor = color;

                if (color != value)
                {
                    color = value;
                    OnPropertyChanged("Color");
                }

                if (color.R != oldColor.R)
                    OnPropertyChanged("Red");

                if (color.G != oldColor.G)
                    OnPropertyChanged("Red");

                if (color.B != oldColor.B)
                    OnPropertyChanged("Blue");

                if (color.A != oldColor.A)
                    OnPropertyChanged("Alpha");

                if (color.Hue != oldColor.Hue)
                    OnPropertyChanged("Hue");

                if (color.Saturation != oldColor.Saturation)
                    OnPropertyChanged("Saturation");

                if (color.Luminosity != oldColor.Luminosity)
                    OnPropertyChanged("Luminosity");
            }
            get
            {
                return color;
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
