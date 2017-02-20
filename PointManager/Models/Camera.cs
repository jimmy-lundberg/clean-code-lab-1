using System;
using System.Windows.Media.Media3D;

namespace PointManager.Models
{
    public class Camera : ModelBase
    {
        private const double halfPi = Math.PI / 180;
        private Point3D _Position;
        private double _HorizontalDegree, _VerticalDegree;

        public Point3D Position { get { return _Position; } set { _Position = value; } }
        public double HorizontalDegree { get { return _HorizontalDegree; } set { _HorizontalDegree = AngleInterval(value); } }
        public double VerticalDegree { get { return _VerticalDegree; } set { _VerticalDegree = AngleInterval(value); } }

        public double X { get { return _Position.X; } set { _Position.X = value; } }
        public double Y { get { return _Position.Y; } set { _Position.Y = value; } }
        public double Z { get { return _Position.Z; } set { _Position.Z = value; } }

        public Point3D Look
        {
            get
            {
                const int distance = 3;
                double X1 = Math.Sin(HorizontalDegree * halfPi) * distance, Z1 = Math.Cos(HorizontalDegree * halfPi) * distance;

                return new Point3D()
                {
                    X = (Math.Cos(VerticalDegree * halfPi) * X1),
                    Y = (Math.Sin(VerticalDegree * halfPi) * distance),
                    Z = (Math.Cos(VerticalDegree * halfPi) * Z1)
                };
            }
        }

        public void Move(double Distance)
        {
            _Position.X += Math.Sin(HorizontalDegree * halfPi) * Distance;
            _Position.Z += Math.Cos(HorizontalDegree * halfPi) * Distance;
        }

        public void Strafe(double Distance)
        {
            var dx = Math.Sin(HorizontalDegree * halfPi) * Distance;
            var dz = Math.Cos(HorizontalDegree * halfPi) * Distance;
            _Position.X += -dz;
            _Position.Z += dx;
        }


        private double AngleInterval(double deg)
        {
            if (deg > 360) return deg - 360;
            if (deg < 0) return deg + 360;
            return deg;
        }
    }
}