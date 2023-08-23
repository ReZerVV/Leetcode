namespace Leetcode.Solutions;

/*
    You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, 
    representing the number of elements in nums1 and nums2 respectively.
    
    Merge nums1 and nums2 into a single array sorted in non-decreasing order.
    
    The final sorted array should not be returned by the function, but instead be stored inside the array nums1.
    To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged,
    and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
 */

public static class MergeSortedArray
{
    public static void Solution(int[] nums1, int m, int[] nums2, int n)
    {
        Array.Copy(nums2, 0, nums1, m, n);
        Sort(nums1, 0, n + m - 1);
    }

    private static void Merge(int[] arr, int l, int m, int r)
    {
        int leftSubarrSize = m + 1 - l,
            rightSubarrSize = r - m;
        
        int[] leftSubarr = new int[leftSubarrSize], 
              rightSubarr = new int[rightSubarrSize];
        
        Array.Copy(arr, l, leftSubarr, 0, leftSubarrSize);
        Array.Copy(arr, m + 1, rightSubarr, 0, rightSubarrSize);
        
        int leftSubarrIndex = 0,
            rightSubarrIndex = 0,
            arrIndex = l;
        
        while (leftSubarrIndex < leftSubarrSize && rightSubarrIndex < rightSubarrSize)
        {
            if (leftSubarr[leftSubarrIndex] < rightSubarr[rightSubarrIndex])
            {
                arr[arrIndex] = leftSubarr[leftSubarrIndex];
                leftSubarrIndex++;
            }
            else
            {
                arr[arrIndex] = rightSubarr[rightSubarrIndex];
                rightSubarrIndex++;
            }

            arrIndex++;
        }

        if (leftSubarrIndex < leftSubarrSize)
        {
            Array.Copy(leftSubarr, leftSubarrIndex, arr, arrIndex, leftSubarrSize - leftSubarrIndex );
        }
        
        if (rightSubarrIndex < rightSubarrSize)
        {
            Array.Copy(rightSubarr, rightSubarrIndex, arr, arrIndex, rightSubarrSize - rightSubarrIndex);
        }
    }

    private static void Sort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            int m = l + (r - l) / 2;
            
            Sort(arr, l, m);
            Sort(arr, m + 1, r);
            
            Merge(arr, l, m, r);
        }
    }
}