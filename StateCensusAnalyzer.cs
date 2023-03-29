using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCensus
{
    public class StateCensusAnalyzer
    {
        private string filePath;

        public StateCensusAnalyzer(string filePath)
        {
            this.filePath = filePath;
        }


        public int LoadDataFromCSV()
        {
            int numberOfRecords = 0;
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] fields = line.Split(',');
                        // Process the fields here
                        numberOfRecords++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return numberOfRecords;
        }

        public int LoadDataFromCSV(char delimiter)
        {
            int numberOfRecords = 0;
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] fields = line.Split(delimiter);

                        // Check that the number of fields is correct
                        if (fields.Length != 4)
                        {
                            throw new Exception("Incorrect number of fields in row: " + line);
                        }

                        // Process the fields here
                        numberOfRecords++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }

            return numberOfRecords;
        }
    }
}
