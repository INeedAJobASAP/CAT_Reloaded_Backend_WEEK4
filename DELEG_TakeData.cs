using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEG_TakeData
{
    internal class DataProcessor
    {
        public delegate void DataReceivedHandler(string data);

        public event DataReceivedHandler dataTaken;

        public void takeData(string data)
        {
            Console.WriteLine("taking data..");
            if (dataTaken != null)
            {
                dataTaken(data);
            }
        }
    }
    internal class Program
    {
        static void Main()
        {
            DataProcessor processor = new DataProcessor();
            processor.dataTaken += printMsg;
            processor.takeData("visca catalonia");
        }
        static void printMsg(string data)
        {
            Console.WriteLine($"data taken: {data}");
        }
    }
}
