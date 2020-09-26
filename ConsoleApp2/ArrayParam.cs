namespace ConsoleApp2
{
    public class ArrayParam
    {
        public static double GetAverage(int[] arr, int size){
            double avg;
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            avg = (double)sum / size;
            return avg;
        }
    }
}