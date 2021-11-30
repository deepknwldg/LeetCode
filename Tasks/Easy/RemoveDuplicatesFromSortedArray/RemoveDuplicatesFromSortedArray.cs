namespace Tasks.Easy.RemoveDuplicatesFromSortedArray
{
    public static class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] != nums[j])
                {
                    nums[i++ + 1] = nums[j];
                }
            }

            ++i;

            return i;
        }
    }
}
