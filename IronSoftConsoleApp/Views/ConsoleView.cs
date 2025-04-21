using IronSoftConsoleApp.Controllers.IronSoftConsoleApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronSoftConsoleApp.Views
{
    public class ConsoleView
    {
        public void DisplayResult(string input)
        {
            var controller = new OldPhonePadController();
            string result = controller.ConvertInput(input);

            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Output: {result}");
        }
    }
}
