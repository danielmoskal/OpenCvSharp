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

            // Draw matches
            var knnBfView = new Mat();
            Cv2.DrawMatches(gray1, keypoints1, gray2, keypoints2, listOfGoodBfMatches.ToArray(), knnBfView);
            var bfView = new Mat();
            Cv2.DrawMatches(gray1, keypoints1, gray2, keypoints2, bfMatches, bfView);

            var knnFlannView = new Mat();
            Cv2.DrawMatches(gray1, keypoints1, gray2, keypoints2, listOfGoodFlannMatches.ToArray(), knnFlannView);
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

            using (new Window($"SIFT (knnBFMather)({contrastTreshold})({sigma})({ratioThresh})({listOfGoodBfMatches.Count})", WindowMode.AutoSize, knnBfView))
            using (new Window($"SIFT (BFMather)({contrastTreshold})({sigma})({bfMatches.Length})", WindowMode.AutoSize, bfView))
            using (new Window($"SIFT (knnFlannBasedMatcher)({contrastTreshold})({sigma})({ratioThresh})({listOfGoodFlannMatches.Count})", WindowMode.AutoSize, knnFlannView))
            using (new Window($"SIFT (FlannBasedMatcher)({contrastTreshold})({sigma})({flannMatches.Length})", WindowMode.AutoSize, flannView))
            {
                
            }
        }
    }
}
