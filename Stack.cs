namespace SchoolCollections
{
    public class Stack<T> 
    {
        private Node<T> head;
        
        public Stack()
        {
            this.head = null;
        }
        
        public void Push(T x)
        {
            Node<T> temp = new Node<T>(x);
            temp.SetNext(this.head);
            this.head = temp;
        }
        
        public T Pop()
        {
            T x = this.head.GetValue();
            this.head = this.head.GetNext();
            return x;
        }
        
        public T Top()
        {
            return this.head.GetValue();
        }
        
        public bool IsEmpty()
        {
            return this.head == null;
        }
        
        public override string ToString()
        {
            if (this.IsEmpty()) return "[]";
            Stack<T> temp = new Stack<T>();
            
            while(!this.IsEmpty())
            {
                temp.Push(this.Pop());
            }
            
            string s = "[";
            while(!temp.IsEmpty())
            {
                if (!temp.IsEmpty())
                {
                    s = s + temp.Top() + ", ";
                    this.Push(temp.Pop());
                }
            }
            
            s = s.Substring(0, s.Length - 2) + "]";
            return s;
        }
    }
}