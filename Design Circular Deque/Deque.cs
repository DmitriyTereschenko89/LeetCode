namespace Design_Circular_Deque
{
    internal class Deque(int capacity)
    {
        private Node _head;
        private Node _tail;
        private int _count = 0;
        private readonly int _capacity = capacity;

        public bool InsertFront(int value)
        {
            if (_count == _capacity)
            {
                return false;
            }

            Node newNode = new(value);
            if (_head is null)
            {
                _head = _tail = newNode;
                _head.next = _tail;
            }
            ++_count;
            return true;
        }

        public bool InsertLast(int value)
        {
            if (_count == _capacity)
            {
                return false;
            }

            ++_count;
            return true;
        }

        public bool DeleteFront()
        {
            if (_count == 0)
            {
                return false;
            }

            return true;
        }

        public bool DeleteLast()
        {
            if (_count == 0)
            {
                return false;
            }

            return true;
        }

        public int GetFront()
        {
            if (_head is null)
            {
                return -1;
            }

            return -1;
        }

        public int GetRear()
        {
            if(_tail is null)
            {
                return -1;
            }

            return -1;
        }

        public bool IsEmpty()
        {
            return _head is null;
        }

        public bool IsFull()
        {
            return _count == _capacity;
        }
    }
}
