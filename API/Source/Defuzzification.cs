using System.Collections.Generic; 

namespace FuzzyModules.Api
{
    public class Defuzzification
    {
        private double[] MfDegree; 

        public Defuzzification(double[] mfDegree)
        {
            MfDegree = mfDegree; 
        }

        public double MeanOfMaximum()
        {
            double max = FindMaxValue(); 

            List<int> indexesMax = new List<int>(); 
            for (int i = 0; i < MfDegree.Length; i++)
            {
                if (MfDegree[i] == max)
                {
                    indexesMax.Add(i); 
                }
            }

            double sum = 0; 
            foreach (int index in indexesMax)
            {
                sum += index; 
            }

            return sum / indexesMax.Count; 
        }

        public double FirstOfMaximum()
        {
            return 0; 
        }

        public double LastOfMaximum()
        {
            return 0; 
        }

        public double Centroid()
        {
            return 0; 
        }

        public double Bisector()
        {
            return 0; 
        }

        private double FindMaxValue()
        {
            double max = 0; 
            for (int i = 0; i < MfDegree.Length; i++)
            {
                if (max < MfDegree[i])
                {
                    max = MfDegree[i]; 
                }
            }
            return max; 
        }
    }
}