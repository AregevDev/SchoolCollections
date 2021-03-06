namespace SchoolCollections
{
    public class IntNode
    {
        private int value;
        private IntNode next;

        public IntNode(int value)
        {
            this.value = value;
            this.next = null;
        }
        
        public IntNode(int value, IntNode next)
        {
            this.value = value;
            this.next = next;
        }

        public int GetValue()
        {
            return value;
        }

        public IntNode GetNext()
        {
            return next;
        }

        public bool HasNext()
        {
            return this.next != null;
        }

        public void SetValue(int value)
        {
            this.value = value;
        }
        
        public void SetNext(IntNode next)
        {
            this.next = next;
        }

        public override string ToString()
        {
            return this.value + " ---> " + this.next;
        }
    }
}