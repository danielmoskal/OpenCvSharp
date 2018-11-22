using OpenCvSharp.Infrastructure.Abstract;
using OpenCvSharp.Infrastructure.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCvSharp
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ISample sample = new SiftSurf();

            sample.Run();
        }
    }
}
