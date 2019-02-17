namespace SchoolCollections
{
   public class Queue<T>
    {
        private Node<T> first;
        private Node<T> last;
        public Queue()
        {
            this.first = null;
            this.last = null;
        }
        public void Insert(T x)
        {
            Node<T> temp = new Node<T>(x);
            if (this.first == null)
                this.first = temp;
            else
                this.last.SetNext(temp);
            this.last = temp;
        }
        public T Remove()
        {
            T x = this.first.GetValue();
            this.first = this.first.GetNext();

            if (this.first == null)
                this.last = null;
            return x;
        }
        public T Head()
        {
            return this.first.GetValue();
        }
        public bool IsEmpty()
        {
            return this.first == null;
        }
        public override string ToString()
        {
            if (this.IsEmpty()) return "[]";
            Queue<T> temp = new Queue<T>();

            while (!this.IsEmpty())
            {
                temp.Insert(this.Remove());
            }

            string s = "[";
            while (!temp.IsEmpty())
            {
                s +=  temp.Head() + ", ";
                this.Insert(temp.Remove());
            }
            s = s.Substring(0, s.Length - 2) + "]";
            return s;
        }
    }
}