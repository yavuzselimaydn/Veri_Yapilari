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

            //Act (eylem)
            int count = array.Count;

            //Assertion (iddia)
            Assert.Equal(2, count);
        }

    }
}