namespace Sort_the_Jumbled_Numbers
{
    internal readonly struct Num(int shuffledNum, int originalNum, int originalIdx)
    {
        public readonly int shuffledNum = shuffledNum;
        public readonly int originalNum = originalNum;
        public readonly int originalIdx = originalIdx;
    }
}
