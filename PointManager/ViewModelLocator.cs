using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PointManager.ViewModels;

namespace PointManager
{
    public class ViewModelLocator
    {
        private static MainViewModel _MainViewModel = new MainViewModel();
        private static MazeViewModel _MazeViewModel = new MazeViewModel();
        private static PointNavigationViewModel _PointNavigationViewModel = new PointNavigationViewModel();

        public static MainViewModel MainViewModel { get { return _MainViewModel; } }
        public static MazeViewModel MazeViewModel { get { return _MazeViewModel; } }
        public static PointNavigationViewModel PointNavigationViewModel { get { return _PointNavigationViewModel; } }
    }
}
