namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnsTrue()
        {
            //Arrange
            string password = "ASqw12$$";
            bool expected = true;
            //Act
            bool actual =
             Program.validatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_4Symbols_ReturnsFalse()
        {
            // Arrange
            string password = "Aq1$";
            bool expected = false;
            // Act
            bool actual = Program.validatePassword(password);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_IsSpes_ReturnsTrue()
        {
            //Arrange
            string password = "ASqw12$$";
            bool expected = true;
            //Act
            bool actual =
             Program.validatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_25Symbols_ReturnsFalse()
        {
            // Arrange
            string password = "ASDqwe123$ASDqwe123$ASDqwe123$";
            bool expected = false;
            // Act
            bool actual = Program.validatePassword(password);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_IsNat_ReturnsFalse()
        {
            // Arrange
            string password = "ASDqwe123";
            bool expected = false;
            // Act
            bool actual = Program.validatePassword(password);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_IsPropisi_ReturnsTrue()
        {
            //Arrange
            string password = "ASqw12$$";
            bool expected = true;
            //Act
            bool actual =
             Program.validatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_IsNatPropisi_ReturnsFalse()
        {
            // Arrange
            string password = "asdqwe123$";
            bool expected = false;
            // Act
            bool actual = Program.validatePassword(password);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_IsStrochn_ReturnsTrue()
        {
            //Arrange
            string password = "ASqw12$$";
            bool expected = true;
            //Act
            bool actual =
             Program.validatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_IsNatPStroch_ReturnsFalse()
        {
            // Arrange
            string password = "ASDQWE123$";
            bool expected = false;
            // Act
            bool actual = Program.validatePassword(password);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_IsCifry_ReturnsTrue()
        {
            //Arrange
            string password = "ASqw12$$";
            bool expected = true;
            //Act
            bool actual =
             Program.validatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_IsNatCivry_ReturnsFalse()
        {
            // Arrange
            string password = "ASDqwe$";
            bool expected = false;
            // Act
            bool actual = Program.validatePassword(password);
            //Assert
            Assert.IsFalse(actual);
        }
    }
}
