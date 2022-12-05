class Solution {

    //less efficient method
    public static void miniMaxSum(List<int> arr)
    {
        //sort array
        arr.Sort();
        long minTot = 0;
        long maxTot = 0;
        
        // calc totals for min and maximum values
        for(int i = 0; i < arr.Count; i++) {
            if (i != arr.Count-1) minTot += arr[i];
            if (i != 0) maxTot += arr[i];
        }
        Console.WriteLine(minTot + " " + maxTot);
    }


    public static void miniMaxSum2(List<int> arr)
    {
        int minVal = Int32.MaxVal;
        int maxVal = 0;

        long tot = 0;
        
        // calc total and finds min and max vals
        for(int i = 0; i < arr.Count; i++) {
            if (arr[i] < minVal) minVal = arr[i];
            if (arr[i] > maxVal) maxVal = arr[i];
          tot += arr[i];
        } 

        Console.WriteLine(tot - maxVal + " " + tot - minVal);
    }
      public static void miniMaxSum3(List<int> arr)
    {
        int minVal = arr.Min();
        int maxVal = arr.Max();

        long tot = 0;
        
        // calc total and finds min and max vals
        for(int i = 0; i < arr.Count; i++) {
          tot += arr[i];
        } 

        Console.WriteLine(tot - maxVal + " " + tot - minVal);
    }
}