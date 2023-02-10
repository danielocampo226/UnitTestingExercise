using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(5,5,5,15)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var test = new UnitTestMethods();
            
            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = test.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test1 = new UnitTestMethods();  

            //Act
            var actual = test1.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual); 
        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(5,4,20)]
        //Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test2 = new UnitTestMethods();

            //Act
            var actual = test2.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(20,5,4)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test3 = new UnitTestMethods();

            //Act
            var actual = test3.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        

    }
}
