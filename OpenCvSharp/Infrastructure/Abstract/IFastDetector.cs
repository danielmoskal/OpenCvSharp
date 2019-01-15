using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCvSharp.Infrastructure.Abstract
{
    public interface IFastDetector
    {
        void Execute(int threshold, bool nonmaxSupression);
    }
}
