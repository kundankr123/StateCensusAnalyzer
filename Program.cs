namespace StateCensus
{
    class Program
    {
        public static void Main(string[] args) 
        {
            //Console.WriteLine("Welcome to State Census Analyser Problem");

            string filePath = "C:\\Users\\kundan\\Desktop\\Bridgelab\\rfp257\\StateCensus\\StateCensus\\Data.csv";
            StateCensusAnalyzer analyser = new StateCensusAnalyzer(filePath);
            int numberOfRecords = analyser.LoadDataFromCSV();
            Console.WriteLine("Number of records in the file: " + numberOfRecords);
        }
    }
}