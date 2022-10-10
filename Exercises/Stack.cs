namespace Boxing
{
    public class Stack
    {
        List<object> items;

        public Stack()
        {
            items = new List<object>();
        }

        public void Push(object obj)
        {
            items.Add(obj);
        }
        public object Pop()
        {
            int lastElement = items.Count();
            var returnedObject = items[lastElement];
            items.RemoveAt(lastElement);

            return returnedObject;
        }
        public void Clear()
        {
            items.Clear();
        }
    }
}