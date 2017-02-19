using PointManager.Data;
using PointManager.Services;
using System.Collections.ObjectModel;

namespace PointManager.ViewModels
{
    public class PointNavigationViewModel : ViewModelBase
    {
        public ObservableCollection<CameraPosition> CameraPositions { get; set; }
        public ICameraPositionRepository CameraPositionRepository { get; set; }

        public PointNavigationViewModel()
        {
            LoadData();
        }

        private void LoadData()
        {
            CameraPositionRepository = new CameraPositionRepository();
            CameraPositions = new ObservableCollection<CameraPosition>(CameraPositionRepository.GetCameraPositions());
        }

    }
}