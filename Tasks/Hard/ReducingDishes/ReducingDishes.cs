namespace Tasks.Hard.ReducingDishes
{
    public static class ReducingDishes
    {
        public static int MaxSatisfaction(int[] satisfaction)
        {
            Array.Sort(satisfaction);
            if (satisfaction[^1] < 0)
                return 0;

            int result = 0;
            int total = 0;
            for (int i = satisfaction.Length - 1; i >= 0 && satisfaction[i] > -total; i--)
            {
                total += satisfaction[i];
                result += total;
            }

            return result;
        }
    }
}
