namespace Design_Circular_Deque
{
    using System.ComponentModel.DataAnnotations;

    internal class MyCircularDeque
    {
        private int _front = -1;
        private int _rear = 0;
        private readonly int _size;
        private readonly int[] _deque;
        public MyCircularDeque(int k)
        {
            _deque = new int[k];
            _size = k;
        }

        public bool InsertFront(int value)
        {
            if (IsFull())
            {
                return false;
            }

            if (_front == -1)
            {
                _front = _rear = 0;

            }
            else if (_front == 0)
            {
                _front = _size - 1;
            }
            else
            {
                --_front;
            }

            _deque[_front] = value;
            return true;
        }

        public bool InsertLast(int value)
        {
            if (IsFull())
            {
                return false;
            }

            if (_front == -1)
            {
                _front = _rear = 0;
            }
            else if (_rear == _size - 1)
            {
                _rear = 0;
            }
            else
            {
                ++_rear;
            }

            _deque[_rear] = value;
            return true;
        }

        public bool DeleteFront()
        {
            if (IsEmpty())
            {
                return false;
            }

            if (_front == _rear)
            {
                _front = -1;
                _rear = -1;
            }
            else if (_front == _size - 1)
            {
                _front = 0;
            }
            else
            {
                ++_front;
            }

            return true;
        }

        public bool DeleteLast()
        {
            if (IsEmpty())
            {
                return false;
            }

            if (_front == _rear)
            {
                _front = _rear = -1;
            }
            else if (_rear == _size - 1)
            {
                _rear = 0;
            }
            else
            {
                ++_rear;
            }

            return true;
        }

        public int GetFront()
        {
            if (IsEmpty())
            {
                return -1;
            }

            return _deque[_front];
        }

        public int GetRear()
        {
            if (IsEmpty() || _rear < 0)
            {
                return -1;
            }

            return _deque[_rear];
        }

        public bool IsEmpty()
        {
            return _front == -1;
        }

        public bool IsFull()
        {
            return (_front == 0 && _rear == _size - 1) || (_front == _rear + 1);
        }
    }
}
