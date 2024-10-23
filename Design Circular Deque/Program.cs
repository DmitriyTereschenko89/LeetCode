using Design_Circular_Deque;


MyCircularDeque myCircularDeque = new MyCircularDeque(3);
Console.WriteLine(myCircularDeque.InsertLast(1));  // return True
Console.WriteLine(myCircularDeque.InsertLast(2));  // return True
Console.WriteLine(myCircularDeque.InsertFront(3)); // return True
Console.WriteLine(myCircularDeque.InsertFront(4)); // return False, the queue is full.
Console.WriteLine(myCircularDeque.GetRear());      // return 2
Console.WriteLine(myCircularDeque.IsFull());       // return True
Console.WriteLine(myCircularDeque.DeleteLast());   // return True
Console.WriteLine(myCircularDeque.InsertFront(4)); // return True
Console.WriteLine(myCircularDeque.GetFront());     // return 4
