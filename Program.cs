//*****************************************************************************
//** 1310. XOR Queries of a Subarray   leetcode                              **
//*****************************************************************************


/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* xorQueries(int* arr, int arrSize, int** queries, int queriesSize, int* queriesColSize, int* returnSize) {
    // Allocate memory for the result array
    *returnSize = queriesSize;
    int* res = (int*)malloc((*returnSize) * sizeof(int));

    // Modify the input array using XOR
    for(int i = 1; i < arrSize; i++)
    {
        arr[i] ^= arr[i - 1];
    }

    // Process each query
    for(int i = 0; i < queriesSize; i++)
    {
        int start = queries[i][0];
        int end = queries[i][1];

        if(start == 0)
        {
            res[i] = arr[end];
        }
        else
        {
            res[i] = arr[start - 1] ^ arr[end];
        }
    }

    return res;
}