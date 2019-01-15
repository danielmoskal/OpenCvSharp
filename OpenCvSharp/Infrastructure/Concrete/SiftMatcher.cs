using OpenCvSharp.Infrastructure.Abstract;
using OpenCvSharp.Infrastructure.Const;
using OpenCvSharp.XFeatures2D;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenCvSharp.Infrastructure.Concrete
{
    public class SiftMatcher : ISiftMatcher
    {
        public void Execute(double contrastTreshold = 0.04, double sigma = 1.6, double ratioThresh = 0.8)
        {
            Mat image1 = new Mat(FilePath.Image.Gesture1, ImreadModes.Color);
            Mat image2 = new Mat(FilePath.Image.Gesture2, ImreadModes.Color);
            Mat gray1 = new Mat();
            Mat gray2 = new Mat();
            Cv2.CvtColor(image1, gray1, ColorConversionCodes.BGR2GRAY);
            Cv2.CvtColor(image2, gray2, ColorConversionCodes.BGR2GRAY);

            SIFT sift = SIFT.Create(0, 3, contrastTreshold, 10, sigma);

            // Detect the keypoints and generate their descriptors using SIFT
            KeyPoint[] keypoints1, keypoints2;
            var descriptors1 = new MatOfFloat();
            var descriptors2 = new MatOfFloat();
            sift.DetectAndCompute(gray1, null, out keypoints1, descriptors1);
            sift.DetectAndCompute(gray2, null, out keypoints2, descriptors2);

            // Match descriptor vectors
            var bfMatcher = new BFMatcher(NormTypes.L2, false);
            var flannMatcher = new FlannBasedMatcher();
            DMatch[][] knnBfMatches = bfMatcher.KnnMatch(descriptors1, descriptors2, 2);
            DMatch[] bfMatches = bfMatcher.Match(descriptors1, descriptors2);
            DMatch[][] knnFlannMatches = flannMatcher.KnnMatch(descriptors1, descriptors2, 2);
            DMatch[] flannMatches = flannMatcher.Match(descriptors1, descriptors2);

            //TODO ratio test
            IList<DMatch> listOfGoodBfMatches = new List<DMatch>();
            IList<DMatch> listOfGoodFlannMatches = new List<DMatch>();
            for (int i = 0; i < knnBfMatches.Length; i++)
            {
                DMatch[] tempMatches = knnBfMatches[i];
                if (tempMatches.Length > 1)
                {
                    if (tempMatches[0].Distance < ratioThresh * tempMatches[1].Distance)
                    {
                        listOfGoodBfMatches.Add(tempMatches[0]);
                    }
                }
            }
            for (int i = 0; i < knnFlannMatches.Length; i++)
            {
                DMatch[] tempMatches = knnFlannMatches[i];
                if (tempMatches.Length > 1)
                {
                    if (tempMatches[0].Distance < ratioThresh * tempMatches[1].Distance)
                    {
                        listOfGoodFlannMatches.Add(tempMatches[0]);
                    }
                }
            }
            var arrayOfMatches = listOfGoodFlannMatches.ToArray();
            IList<DMatch> listOfMatches = new List<DMatch>();
            //listOfMatches.Add(arrayOfMatches[6]);
            //listOfMatches.Add(arrayOfMatches[7]);
            //listOfMatches.Add(arrayOfMatches[15]);
            listOfMatches.Add(arrayOfMatches[0]);
            listOfMatches.Add(arrayOfMatches[1]);
            listOfMatches.Add(arrayOfMatches[2]);
            listOfMatches.Add(arrayOfMatches[3]);
            listOfMatches.Add(arrayOfMatches[4]);
            listOfMatches.Add(arrayOfMatches[5]);
            listOfMatches.Add(arrayOfMatches[8]);
            listOfMatches.Add(arrayOfMatches[9]);
            listOfMatches.Add(arrayOfMatches[10]);
            listOfMatches.Add(arrayOfMatches[11]);
            KeyPoint[] P1s = new KeyPoint[13];
            KeyPoint[] P2s = new KeyPoint[13];
            for (int i = 0, j = 0; i < 13; i++, j++)
            {
                if (j == 6)
                {
                    j = 8;
                }

                P1s[i] = keypoints1[arrayOfMatches[j].QueryIdx];
                P2s[i] = keypoints2[arrayOfMatches[j].TrainIdx];
            }

            for (int i = 0; i < P1s.Length; i++)
            {
                Console.WriteLine($"P1[{i}]: {P1s[i].Pt.X}  {P1s[i].Pt.Y}");
            }
            Console.WriteLine($"\n P2 points: ");
            for (int i = 0; i < P2s.Length; i++)
            {
                Console.WriteLine($"P2[{i}]: {P2s[i].Pt.X}  {P2s[i].Pt.Y}");
            }

            MatOfPoint2f source = new MatOfPoint2f();
            MatOfPoint2f descination = new MatOfPoint2f();
            MatOfPoint2f a = new MatOfPoint2f();
            double[,] data = new double[12, 12];
            for (int i = 0; i < P1s.Length; i++)
            {
                source.Add(P1s[i].Pt);
                descination.Add(P2s[i].Pt);
            }
            var s = source.ToArray();
            var d = descination.ToArray();
            Mat homography = Cv2.FindHomography(descination, source);
            homography.GetArray(0, 1, data);
            homography.ConvertTo(a, 5);
            var b = a.ToPrimitiveArray();
            //var b = homography.GetArray(0, 1);
            //var c = homography.ToBytes();
            //VectorOfPoint2f vectorOfPoint2F = new VectorOfPoint2f(homography.Rows * homography.Cols);
            //if (homography.IsContinuous())
            //    vectorOfPoint2F = homography.Data;


            // Draw matches
            var img1WithPoints = new Mat();
            Cv2.DrawKeypoints(gray1, P1s, img1WithPoints, Scalar.Red);
            var img2WithPoints = new Mat();
            Cv2.DrawKeypoints(gray2, P2s, img2WithPoints, Scalar.Red);
            var knnFlannView2 = new Mat();

            Cv2.DrawMatches(gray1, keypoints1, gray2, keypoints2, listOfMatches.ToArray(), knnFlannView2, Scalar.Red);
            var knnBfView = new Mat();
            Cv2.DrawMatches(gray1, keypoints1, gray2, keypoints2, listOfGoodBfMatches.ToArray(), knnBfView);
            var bfView = new Mat();
            Cv2.DrawMatches(gray1, keypoints1, gray2, keypoints2, bfMatches, bfView);

            var knnFlannView = new Mat();
            Cv2.DrawMatches(gray1, keypoints1, gray2, keypoints2, listOfGoodFlannMatches.ToArray(), knnFlannView, Scalar.Green, Scalar.Red);
            var flannView = new Mat();
            Cv2.DrawMatches(gray1, keypoints1, gray2, keypoints2, flannMatches, flannView);

            Console.WriteLine("SIFT");
            Console.Write("KeyPoint1: " + keypoints1.ToList().Count);
            Console.WriteLine("\tKeyPoint2: " + keypoints2.ToList().Count);
            Console.Write("Descriptors1: " + descriptors1.ToList().Count);
            Console.WriteLine("\tDescriptors2: " + descriptors2.ToList().Count);
            Console.Write("bfMatches: " + bfMatches.ToList().Count);
            Console.WriteLine("\tflannMatches: " + flannMatches.ToList().Count);
            Console.Write("knnBfMatches: " + listOfGoodBfMatches.Count);
            Console.WriteLine("\tknnFlannMatches: " + listOfGoodFlannMatches.Count);
            Console.Write("contrastTreshold: " + contrastTreshold);
            Console.WriteLine("\tsigma: " + sigma);
            Console.WriteLine("ratio thresh: " + ratioThresh);

            using (new Window($"SIFT (img1WithPoints)({contrastTreshold})({sigma})({ratioThresh})({listOfGoodBfMatches.Count})", WindowMode.AutoSize, img1WithPoints))
            using (new Window($"SIFT (img2WithPoints)({contrastTreshold})({sigma})({ratioThresh})({listOfGoodBfMatches.Count})", WindowMode.AutoSize, img2WithPoints))
            using (new Window($"SIFT (knnBFMather)({contrastTreshold})({sigma})({ratioThresh})({listOfGoodBfMatches.Count})", WindowMode.AutoSize, knnFlannView2))
            //using (new Window($"SIFT (knnBFMather)({contrastTreshold})({sigma})({ratioThresh})({listOfGoodBfMatches.Count})", WindowMode.AutoSize, knnBfView))
            //using (new Window($"SIFT (BFMather)({contrastTreshold})({sigma})({bfMatches.Length})", WindowMode.AutoSize, bfView))
            //using (new Window($"SIFT (knnFlannBasedMatcher)({contrastTreshold})({sigma})({ratioThresh})({listOfGoodFlannMatches.Count})", WindowMode.AutoSize, knnFlannView))
            //using (new Window($"SIFT (FlannBasedMatcher)({contrastTreshold})({sigma})({flannMatches.Length})", WindowMode.AutoSize, flannView))
            {

            }
        }
    }
}
