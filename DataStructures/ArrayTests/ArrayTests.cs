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

        [Fact]
        public void Array_GetItem_Test()
        {
            //Arange
            var array = new Array.Array();
            array.Add("ahmet");   //  0   4
            array.Add("mehmet");  //  1   4 
            array.Add("Can");     //  2   4
            array.Add("filiz");   //  3   4 
            array.Add("furkan");  //  4   8

            //Act
            object object_ = array.GetItem(2);

            //Assertion
            Assert.Equal("Can", object_);
        }

        [Fact]
        public void Array_Find_Test()
        {
            //Arrange
            var array = new Array.Array();
            array.Add(1);
            array.Add(2);
            array.Add(3);

            //Act
            int result = array.Find(2);

            //Assertion
            Assert.Equal(1, result);
        }

        [Fact]
        public void Array_GetEnumarator()
        {
            //Arange
            var array = new Array.Array();
            array.Add("ahmet");   
            array.Add("mehmet");  
            array.Add("can");

            //Act
            string result = "";
            foreach (var item in array)
            {
                result = string.Concat(result, item);
            }

            //Assertion
            Assert.Equal(result,"ahmetmehmetcan");
        }

    }
}