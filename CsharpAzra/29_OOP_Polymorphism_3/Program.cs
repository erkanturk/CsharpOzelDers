namespace _29_OOP_Polymorphism_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankaSistem bankaSistem = new BankaSistem();
            bankaSistem.ParaTransfer(1000);
            bankaSistem = new Havale();
            bankaSistem.ParaTransfer(2000);
            bankaSistem = new Eft();
            bankaSistem.ParaTransfer(3000);
            bankaSistem = new Swift();
            bankaSistem.ParaTransfer(4000);
        }
    }
}
