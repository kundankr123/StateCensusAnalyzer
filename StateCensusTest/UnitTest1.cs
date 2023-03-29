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
    }
}