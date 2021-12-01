namespace Tasks.Easy.RemoveElement
{
    public static class RemoveElement
    {
        public static int RemoveElementMethod(int[] nums, int val)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[j] = nums[i];
                    j++;
                }
            }

            return j;
        }
    }
}
