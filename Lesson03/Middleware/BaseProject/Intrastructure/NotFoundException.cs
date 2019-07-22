using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProject.Intrastructure
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string username) : base()
        {
            Console.WriteLine("The user '{0}' is not found", username);
        }

    }
}
