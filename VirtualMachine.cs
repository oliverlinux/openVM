using System;
namespace MyNewVM
{
	public class VirtualMachine
	{
		IVMInstruction[] instrs;
		IHandler[] handlers = new IHandler[] {new LDC(),new print() };
        VStack vmStack = new VStack();
        public VirtualMachine(IVMInstruction[] instrsa)
		{
			
			instrs = instrsa;
			
		}
		public int StartVM()
		{
			foreach (IVMInstruction instr in instrs)
			{
				switch (instr.operation)
				{
					case VMOpcodes.ldc:
						handlers[0].run(vmStack, instr.operand);
						break;
					case VMOpcodes.print:
						handlers[1].run(vmStack, instr.operand);
						break;
                }
				
			}
			return 0;
		}
		public void RunInstr(IVMInstruction instr)
		{
            switch (instr.operation)
            {
                case VMOpcodes.ldc:
                    handlers[0].run(vmStack, instr.operand);
                    break;
                case VMOpcodes.print:
                    handlers[1].run(vmStack, instr.operand);
                    break;
            }
        }

	}
}

