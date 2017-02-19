using System;
using PointManager.Models;
using System.Windows.Input;
using PointManager.Commands;

namespace PointManager.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private CameraPosition _ModelCameraPosition;

        public MainViewModel()
        {
            System.Diagnostics.Debug.WriteLine("MainViewModel instans skapad: " + DateTime.Now);
            LoadModelCameraPosition();
            InitializeCommands();
        }
        
        public CameraPosition ModelCameraPosition
        {
            get { return _ModelCameraPosition; }
            set
            {
                _ModelCameraPosition = value;
                OnPropertyChanged("ModelCameraPosition"); 
            }
        }

        private void LoadModelCameraPosition()
        {
            ModelCameraPosition = new CameraPosition()
            {
                Id = 1,
                PositionName = "Origo",
                X = 0.35,
                Y = 0,
                Z = 0,
                HorizontalDegree = 0,
                VerticalDegree = 0
            };
        }
        
        private ICommand _SaveCameraPositionCommand;
        public ICommand SaveCameraPositionCommand
        {
            get { return _SaveCameraPositionCommand; }
            set { _SaveCameraPositionCommand = value; OnPropertyChanged("SaveCameraPositionCommand"); }
        }


        private void UpdateCameraPositionFunction()
        {
            ModelCameraPosition.PositionName += " * ";
        }

        private void InitializeCommands()
        {
            SaveCameraPositionCommand = new SaveCameraPositionCommand(UpdateCameraPositionFunction);
        }


    }
}