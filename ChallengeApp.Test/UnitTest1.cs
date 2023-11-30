namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectSetOfPositiveAndNegativePoints_ShouldReturnCorrectSum()
        {
            //arrange
            var employee = new Employee("Adam", "Kowalski", 22);
            employee.AddScore(-3);
            employee.AddScore(-2);
            employee.AddScore(-1);
            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(-6, result);

        }
    }
}