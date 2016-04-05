using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        bool started = false;
        int gap = 0;
        int highscore = 0;
        string binary = Convert.ToString(N, 2);
        
        for (int i = 0; i < binary.Length; i++)
        { 
            if ((char) binary[i] == (char) '1'){
                started = true;  
            }
            if ((char) binary[i] == (char) '0' && started == true){
                gap++;
            }
            if ((char) binary[i] == (char) '1' && started == true){
                if (gap >= highscore)
                {
                    highscore = gap;
                    gap = 0;
                }
            }   
        }
        return(highscore);    
    }
}