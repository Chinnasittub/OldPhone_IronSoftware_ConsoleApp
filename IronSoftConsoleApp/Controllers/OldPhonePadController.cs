using IronSoftConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronSoftConsoleApp.Controllers
{
    namespace IronSoftConsoleApp.Controllers
    {
        public class OldPhonePadController
        {
            public string ConvertInput(string input)
            {
                return OldPhonePadModel.OldPhonePadConverter(input);
            }
        }
    }
}
