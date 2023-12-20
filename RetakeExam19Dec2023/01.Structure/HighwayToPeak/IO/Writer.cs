namespace HighwayToPeak.IO
{
    using System;
    using System.IO; // Add this using directive for StreamWriter
    using HighwayToPeak.IO.Contracts;

    public class Writer : IWriter
    {
        private readonly string filePath;

        public Writer()
        {
            // Use a relative path for the file
            this.filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "output.txt");
        }

        public void Write(string message)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.Write(message);
            }
        }

        public void WriteLine(string message)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(message);
            }
        }
    }
}
