
/*

Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 

Constraints:

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lower-case English letters.


 */

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        // Approach 1
        
        string lcp="";
        
        //Base case: 
        if (strs.Length==1){
            return strs[0];
        }
        
        
        // Loop to Compare adjacent words for common prefix
        for (int i=0; i < strs.Length-1; i++)
        {
            string temp = LCP(strs[i], strs[i+1]);
            
            //If any two words don't have a common prefix, then return
            if (temp.Length==0){
                return "";
            }
            
            //Retain the smallest common prefix
            if (temp.Length < lcp.Length || lcp=="")
            {
                lcp = temp;
            }
            
            
        }
        return lcp;
        
    }
    
    // Function to calculate comman prefix of two words.
    public string LCP(string s1, string s2) {
        string lcp="";
        int i=0;
        
        while( i< s1.Length && i< s2.Length && s1[i]==s2[i] )
        {
            lcp+=s1[i];
            i++;
        }
        
        return lcp;
        
    }
}

/* 
Runtime Compexity: O(S) where S is the sum of all characters of all strings in the array. 
Worst case: When all strings in the array are same. In this case, runtime will be O(n * m) where n is number of strings in the array. 
And m is the length of each string. 
Best Case: All string begin with a different character, in which case runtime will be O(n*1)


Space Complexity: O(1) as we are not using any additional memory
 */