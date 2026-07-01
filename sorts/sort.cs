//multithreaded Rank Sort
namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [23, 69, 72, 41, 55,  6, 57,  3, 65, 37,  4, 48, 74, 27, 18,  9, 51, 76, 66,100, 33, 87, 68, 42, 10, 35, 34,  8, 12, 31, 88, 52, 98, 99, 90,  5, 73, 21, 89, 81, 36,  2,  1, 47, 54, 24, 59, 30, 16, 13, 70, 19, 67, 94, 60, 43, 45, 25, 95, 26, 44, 49, 46, 96, 56,  7, 93, 20, 82, 97, 62, 39, 78, 86, 71, 58, 63, 14, 28, 29, 64, 79, 32, 77, 50, 75, 91, 22, 61, 53, 15, 83, 85, 84, 80, 11, 17, 92, 38, 40];
            int[] ret = new int[100];
            Parallel.ForEach(arr, e1 =>
            {
                int rank = 0;
                foreach (int e2 in arr) if (e1 > e2) rank++;
                ret[rank] = e1;
            });
        }
    }
}

/*
Parallel.ForEach(arr, e1 =>
{
    int i=0;
    //inner foreach initialization overhead costs more than it saves at this scale
    Parallel.ForEach(arr, e2 => { if(e1 > e2) Interlocked.Increment(ref i); });
    lock(ret){ //for concurrent safety; kinda optional
        while (ret[i] != 0) Interlocked.Increment(ref i);
        ret[i] = e1;
    }
});
*/
