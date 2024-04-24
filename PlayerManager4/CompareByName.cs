using System;
using System.Collections.Generic;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        private bool _ascending;

        public CompareByName(bool ascending)
        {
            _ascending = ascending;
        }

        public static CompareByName AscendingByName { get { return new CompareByName(true); } }
        public static CompareByName DescendingByName { get { return new CompareByName(false); } }
        public static CompareByName DescendingByScore { get { return new CompareByName(false); } }

        public int Compare(Player x, Player y)
        {
            if (_ascending)
            {
                return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
            }
            else
            {
                return string.Compare(y.Name, x.Name, StringComparison.Ordinal);
            }
        }
    }
}