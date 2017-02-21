using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;
using System.Windows.Input;
using System.Windows.Threading;

namespace PointManager.ViewModels
{
    public class MazeViewModel : ViewModelBase
    {
        enum Movement
        {
            Neg = -1,
            None = 0,
            Pos = 1
        }

        //PointManager.Models.Camera camera;
        //PerspectiveCamera perspectiveCamera = new PerspectiveCamera();
        //DispatcherTimer timer;
        Movement Walk, Strafe;
        double Steps = 1;

        private string _Text_X;
        private string _Text_Y;
        private string _Text_Z;
        private string _Text_Vertical;
        private string _Text_Horizontal;

        public string Text_X
        {
            get
            {
                return _Text_X;
            }
            set
            {
                _Text_X = value;
                OnPropertyChanged("Text_X");
            }
        }

        public string Text_Y
        {
            get
            {
                return _Text_Y;
            }
            set
            {
                _Text_Y = value;
                OnPropertyChanged("Text_Y");
            }
        }

        public string Text_Z
        {
            get
            {
                return _Text_Z;
            }
            set
            {
                _Text_Z = value;
                OnPropertyChanged("Text_Z");
            }
        }

        public string Text_Vertical
        {
            get
            {
                return _Text_Vertical;
            }
            set
            {
                _Text_Vertical = value;
                OnPropertyChanged("Text_Vertical");
            }
        }

        public string Text_Horizontal
        {
            get
            {
                return _Text_Horizontal;
            }
            set
            {
                _Text_Horizontal = value;
                OnPropertyChanged("Text_Horizontal");
            }
        }

        public void PrintCameraData(PointManager.Models.Camera camera)
        {
            Text_X = (Math.Round(camera.X, 2)).ToString();
            Text_Y = (Math.Round(camera.Y, 2)).ToString();
            Text_Z = (Math.Round(camera.Z, 2)).ToString();
            Text_Vertical = (Math.Round(camera.VerticalDegree, 2)).ToString();
            Text_Horizontal = (Math.Round(camera.HorizontalDegree, 2)).ToString();
        }

        public void Window1_KeyDown(object sender, KeyEventArgs e, PointManager.Models.Camera camera)
        {
            switch (e.Key)
            {
                case Key.Up: Walk = Movement.Pos; break;
                case Key.Down: Walk = Movement.Neg; break;
                case Key.Left: Strafe = Movement.Neg; break;
                case Key.Right: Strafe = Movement.Pos; break;
                case Key.Z: camera.Y += 0.1; break;
                case Key.X: camera.Y -= 0.1; break;
            }
        }

        public void Window1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Up: Walk = Movement.None; break;
                case Key.Down: Walk = Walk = Movement.None; break;
                case Key.Left: Strafe = Movement.None; break;
                case Key.Right: Strafe = Movement.None; break;
            }
        }

        public void Timer_Tick(object sender, EventArgs e, PointManager.Models.Camera camera, PerspectiveCamera perspectiveCamera)
        {
            if (Walk != Movement.None)
            {
                camera.Move((double)Walk * Steps * 0.1);
            }

            if (Strafe != Movement.None)
            {
                camera.Strafe((double)Strafe * Steps * 0.1);
            }

            perspectiveCamera.Position = camera.Position;
            perspectiveCamera.LookDirection = new Vector3D(camera.Look.X, camera.Look.Y, camera.Look.Z);
            PrintCameraData(camera);
        }
    }
}
