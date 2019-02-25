using System;

namespace PadawansTask11
{
    public static class ArrayExtensions
    {
        public static int? FindIndex(double[] array, double accuracy)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (array.Length == 0)
                throw new ArgumentException();
            if (accuracy <= 0 || accuracy >= 1)
                throw new ArgumentOutOfRangeException();
            for (int i = 1; i < array.Length; i++)
            {
                double leftSum = 0;
                double rightSum = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    leftSum += array[j];
                }
                for (int k = i + 1; k < array.Length; k++)
                {
                    rightSum += array[k];
                }
                if (Math.Abs(leftSum - rightSum) < accuracy)
                {
                    return i;
                }
            }
            return null;
        }
    }
}
