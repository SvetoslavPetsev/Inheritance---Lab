namespace CustomStack
{
    using System.Collections.Generic;

    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }

        public void AddRange(Stack<string> stakToAdd)
        {
            foreach (var element in stakToAdd)
            {
                this.Push(element);
            }
        }
    }
}
