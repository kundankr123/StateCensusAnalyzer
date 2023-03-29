using StateCensus;

namespace StateCensusTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoadDataFromCSV_ShouldReturnNumberOfRecords()
        {
            // Arrange
            string filePath = "C:\\Users\\kundan\\Desktop\\Bridgelab\\rfp257\\StateCensus\\StateCensus\\Data.csv";
            StateCensusAnalyzer analyser = new StateCensusAnalyzer(filePath);
            int expectedNumberOfRecords = 5;

            // Act
            int actualNumberOfRecords = analyser.LoadDataFromCSV();

            // Assert
            Assert.AreEqual(expectedNumberOfRecords, actualNumberOfRecords);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void LoadDataFromCSV_ShouldThrowException_WhenIncorrectFileIsProvided()
        {
            // ArrangectFile.csv
            string filePath = "C:\\Users\\kundan\\Desktop\\Bridgelab\\rfp257\\StateCensus\\StateCensus\\Incorrectdata.csv";
            StateCensusAnalyzer analyser = new StateCensusAnalyzer(filePath);

            // Act and Assert
            analyser.LoadDataFromCSV();
        }
    }
}