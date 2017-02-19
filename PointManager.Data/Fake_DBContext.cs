using System.Collections.Generic;

namespace PointManager.Data
{
    public class Fake_DBContext
    {
        public Fake_DBContext()
        {
            GenerateFakeData();
        }

        public List<CameraPosition> CameraPositions { get; set; }

        private void GenerateFakeData()
        {
            CameraPositions = new List<CameraPosition>()
            {
                new CameraPosition() { Id = 1, PositionName =  "Alfa", X = 1, Y = 2,  Z = 0, HorizontalDegree = 30, VerticalDegree = 31 },
                new CameraPosition() { Id = 2, PositionName =  "Beta", X = 2, Y = 3,  Z = 1, HorizontalDegree = 40, VerticalDegree = 41 },
                new CameraPosition() { Id = 3, PositionName = "Gamma", X = 3, Y = 4,  Z = 2, HorizontalDegree = 50, VerticalDegree = 51 },
                new CameraPosition() { Id = 4, PositionName = "Delta", X = 4, Y = 5,  Z = 3, HorizontalDegree = 60, VerticalDegree = 61 },
            };
        }      
    }
}