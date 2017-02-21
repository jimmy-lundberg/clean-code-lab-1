using System;
using System.Windows;
using System.Windows.Media.Media3D;
using System.Windows.Input;
using System.Windows.Threading;

namespace PointManager.Views
{
    public partial class MazeWindow : Window
    {
        public MazeWindow()
        {
            InitializeComponent();
        }

        //enum Movement
        //{
        //    Neg = -1,
        //    None = 0,
        //    Pos = 1
        //}

        PointManager.Models.Camera camera;
        PerspectiveCamera perspectiveCamera = new PerspectiveCamera();
        DispatcherTimer timer;
        //Movement Walk, Strafe;
        //double Steps = 1;

        private void PrintCameraData()
        {
            ViewModelLocator.MazeViewModel.PrintCameraData(camera);
            //TextBox_X.Text = (Math.Round(camera.X, 2)).ToString();
            //TextBox_Y.Text = (Math.Round(camera.Y, 2)).ToString();
            //TextBox_Z.Text = (Math.Round(camera.Z, 2)).ToString();
            //TextBox_Vertical.Text = (Math.Round(camera.VerticalDegree, 2)).ToString();
            //TextBox_Horizontal.Text = (Math.Round(camera.HorizontalDegree, 2)).ToString();
        }

        private void Window1_KeyDown(object sender, KeyEventArgs e)
        {
            ViewModelLocator.MazeViewModel.Window1_KeyDown(sender, e, camera);

            //switch (e.Key)
            //{
            //    case Key.Up: Walk = Movement.Pos; break;
            //    case Key.Down: Walk = Movement.Neg; break;
            //    case Key.Left: Strafe = Movement.Neg; break;
            //    case Key.Right: Strafe = Movement.Pos; break;
            //    case Key.Z: camera.Y += 0.1; break;
            //    case Key.X: camera.Y -= 0.1; break;
            //}
        }

        private void Window1_KeyUp(object sender, KeyEventArgs e)
        {
            ViewModelLocator.MazeViewModel.Window1_KeyUp(sender, e);

            //switch (e.Key)
            //{
            //    case Key.Up: Walk = Movement.None; break;
            //    case Key.Down: Walk = Walk = Movement.None; break;
            //    case Key.Left: Strafe = Movement.None; break;
            //    case Key.Right: Strafe = Movement.None; break;
            //}
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ViewModelLocator.MazeViewModel.Timer_Tick(sender, e, camera, perspectiveCamera);

            //if (Walk != Movement.None)
            //{
            //    camera.Move((double)Walk * Steps * 0.1);
            //}

            //if (Strafe != Movement.None)
            //{
            //    camera.Strafe((double)Strafe * Steps * 0.1);
            //}

            //perspectiveCamera.Position = camera.Position;
            //perspectiveCamera.LookDirection = new Vector3D(camera.Look.X, camera.Look.Y, camera.Look.Z);
            //PrintCameraData();
        }

        private void Window1_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            Viewport3D_World.Camera = perspectiveCamera;
            camera = new PointManager.Models.Camera() { X = 1, Y = 0.5, Z = 0 }; //camera.HorizontalDegree = camera.VerticalDegree =0;
            perspectiveCamera.Position = camera.Position;
            perspectiveCamera.LookDirection = new Vector3D(camera.Look.X, camera.Look.Y, camera.Look.Z);
            (new PointManager.Models.MazeGenerator()).MakeMaze(Model3DGroup_Lights);
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(16);
            timer.Tick += new EventHandler(Timer_Tick);
            this.timer.Start();
        }

        private void SetCameraAngles(Point point)
        {
            var midY = this.ActualHeight / 2;
            // ned:  360-270.
            if (point.Y > midY)
            {
                var proc = (point.Y - midY) / midY;
                camera.VerticalDegree = 360 - 90 * proc;
            }
            // Vert: up:  0-90
            if (point.Y < midY)
            {
                var proc = point.Y / midY;
                camera.VerticalDegree = 90 - 90 * proc;
            }
            var proc2 = point.X / this.ActualWidth;
            camera.HorizontalDegree = 720 - 720 * proc2;
        }

        private void Window1_MouseMove(object sender, MouseEventArgs e)
        {
            SetCameraAngles(e.GetPosition(null));
        }
    }
}