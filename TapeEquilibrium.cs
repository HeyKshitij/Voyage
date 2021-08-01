using System;

class Solution {

    int[] splitSum ;
    public int solution(int[] A) {
    
        splitSum = new int[A.Length];
        var overallSum = Sum(A,A.Length);
        
        int min = int.MaxValue;
        for(int i=1;i<splitSum.Length; i++)
        {
            // find the minimum value
            var diff = Math.Abs(overallSum - 2* splitSum[i]);
            if(min> diff) min = diff;
            //Console.WriteLine(diff);
            //Console.WriteLine(splitSum[i]);
        }
        return min;
    }
    
    // sum of the numbers using recursion
    int Sum(int[] input, int length)
    {
        var localSum = input[input.Length - length];
        splitSum[input.Length - length] = localSum;
        if(length == 1) return localSum;

        var allSum = localSum + Sum(input, length-1);
        splitSum[input.Length - length] =allSum;
        return allSum;
    }
}
