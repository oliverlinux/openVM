using System;
namespace MyNewVM
{
	public class IVMInstruction
	{
		public VMOpcodes operation;
		public object operand;
		public IVMInstruction(VMOpcodes op, object operandd)
		{
			operand = operandd;
			operation = op;
		}
	}
}

