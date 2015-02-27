using System;
using Xamarin.Forms;

namespace Xamarin.FormsBook.Toolkit
{
    public class AltLabelGeneric : Label
    {
        public static readonly BindableProperty PointSizeProperty =
            BindableProperty.Create<AltLabelGeneric, double>
                (label => label.PointSize, 
                8, 
                propertyChanged: (bindable, oldValue, newValue) =>
                    {
                        ((AltLabelGeneric)bindable).SetLabelFontSize(newValue);
                    });

        public AltLabelGeneric()
        {
            SetLabelFontSize((double)PointSizeProperty.DefaultValue);
        }

        public double PointSize
        {
            set { SetValue(PointSizeProperty, value); }
            get { return (double)GetValue(PointSizeProperty); }
        }

        void SetLabelFontSize(double pointSize)
        {
            FontSize = Device.OnPlatform(160, 160, 240) * pointSize / 72;
        }
    }
}
