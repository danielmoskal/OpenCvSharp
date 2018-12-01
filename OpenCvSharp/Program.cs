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
            ISiftMatcher siftMatcher = new SiftMatcher();
            //sigma 1.2 - 1.7
            //contrastThreshold 0.01 - 0.06
            //ratio test 0.7 - 0.9 / korekta 0.5 - 0.8 (0.9 daje złe wyniki, zamiast niego przetestuje 0.6 i moze potem 0.5)

            //siftMatcher.Execute(0.01, 1.2, 0.5);
            //siftMatcher.Execute(0.01, 1.3, 0.5);
            //siftMatcher.Execute(0.01, 1.4, 0.5);
            //siftMatcher.Execute(0.01, 1.5, 0.5);
            //siftMatcher.Execute(0.01, 1.6, 0.5);
            //siftMatcher.Execute(0.01, 1.7, 0.5);

            //siftMatcher.Execute(0.01, 1.2, 0.6);
            //siftMatcher.Execute(0.01, 1.3, 0.6);
            //siftMatcher.Execute(0.01, 1.4, 0.6);
            //siftMatcher.Execute(0.01, 1.5, 0.6);
            //siftMatcher.Execute(0.01, 1.6, 0.6);
            siftMatcher.Execute(0.01, 1.7, 0.6);

            //siftMatcher.Execute(0.01, 1.2, 0.7);
            //siftMatcher.Execute(0.01, 1.3, 0.7);
            //siftMatcher.Execute(0.01, 1.4, 0.7);
            //siftMatcher.Execute(0.01, 1.5, 0.7);
            //siftMatcher.Execute(0.01, 1.6, 0.7);
            //siftMatcher.Execute(0.01, 1.7, 0.7);

            //siftMatcher.Execute(0.01, 1.2, 0.8);
            //siftMatcher.Execute(0.01, 1.3, 0.8);
            //siftMatcher.Execute(0.01, 1.4, 0.8);
            //siftMatcher.Execute(0.01, 1.5, 0.8);
            //siftMatcher.Execute(0.01, 1.6, 0.8);
            //siftMatcher.Execute(0.01, 1.7, 0.8);

            //siftMatcher.Execute(0.02, 1.2, 0.5);
            //siftMatcher.Execute(0.02, 1.3, 0.5);
            //siftMatcher.Execute(0.02, 1.4, 0.5);
            //siftMatcher.Execute(0.02, 1.5, 0.5);
            //siftMatcher.Execute(0.02, 1.6, 0.5);
            //siftMatcher.Execute(0.02, 1.7, 0.5);

            //siftMatcher.Execute(0.02, 1.2, 0.6);
            //siftMatcher.Execute(0.02, 1.3, 0.6);
            //siftMatcher.Execute(0.02, 1.4, 0.6);
            //siftMatcher.Execute(0.02, 1.5, 0.6);
            //siftMatcher.Execute(0.02, 1.6, 0.6);
            //siftMatcher.Execute(0.02, 1.7, 0.6);

            //siftMatcher.Execute(0.02, 1.2, 0.7);
            //siftMatcher.Execute(0.02, 1.3, 0.7);
            //siftMatcher.Execute(0.02, 1.4, 0.7);
            //siftMatcher.Execute(0.02, 1.5, 0.7);
            //siftMatcher.Execute(0.02, 1.6, 0.7);
            //siftMatcher.Execute(0.02, 1.7, 0.7);

            //siftMatcher.Execute(0.02, 1.2, 0.8);
            //siftMatcher.Execute(0.02, 1.3, 0.8);
            //siftMatcher.Execute(0.02, 1.4, 0.8);
            //siftMatcher.Execute(0.02, 1.5, 0.8);
            //siftMatcher.Execute(0.02, 1.6, 0.8);
            //siftMatcher.Execute(0.02, 1.7, 0.8);

            //siftMatcher.Execute(0.03, 1.2, 0.5);
            //siftMatcher.Execute(0.03, 1.3, 0.5);
            //siftMatcher.Execute(0.03, 1.4, 0.5);
            //siftMatcher.Execute(0.03, 1.5, 0.5);
            //siftMatcher.Execute(0.03, 1.6, 0.5);
            //siftMatcher.Execute(0.03, 1.7, 0.5);

            //siftMatcher.Execute(0.03, 1.2, 0.6);
            //siftMatcher.Execute(0.03, 1.3, 0.6);
            //siftMatcher.Execute(0.03, 1.4, 0.6);
            //siftMatcher.Execute(0.03, 1.5, 0.6);
            //siftMatcher.Execute(0.03, 1.6, 0.6);
            //siftMatcher.Execute(0.03, 1.7, 0.6);

            //siftMatcher.Execute(0.03, 1.2, 0.7);
            //siftMatcher.Execute(0.03, 1.3, 0.7);
            //siftMatcher.Execute(0.03, 1.4, 0.7);
            //siftMatcher.Execute(0.03, 1.5, 0.7);
            //siftMatcher.Execute(0.03, 1.6, 0.7);
            //siftMatcher.Execute(0.03, 1.7, 0.7);

            //siftMatcher.Execute(0.03, 1.2, 0.8);
            //siftMatcher.Execute(0.03, 1.3, 0.8);
            //siftMatcher.Execute(0.03, 1.4, 0.8);
            //siftMatcher.Execute(0.03, 1.5, 0.8);
            //siftMatcher.Execute(0.03, 1.6, 0.8);
            //siftMatcher.Execute(0.03, 1.7, 0.8);

            //siftMatcher.Execute(0.03, 1.2, 0.9);
            //siftMatcher.Execute(0.03, 1.3, 0.9);
            //siftMatcher.Execute(0.03, 1.4, 0.9);
            //siftMatcher.Execute(0.03, 1.5, 0.9);
            //siftMatcher.Execute(0.03, 1.6, 0.9);
            //siftMatcher.Execute(0.03, 1.7, 0.9);

            //siftMatcher.Execute(0.04, 1.2, 0.5);
            //siftMatcher.Execute(0.04, 1.3, 0.5);
            //siftMatcher.Execute(0.04, 1.4, 0.5);
            //siftMatcher.Execute(0.04, 1.5, 0.5);
            //siftMatcher.Execute(0.04, 1.6, 0.5);
            //siftMatcher.Execute(0.04, 1.7, 0.5);

            //siftMatcher.Execute(0.04, 1.2, 0.6);
            //siftMatcher.Execute(0.04, 1.3, 0.6);
            //siftMatcher.Execute(0.04, 1.4, 0.6);
            //siftMatcher.Execute(0.04, 1.5, 0.6);
            //siftMatcher.Execute(0.04, 1.6, 0.6);
            //siftMatcher.Execute(0.04, 1.7, 0.6);

            //siftMatcher.Execute(0.04, 1.2, 0.7);
            //siftMatcher.Execute(0.04, 1.3, 0.7);
            //siftMatcher.Execute(0.04, 1.4, 0.7);
            //siftMatcher.Execute(0.04, 1.5, 0.7);
            //siftMatcher.Execute(0.04, 1.6, 0.7);
            //siftMatcher.Execute(0.04, 1.7, 0.7);

            //siftMatcher.Execute(0.04, 1.2, 0.8);
            //siftMatcher.Execute(0.04, 1.3, 0.8);
            //siftMatcher.Execute(0.04, 1.4, 0.8);
            //siftMatcher.Execute(0.04, 1.5, 0.8);
            //siftMatcher.Execute(0.04, 1.6, 0.8);
            //siftMatcher.Execute(0.04, 1.7, 0.8);

            //siftMatcher.Execute(0.04, 1.2, 0.9);
            //siftMatcher.Execute(0.04, 1.3, 0.9);
            //siftMatcher.Execute(0.04, 1.4, 0.9);
            //siftMatcher.Execute(0.04, 1.5, 0.9);
            //siftMatcher.Execute(0.04, 1.6, 0.9);
            //siftMatcher.Execute(0.04, 1.7, 0.9);

            //siftMatcher.Execute(0.05, 1.2, 0.5);
            //siftMatcher.Execute(0.05, 1.3, 0.5);
            //siftMatcher.Execute(0.05, 1.4, 0.5);
            //siftMatcher.Execute(0.05, 1.5, 0.5);
            //siftMatcher.Execute(0.05, 1.6, 0.5);
            //siftMatcher.Execute(0.05, 1.7, 0.5);

            //siftMatcher.Execute(0.05, 1.2, 0.6);
            //siftMatcher.Execute(0.05, 1.3, 0.6);
            //siftMatcher.Execute(0.05, 1.4, 0.6);
            //siftMatcher.Execute(0.05, 1.5, 0.6);
            //siftMatcher.Execute(0.05, 1.6, 0.6);
            //siftMatcher.Execute(0.05, 1.7, 0.6);

            //siftMatcher.Execute(0.05, 1.2, 0.7);
            //siftMatcher.Execute(0.05, 1.3, 0.7);
            //siftMatcher.Execute(0.05, 1.4, 0.7);
            //siftMatcher.Execute(0.05, 1.5, 0.7);
            //siftMatcher.Execute(0.05, 1.6, 0.7);
            //siftMatcher.Execute(0.05, 1.7, 0.7);

            //siftMatcher.Execute(0.05, 1.2, 0.8);
            //siftMatcher.Execute(0.05, 1.3, 0.8);
            //siftMatcher.Execute(0.05, 1.4, 0.8);
            //siftMatcher.Execute(0.05, 1.5, 0.8);
            //siftMatcher.Execute(0.05, 1.6, 0.8);
            //siftMatcher.Execute(0.05, 1.7, 0.8);

            //siftMatcher.Execute(0.06, 1.2, 0.5);
            //siftMatcher.Execute(0.06, 1.3, 0.5);
            //siftMatcher.Execute(0.06, 1.4, 0.5);
            //siftMatcher.Execute(0.06, 1.5, 0.5);
            //siftMatcher.Execute(0.06, 1.6, 0.5);
            //siftMatcher.Execute(0.06, 1.7, 0.5);

            //siftMatcher.Execute(0.06, 1.2, 0.6);
            //siftMatcher.Execute(0.06, 1.3, 0.6);
            //siftMatcher.Execute(0.06, 1.4, 0.6);
            //siftMatcher.Execute(0.06, 1.5, 0.6);
            //siftMatcher.Execute(0.06, 1.6, 0.6);
            //siftMatcher.Execute(0.06, 1.7, 0.6);

            //siftMatcher.Execute(0.06, 1.2, 0.7);
            //siftMatcher.Execute(0.06, 1.3, 0.7);
            //siftMatcher.Execute(0.06, 1.4, 0.7);
            //siftMatcher.Execute(0.06, 1.5, 0.7);
            //siftMatcher.Execute(0.06, 1.6, 0.7);
            //siftMatcher.Execute(0.06, 1.7, 0.7);

            //siftMatcher.Execute(0.06, 1.2, 0.8);
            //siftMatcher.Execute(0.06, 1.3, 0.8);
            //siftMatcher.Execute(0.06, 1.4, 0.8);
            //siftMatcher.Execute(0.06, 1.5, 0.8);
            //siftMatcher.Execute(0.06, 1.6, 0.8);
            //siftMatcher.Execute(0.06, 1.7, 0.8);

            Cv2.WaitKey();
        }
    }
}
