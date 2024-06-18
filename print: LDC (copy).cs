using System;
namespace MyNewVM
{
	public class print : IHandler
	{
		public print()
		{

		}
		public object run(VStack stk, object oper)
		{
			Console.WriteLine(stk.Pop());
			return null;
		}
	}
}

