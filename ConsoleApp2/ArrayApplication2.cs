namespace ConsoleApp2
{
    public class ArrayApplication2
    {
        public int AddElements(params int[] arr){
            int sum = 0;
            foreach (int i in arr){
                sum += i;
            }
            return sum;
        }
    }
}