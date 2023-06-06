using InternShipProject.Concrete;
using InternShipProject.Interfaces;

namespace TestLayer
{
    public class UnitTest
    {
        ICircleService circleService;
        ITriangelService triangelService;
        public UnitTest(ICircleService circleService, ITriangelService triangelService)
        {
            this.circleService = circleService;
            this.triangelService = triangelService;

                
        }
        [Fact]
        public void Test_Circle_Area()
        {

           
            var area = circleService.AreaOfCircle(30);

            Assert.Equal(188.4, area);


        }

        [Fact]
        public void Test_Triangel_Area()
        {
         
            var area = triangelService.AreaOfTriangel(4, 13, 15);

            Assert.Equal(24, area);
           

        }
    }
}