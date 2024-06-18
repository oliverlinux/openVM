using System;
namespace MyNewVM
{
	public interface IHandler
	{
		public object run(VStack stk, object oper);
	}
}

