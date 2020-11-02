using System;
using TechTalk.SpecFlow;
using Xunit;

namespace testBDD
{
    [Binding]
    public class TrigonometricalCalculatorSteps
    {
        Double number;

        [Given(@"an empty number")]
        public void GivenAnEmptyNumber()
        {
            number = 0;
        }
        
        [When(@"when user enters his number")]
        public void WhenWhenUserEntersHisNumber()
        {
            number = Math.PI;
        }
        
        [Then(@"the sinus should be calculated")]
        public void ThenTheSinusShouldBeCalculated()
        {
            Double sin = Math.Sin(number);

            Double expected = 0.0;
            Double actual = sin;

            Assert.Equal(expected, actual, 5);
        }
        
        [Then(@"the cosinus should be calculated")]
        public void ThenTheCosinusShouldBeCalculated()
        {
            Double cos = Math.Cos(number);

            Double expected = -1.0;
            Double actual = cos;

            Assert.Equal(expected, actual, 5);
        }
        
        [Then(@"the tanges should be calculated")]
        public void ThenTheTangesShouldBeCalculated()
        {
            Double tan = Math.Cos(number);

            Double expected = -1.0;
            Double actual = tan;

            Assert.Equal(expected, actual, 5);
        }
    }
}
