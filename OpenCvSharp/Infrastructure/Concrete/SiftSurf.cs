using OpenCvSharp.Infrastructure.Abstract;
using OpenCvSharp.Infrastructure.Const;
using OpenCvSharp.XFeatures2D;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCvSharp.Infrastructure.Concrete
{
    public class SiftSurf : IFeatures
    {
        public void Execute()
        {
            var src1 = new Mat(FilePath.Image.Gesture1, ImreadModes.Color);
            var src2 = new Mat(FilePath.Image.Gesture2, ImreadModes.Color);

            MatchBySift(src1, src2);
            MatchBySurf(src1, src2);
        }

        private void MatchBySift(Mat src1, Mat src2)
        {
            var gray1 = new Mat();

            var gray2 = new Mat();

            Cv2.CvtColor(src1, gray1, ColorConversionCodes.BGR2GRAY);
            Cv2.CvtColor(src2, gray2, ColorConversionCodes.BGR2GRAY);

            var sift = SIFT.Create(0, 3, 0.03, 10, 1.5);

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
            float ratioThresh = 0.6f;
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
            Console.WriteLine("KeyPoint1: " + keypoints1.ToList().Count);
            Console.WriteLine("KeyPoint2: " + keypoints2.ToList().Count);
            Console.WriteLine("Descriptors1: " + descriptors1.ToList().Count);
            Console.WriteLine("Descriptors2: " + descriptors2.ToList().Count);
            Console.WriteLine("bfMatches: " + bfMatches.ToList().Count);
            Console.WriteLine("knnBfMatches: " + listOfGoodBfMatches.Count);
            Console.WriteLine("flannMatches: " + flannMatches.ToList().Count);
            Console.WriteLine("knnFlannMatches: " + listOfGoodFlannMatches.Count);

            using (new Window("SIFT matching (by knnBFMather)", WindowMode.AutoSize, knnBfView))
            using (new Window("SIFT matching (by BFMather)", WindowMode.AutoSize, bfView))
            using (new Window("SIFT matching (by knnFlannBasedMatcher)", WindowMode.AutoSize, knnFlannView))
            using (new Window("SIFT matching (by FlannBasedMatcher)", WindowMode.AutoSize, flannView))
            {

            }
        }

        private void MatchBySurf(Mat src1, Mat src2)
        {
            var gray1 = new Mat();
            var gray2 = new Mat();

            Cv2.CvtColor(src1, gray1, ColorConversionCodes.BGR2GRAY);
            Cv2.CvtColor(src2, gray2, ColorConversionCodes.BGR2GRAY);

            var surf = SURF.Create(200, 4, 2, true);

            // Detect the keypoints and generate their descriptors using SURF
            KeyPoint[] keypoints1, keypoints2;
            var descriptors1 = new MatOfFloat();
            var descriptors2 = new MatOfFloat();
            surf.DetectAndCompute(gray1, null, out keypoints1, descriptors1);
            surf.DetectAndCompute(gray2, null, out keypoints2, descriptors2);

            // Match descriptor vectors 
            var bfMatcher = new BFMatcher(NormTypes.L2, false);
            var flannMatcher = new FlannBasedMatcher();
            DMatch[] bfMatches = bfMatcher.Match(descriptors1, descriptors2);
            DMatch[] flannMatches = flannMatcher.Match(descriptors1, descriptors2);

            // Draw matches
            var bfView = new Mat();
            Cv2.DrawMatches(gray1, keypoints1, gray2, keypoints2, bfMatches, bfView);
            var flannView = new Mat();
            Cv2.DrawMatches(gray1, keypoints1, gray2, keypoints2, flannMatches, flannView);

            Console.WriteLine("SURF");
            Console.WriteLine("KeyPoint1: " + keypoints1.ToList().Count);
            Console.WriteLine("KeyPoint2: " + keypoints2.ToList().Count);
            Console.WriteLine("Descriptors1: " + descriptors1.ToList().Count);
            Console.WriteLine("Descriptors2: " + descriptors2.ToList().Count);
            Console.WriteLine("bfMatches: " + bfMatches.ToList().Count);
            Console.WriteLine("flannMatches: " + flannMatches.ToList().Count);

            using (new Window("SURF matching (by BFMather)", WindowMode.AutoSize, bfView))
            using (new Window("SURF matching (by FlannBasedMatcher)", WindowMode.AutoSize, flannView))
            {
                Cv2.WaitKey();
            }
        }
    }
}
