
 [Theory]
    [InlineData("19950621-0930", true)]  // korrekt personnummer
    [InlineData("19990102-1234", true)]  // korrekt personnummer
     [InlineData("invalid_format", false)]  // fel format
     [InlineData("123456-78901", false)]  // fel lengd
     [InlineData("abcdefgh-ijkl", false)]  // fel personnummer
     [InlineData("010101-0101", false)]  // fel personnummer
        public void IsValidPersonnummer_ShouldReturnExpectedResult(string personnummer, bool expected)
        {
            
            bool result = opersion.IsValidPersonnummer(personnummer); 

            Assert.Equal(expected, result);
        }

namespace Grupp_3
{
    public class Xunit_test
    {
        

    }
}

