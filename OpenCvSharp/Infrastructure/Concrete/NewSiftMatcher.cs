using OpenCvSharp.Infrastructure.Abstract;
using OpenCvSharp.Infrastructure.Const;
using OpenCvSharp.XFeatures2D;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenCvSharp.Infrastructure.Concrete
{
    public class NewSiftMatcher : ISiftMatcher
    {
        public void Execute(double contrastTreshold = 0.04, double sigma = 1.6, double ratioThresh = 0.8)
        {
            Mat gray1 = GetGrayImage(FilePath.Image.Gesture1);
            Mat gray2 = GetGrayImage(FilePath.Image.Gesture2);

            SIFT sift = SIFT.Create(0, 3, contrastTreshold, 10, sigma);

            // Detect the keypoints and generate their descriptors using SIFT
            KeyPoint[] keypoints1, keypoints2;
            MatOfFloat descriptors1 = new MatOfFloat();
            MatOfFloat descriptors2 = new MatOfFloat();
            sift.DetectAndCompute(gray1, null, out keypoints1, descriptors1);
            sift.DetectAndCompute(gray2, null, out keypoints2, descriptors2);

            // Match descriptor vectors
            BFMatcher bfMatcher = new BFMatcher(NormTypes.L2, false);
            DMatch[][] knnBfMatches = bfMatcher.KnnMatch(descriptors1, descriptors2, 2);
            DMatch[] bfMatches = bfMatcher.Match(descriptors1, descriptors2);

            // Apply ratio test
            DMatch[] knnMatchesAfterApplyRatioTest = ApplyRatioTest(knnBfMatches, ratioThresh).ToArray();

            // check Y values
            IList<DMatch> searchGoodMatchesList = new List<DMatch>();
            IList<KeyPoint> goodPointsForImg1List = new List<KeyPoint>();
            IList<KeyPoint> goodPointsForImg2List = new List<KeyPoint>();
            IList<DMatch> searchBadMatchesList = new List<DMatch>();
            IList<KeyPoint> badPointsForImg1List = new List<KeyPoint>();
            IList<KeyPoint> badPointsForImg2List = new List<KeyPoint>();
            int goodIndex = 0;
            int badIndex = 0;
            for (int i = 0; i < knnMatchesAfterApplyRatioTest.Length; i++)
            {
                KeyPoint queryPoint = keypoints1[knnMatchesAfterApplyRatioTest[i].QueryIdx];
                KeyPoint trainPoint = keypoints2[knnMatchesAfterApplyRatioTest[i].TrainIdx];

                if (Math.Abs(queryPoint.Pt.Y - trainPoint.Pt.Y) < 1)
                {
                    
                    DMatch temp = knnMatchesAfterApplyRatioTest[i];
                    temp.QueryIdx = goodIndex;
                    temp.TrainIdx = goodIndex;
                    searchGoodMatchesList.Add(temp);
                    goodPointsForImg1List.Add(keypoints1[knnMatchesAfterApplyRatioTest[i].QueryIdx]);
                    goodPointsForImg2List.Add(keypoints2[knnMatchesAfterApplyRatioTest[i].TrainIdx]);
                    goodIndex++;
                }
                else
                {
                    DMatch temp = knnMatchesAfterApplyRatioTest[i];
                    temp.QueryIdx = badIndex;
                    temp.TrainIdx = badIndex;
                    searchBadMatchesList.Add(temp);
                    badPointsForImg1List.Add(keypoints1[knnMatchesAfterApplyRatioTest[i].QueryIdx]);
                    badPointsForImg2List.Add(keypoints2[knnMatchesAfterApplyRatioTest[i].TrainIdx]);
                    badIndex++;
                }
            }

            LogConsoleInfo(keypoints1.Length, keypoints2.Length, descriptors1.Count, descriptors2.Count, bfMatches.Length, knnMatchesAfterApplyRatioTest.Length, contrastTreshold, sigma, ratioThresh);
            LogPointsToConsole(goodPointsForImg1List, "gP1");
            LogPointsToConsole(goodPointsForImg2List, "gP2");

            //DisplayWindow($"Manual, good keyPoints1", PrepareMatToDisplayDrawKeyPoints(gray1, goodPointsForImg1List, Scalar.Green));
            //DisplayWindow($"Manual, good keyPoints2", PrepareMatToDisplayDrawKeyPoints(gray2, goodPointsForImg2List, Scalar.Green));
            DisplayWindow($"Manual, good matches", PrepareMatToDisplayDrawMatches(gray1, gray2, goodPointsForImg1List, goodPointsForImg2List, searchGoodMatchesList, Scalar.Green));
            //DisplayWindow($"Manual, bad keyPoints1", PrepareMatToDisplayDrawKeyPoints(gray1, badPointsForImg1List, Scalar.Red));
            //DisplayWindow($"Manual, bad keyPoints2", PrepareMatToDisplayDrawKeyPoints(gray2, badPointsForImg2List, Scalar.Red));
            DisplayWindow($"Manual, bad matches", PrepareMatToDisplayDrawMatches(gray1, gray2, badPointsForImg1List, badPointsForImg2List, searchBadMatchesList, Scalar.Red));

            //DisplayWindow($"(Match)c:({contrastTreshold})s:({sigma})r:({ratioThresh})m:({listOfGoodBfMatches.Count})", PrepareMatToDisplayDrawMatches(gray1, gray2, keypoints1, keypoints2, listOfGoodBfMatches));
            //DisplayWindow($"(KnnMatch)c:({contrastTreshold})s:({sigma})r:({ratioThresh})m:({bfMatches.Length})", PrepareMatToDisplayDrawMatches(gray1, gray2, keypoints1, keypoints2, bfMatches));


        }

        private Mat GetGrayImage(string imagePath)
        {
            Mat img = new Mat(imagePath, ImreadModes.Color);
            Mat gray = new Mat();
            Cv2.CvtColor(img, gray, ColorConversionCodes.BGR2GRAY);
            return gray;
        }

        private void LogPointsToConsole(IEnumerable<KeyPoint> points, string displayName)
        {
            KeyPoint[] keyPoints = points.ToArray();
            Console.WriteLine($"\n{displayName} points:");
            for (int i = 0; i < keyPoints.Length; i++)
            {
                Console.WriteLine($"{displayName}[{i}]: x:{keyPoints[i].Pt.X}  y:{keyPoints[i].Pt.Y}");
            }
        }

        private void LogConsoleInfo(int numberOfKeyPoints1, int numberOfKeyPoints2, int numberOfDescriptors1, int numberOfDescriptors2, int numberOfBfMatches, 
            int numberOfKnnBfMatches, double contrastTreshold, double sigma, double ratioThresh)
        {
            Console.WriteLine("\nSIFT");
            Console.Write("KeyPoint1: " + numberOfKeyPoints1);
            Console.WriteLine("\tKeyPoint2: " + numberOfKeyPoints2);
            Console.Write("Descriptors1: " + numberOfDescriptors1);
            Console.WriteLine("\tDescriptors2: " + numberOfDescriptors2);
            Console.Write("matches: " + numberOfBfMatches);
            Console.WriteLine("\tknnMatches: " + numberOfKnnBfMatches);
            Console.Write("contrastTreshold: " + contrastTreshold);
            Console.Write("\tsigma: " + sigma);
            Console.WriteLine("\tratio thresh: " + ratioThresh);
        }

        private Mat PrepareMatToDisplayDrawMatches(Mat img1, Mat img2, IEnumerable<KeyPoint> keyPoints1, IEnumerable<KeyPoint> keyPoints2, IEnumerable<DMatch> matches, Scalar? color = null)
        {
            Mat matchesToDisplay = new Mat();
            Cv2.DrawMatches(img1, keyPoints1, img2, keyPoints2, matches, matchesToDisplay, color);
            return matchesToDisplay;
        }

        private Mat PrepareMatToDisplayDrawKeyPoints(Mat img, IEnumerable<KeyPoint> keyPoints, Scalar? color = null)
        {
            Mat keyPointsToDisplay = new Mat();
            Cv2.DrawKeypoints(img, keyPoints, keyPointsToDisplay, color);
            return keyPointsToDisplay;

        }

        private void DisplayWindow(string windowTitle, Mat matToDisplay)
        {
            using (new Window(windowTitle, WindowMode.AutoSize, matToDisplay))
            {

            }
        }

        private IEnumerable<DMatch> ApplyRatioTest(DMatch[][] knnMatches, double ratioThresh)
        {
            IList<DMatch> knnMatchesAfterApplyRatioTest = new List<DMatch>();
            for (int i = 0; i < knnMatches.Length; i++)
            {
                DMatch[] tempMatches = knnMatches[i];
                if (tempMatches.Length > 1)
                {
                    if (tempMatches[0].Distance < ratioThresh * tempMatches[1].Distance)
                    {
                        knnMatchesAfterApplyRatioTest.Add(tempMatches[0]);
                    }
                }
            }
            return knnMatchesAfterApplyRatioTest;
        }
    }
}
