using System;
namespace MyNewVM
{
	public class LDC : IHandler
	{
		public LDC()
		{

		}
		public object run(VStack stk, object oper)
		{
			stk.Push(oper);
			return null;
		}
	}
}

