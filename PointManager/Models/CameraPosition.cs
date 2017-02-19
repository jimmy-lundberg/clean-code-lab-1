
namespace PointManager.Models
{
    public class CameraPosition : ModelBase
    {
        public int Id { get; set; }
        private string _PositionName;
        private double _X;
        private double _Y;
        private double _Z;
        private double _HorizontalDegree;
        private double _VerticalDegree;

        public string PositionName
        {
            get
            {
                return _PositionName;
            }
            set
            {
                _PositionName = value;
                OnPropertyChanged("PositionName");
            }
        }

        public double X { get { return _X; }
            set
            {
                _X = value;
                OnPropertyChanged("X");
            }
        }
        
        public double Y { get { return _Y; }
            set
            {
                _Y = value;
                OnPropertyChanged("Y");
            }
        }

        public double Z { get { return _Z; }
            set
            {
                _Z = value;
                OnPropertyChanged("Z");
            }
        }

        public double HorizontalDegree { get { return _HorizontalDegree; }
            set
            {
                _HorizontalDegree = value;
                OnPropertyChanged("HorizontalDegree");
            }
        }

        public double VerticalDegree { get { return _VerticalDegree; }
            set
            {
                _VerticalDegree = value;
                OnPropertyChanged("VerticalDegree");
            }
        }
    }
}
