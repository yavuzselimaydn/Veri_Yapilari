namespace ArrayTests
{
    public class ArrayTests
    {
        [Fact]
        public void Array_Count_Test()
        {
            //Arange (düzenleme) 
            var array = new Array.Array();
            array.Add("ahmet");
            array.Add("mehmet");
            array.Add("mehme");
            

            //Act (eylem)
            int count = array.Count;

            //Assertion (iddia)
            Assert.Equal(3, count);
            Assert.Equal(4, array.Capacity);
        }

        [Fact]
        public void Array_Add_Test()
        {
            //Arange (düzenleme) 
            var array = new Array.Array();
            array.Add("ahmet");
            array.Add("mehmet");
            array.Add("mehme");
            array.Add("meh");
            array.Add("meh");

            //Act (eylem)
            int count = array.Count;

            //Assertion (iddia)
            Assert.Equal(5, count);
            Assert.Equal(8, array.Capacity);


        }

    }
}