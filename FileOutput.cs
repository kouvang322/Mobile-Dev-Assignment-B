using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_B
{
    public class FileOutput
    {
        public StreamWriter _streamWriter = null;
        private string fileName;

        public FileOutput(string fileName)
        {
            this.fileName = fileName;
            try
            {
               
                _streamWriter = new StreamWriter(fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
        }

        public void FileWrite(string line)
        {
            try
            {
                _streamWriter.Write(line + "\n");
            }catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + fileName + " " + e);
            }
        }

        public void FileClose()
        {
            if( _streamWriter != null )
            {
                try
                {
                    _streamWriter.Close();
                }catch (IOException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }
    }
}
