namespace ChallengeApp.Test
{
    public class TypeTest
    {
        [Test]
        public void TestWartosciowy()
        {
            //arrange
            int number1 = 1;
            int number2 = 2;
            //act
            //assert
            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void TestReferencyjny()
        {
            //arrange
            string number1 = "Adam";
            string number2 = "Adam";
            //act
            //assert
            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void TestReferencyjny2()
        {
            //arrange
            var employee1 = ("Adam", "Kowalski", 22);
            var employee2 = ("Adrian", "Trzcil", 33);
            //act
            //assert
            Assert.AreNotEqual(employee1, employee2);
        }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name,surname, age);
        }
        
        
    }

}
