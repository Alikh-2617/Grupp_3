using Xunit;

namespace Grupp_3
{
    public class Xunit_test
    {
        Operation operation = new Operation();

        // [Theory]
        // [InlineData("19950621-0930", true)]  // korrekt personnummer
        // [InlineData("19990102-1234", true)]  // korrekt personnummer
        // [InlineData("invalid_format", false)]  // fel format
        // [InlineData("123456-78901", false)]  // fel lengd
        // [InlineData("abcdefgh-ijkl", false)]  // fel personnummer
        // [InlineData("010101-0101", false)]  // fel personnummer
        public void IsValidPersonnummer_ShouldReturnExpectedResult(string personnummer, bool expected)
        {
            
            bool result = operation.IsValidPersonnummer(personnummer); 

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Gender()
        {
            // oscar
            string pers_nr = "9606234221";
            string result = operation.Gender(pers_nr);

            // funktion funkar korekt
            Assert.True(result.Equals("Man") || result.Equals("Kvinna"));

            //Assert.Equal("Man", result);
            Assert.Equal("Kvinna", result);
        }

        [Fact]
        public void personmmerToIntTest()
        {
            string pers_nr = "900426-3597";
            string result1 = "9004263597";

            Assert.Equal(result1,operation.PersonnummerToCurrent(pers_nr));
        }

    }
}

