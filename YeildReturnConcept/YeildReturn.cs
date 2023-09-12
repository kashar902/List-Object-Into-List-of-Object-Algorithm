namespace Algorithms.YeildReturnConcept
{
    public class YeildReturn
    {
        public IEnumerable<int> ProduceEvenNumbers(int nTimes)
        {
            for (int i = 0; i < +nTimes; i += 2)
            {
                yield return i;
            }
        }
    }
}
