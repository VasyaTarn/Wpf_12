using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Wpf_12
{
    internal class ColorVM : INotifyPropertyChanged
    {
        private ColorModel model;
        private Color color;
        public ColorVM()
        {
            model = new ColorModel { Alpha = 50, Red = 50, Green = 50, Blue = 50 };
        }

        public int Alpha
        {
            get { return model.Alpha; }
            set
            {
                model.Alpha = value;
                OnPropertyChanged("Alpha");
            }
        }

        public int Red
        {
            get { return model.Red; }
            set
            {
                model.Red = value;
                OnPropertyChanged("Red");
            }
        }

        public int Green
        {
            get { return model.Green; }
            set
            {
                model.Green = value;
                OnPropertyChanged("Green");
            }
        }

        public int Blue
        {
            get { return model.Blue; }
            set
            {
                model.Blue = value;
                OnPropertyChanged("Blue");
            }
        }

        public Color Color
        {
            set
            {
                color = Color.FromArgb((byte)Alpha, (byte)Red, (byte)Green, (byte)Blue);
                OnPropertyChanged("Color");
            }
            get { return Color.FromArgb((byte)Alpha, (byte)Red, (byte)Green, (byte)Blue); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
