namespace Code_Tasks
{
    public static class UpairedArrayElement
    {
        /// <summary>
        /// Question: Find an element in an odd lenght array that is not paired. 
        /// Solution: Count the occurance of each element in the array, if the element occurs an odd number of times
        /// then it means that there is only one of the element of there is an odd number of the elements,in both cases,
        /// the element has one occurance that is not paired
        /// </summary>
        public static int GetUnpairedElement(int[] A)
        {
            int unpaired = 0;

            foreach (int a in A)
            {
                int count = A.Where(x => x == a).Count();
                if (count % 2 != 0)
                {
                    unpaired = a;
                    break;
                }
            }
            return unpaired;

        }
    }
}
