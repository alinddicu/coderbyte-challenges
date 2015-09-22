namespace CoderbyteChallenges.Tools
{
    using System.Collections.Generic;

    public class CircularArray<T>
    {
        private readonly List<T> _list;

        public CircularArray(params T[] array)
        {
            _list = new List<T>(array);
        }

        public T this[int index]
        {
            get
            {
                return _list[index % _list.Count];
            }
            set
            {
                _list[index] = value;
            }
        }

        public int FirstIndexOf(T item)
        {
            return _list.IndexOf(item);
        }
    }
}
