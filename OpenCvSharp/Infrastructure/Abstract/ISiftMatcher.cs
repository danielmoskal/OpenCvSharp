using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCvSharp.Infrastructure.Abstract
{
    public interface ISiftMatcher
    {
        void Execute(double contrastTreshold = 0.04, double sigma = 1.6, double ratioThresh = 0.8);
    }
}
