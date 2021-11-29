﻿namespace Tasks.Easy.MergeTwoSortedLists
{
    public static class MergeTwoSortedLists
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;


            if (list2.val > list1.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);

                return list1;
            }

            list2.next = MergeTwoLists(list1, list2.next);
            return list2;
        }
    }
}
