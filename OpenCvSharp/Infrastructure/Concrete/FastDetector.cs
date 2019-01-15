using OpenCvSharp.Infrastructure.Abstract;
using OpenCvSharp.Infrastructure.Const;

namespace OpenCvSharp.Infrastructure.Concrete
{
    public class FastDetector : IFastDetector
    {
        public void Execute(int threshold, bool nonmaxSupression)
        {
            //pobranie obrazu
            Mat imageSrc = new Mat(FilePath.Image.Gesture1, ImreadModes.Color);
            Mat imageDst = imageSrc.Clone();
            Mat imageSrcGray = new Mat();

            //konwersja obrazu kolorowego do obrazu w skali szarości
            Cv2.CvtColor(imageSrc, imageSrcGray, ColorConversionCodes.BGR2GRAY);

            //zastosowanie algorytmu FAST do wyszukania punktów charakterystycznych na obrazie
            KeyPoint[] keypoints = Cv2.FAST(imageSrcGray, threshold, nonmaxSupression);

            //zaznaczenie znalezionych punktów "czerwonym kółkiem"
            foreach (KeyPoint kp in keypoints)
            {
                imageDst.Circle((Point)kp.Pt, 3, Scalar.Red, -1, LineTypes.AntiAlias, 0);
            }

            //wyświetlenie obrazu wynikowego, z zaznaczonymi znalezionymi punktami
            using (new Window($"FAST ({keypoints.Length})({threshold})({nonmaxSupression})", WindowMode.AutoSize, imageDst))
            {

            }
        }
    }
}
