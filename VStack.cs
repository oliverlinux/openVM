using System;
namespace MyNewVM
{
	public class VStack
	{
		object[] stkdata = new object[999];
		int current = 0;
		public VStack(VStack initstack)
		{
			this.stkdata = initstack.stkdata;
		}
        public VStack()
        {

        }
		public object Pop()
		{
			current = current - 1;
			return stkdata[current+1];
			
		}
		public void Push(object data)
		{
			current = current + 1;
			stkdata[current] = data;
		}
		public object Peek()
		{
			return stkdata[current];
		}

    }
}

