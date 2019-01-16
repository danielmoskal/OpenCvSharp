using OpenCvSharp.Infrastructure.Abstract;
using OpenCvSharp.Infrastructure.Concrete;
using OpenCvSharp.Infrastructure.Const;
using Spire.Xls;
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
            try
            {
                //ExecuteFastDetector();
                //ExecuteSiftMatcher();
                ExecuteNewSiftMatcher();
                //DrawPoints();
            }
            catch (Exception ex)
            {

            }

        }

        static void TestExcelLibrary()
        {
            //Workbook book = new Workbook();
            //Worksheet sheet = book.Worksheets[0];
            //sheet.InsertArray()
            //sheet.InsertDataTable(t, true, 1, 1);
            //book.SaveToFile("insertTableToExcel.xls", ExcelVersion.Version2013);
            //System.Diagnostics.Process.Start("insertTableToExcel.xls");

        }

        static void ExecuteNewSiftMatcher()
        {
            ISiftMatcher siftMatcher = new NewSiftMatcher();
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
            //siftMatcher.Execute(0.01, 1.7, 0.6);

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
            siftMatcher.Execute(0.02, 1.5, 0.7);
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


        static void DrawPoints()
        {
            Mat image1 = new Mat(FilePath.Image.Gesture1, ImreadModes.Color);
            Mat image2 = new Mat(FilePath.Image.Gesture2, ImreadModes.Color);
            Mat gray1 = new Mat();
            Mat gray2 = new Mat();
            Mat binary1 = new Mat();
            Mat binary1NonZero = new Mat();
            Cv2.CvtColor(image1, gray1, ColorConversionCodes.BGR2GRAY);
            Cv2.CvtColor(image2, gray2, ColorConversionCodes.BGR2GRAY);
            Cv2.Threshold(gray1, binary1, 5, 255, ThresholdTypes.Binary);
            Cv2.FindNonZero(binary1, binary1NonZero);

            //KeyPoint keyPoint1 = new KeyPoint(new Point2f(181.5374f, 58.5472f), 2);
            //KeyPoint keyPoint2 = new KeyPoint(new Point2f(185.6390f, 59.2187f), 2);
            //KeyPoint keyPoint1 = new KeyPoint(new Point2f(142.1004f, 50.1839f), 2);
            //KeyPoint keyPoint2 = new KeyPoint(new Point2f(148.5375f, 49.7307f), 2);
            KeyPoint keyPoint1 = new KeyPoint(new Point2f(150, 50), 2);
            KeyPoint keyPoint2 = new KeyPoint(new Point2f(155.5366f, 49.7075f), 2);

            gray1.Circle((Point)keyPoint1.Pt, 3, Scalar.White, -1, LineTypes.AntiAlias, 0);
            gray2.Circle((Point)keyPoint2.Pt, 3, Scalar.White, -1, LineTypes.AntiAlias, 0);

            //wyświetlenie obrazu wynikowego, z zaznaczonymi znalezionymi punktami
            using (new Window($"gray1({keyPoint1.Pt.X})({keyPoint1.Pt.Y})", WindowMode.AutoSize, gray1))
            using (new Window($"gray2({keyPoint2.Pt.X})({keyPoint2.Pt.Y})", WindowMode.AutoSize, gray2))
            using (new Window($"binary1", WindowMode.AutoSize, binary1))
            using (new Window($"binary1NonZero", WindowMode.AutoSize, binary1NonZero))
            {
                Cv2.WaitKey();
            }

        }

        static void ExecuteFastDetector()
        {
            IFastDetector fastDetector = new FastDetector();

            //wielokrotne wywoływanie metody wyszukującej punkty 
            //charakterystyczne za pomocą algorytmu FAST, z różnymi 
            //wartościami threshold oraz nonmaxSupression
            fastDetector.Execute(50, false);
            fastDetector.Execute(50, true);
            fastDetector.Execute(100, false);
            fastDetector.Execute(100, true);

            Cv2.WaitKey();
        }

        static void ExecuteSiftMatcher()
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
            //siftMatcher.Execute(0.01, 1.7, 0.6);

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
            siftMatcher.Execute(0.02, 1.5, 0.7);
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
