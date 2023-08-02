namespace CSharp8
{
    public class Validator
    {
        public bool IsValid(Char[] chars)
        {
             // ( { [ ] } )
            // {[}]
            CustomStack<Char> stack = new CustomStack<Char>();
            char topOfStack = '0';
            for (int i = 0; i < chars.Length; i++)
            {
                if (stack.HasItem() == true)
                    topOfStack = stack.Peek();

                if ((chars[i] == ')' && topOfStack == '(')
                    || (chars[i] == '}' && topOfStack == '{')
                    || (chars[i] == ']' && topOfStack == '['))
                    stack.Pop();
                else
                    stack.Push(chars[i]);
            }

            if (stack.HasItem())
                return false;
            else
                return true;
        }
    }



}