using InternShipProject.Concrete;

namespace TestLayer
{
    public class UnitTest
    {
        [Fact]
        public void Test_Circle_Area()
        {
            var val = new CircleManager();

            var area = val.AreaOfCircle(30); 

            Assert.Equal(188.4, area);


        }

        [Fact]
        public void Test_Triangel_Area()
        {
            var val = new TriangelManager();
            var area = val.AreaOfTriangel(4,13,15);

            Assert.Equal(24, area);
           

        }
    }
}