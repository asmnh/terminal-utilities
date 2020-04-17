using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbcopy
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Stream input = Console.OpenStandardInput();
            byte[] buffer = new byte[1024];
            List<byte> inputBuffer = new List<byte>();

            while(true)
            {
                int read = input.Read(buffer, 0, buffer.Length);
                if(read > 0)
                {
                    inputBuffer.AddRange(buffer.Take(read));
                } else
                {
                    break;
                }
            }

            string stdin = Console.InputEncoding.GetString(inputBuffer.ToArray());

            Clipboard.SetText(stdin, Console.InputEncoding == Encoding.Unicode || Console.InputEncoding == Encoding.UTF8 ? TextDataFormat.UnicodeText: TextDataFormat.Text);
        }
    }
}
