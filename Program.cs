using MyNewVM;

class VMTEST
{
    static int Main(string[] args)
    {
        /*
        MyNewVM.VirtualMachine myVM = new MyNewVM.VirtualMachine(new MyNewVM.IVMInstruction[] {
            new MyNewVM.IVMInstruction(MyNewVM.VMOpcodes.ldc, (object)"Hello World!!!"),
            new MyNewVM.IVMInstruction(MyNewVM.VMOpcodes.print,null)
        });
        return myVM.StartVM();*/
        liveinterperter();
        return 0;
    }
    static void liveinterperter()
    {
        MyNewVM.VirtualMachine myVM = new MyNewVM.VirtualMachine(
            new MyNewVM.IVMInstruction[] {
            new MyNewVM.IVMInstruction(MyNewVM.VMOpcodes.ldc, (object)"Hello World!!!"),
            new MyNewVM.IVMInstruction(MyNewVM.VMOpcodes.print,null)
        });
        while (true)
        {
            string inp = Console.ReadLine();
            string strop;
            VMOpcodes ops;
            IVMInstruction instruction;
            string strcde;
            strcde = inp.Split(":")[0];
            try { strop = inp.Split(":")[1]; }
            catch { strop = null; }
            
            switch (strcde)
            {
                case "print":
                    ops = VMOpcodes.print;
                    break;
                case "ldc":
                    ops = VMOpcodes.ldc;
                    break;
                default:
                    ops = VMOpcodes.pop;
                    break;
            }
            instruction = new IVMInstruction(ops, strop);
            myVM.RunInstr(instruction);
        }
    }
}