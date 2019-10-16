using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choose;
            int ketqua;
            
            Console.WriteLine("Nhan phim 1 de gui tien, phim 2 de rut tien, phim 3 kiem tra so du");
            if (int.TryParse(Console.ReadLine(),out choose))
            {
                if ( choose == 1 )
                {
                     Account acc = new Account(200000);
                    
                    Console.WriteLine(" Nhap so tien ban muon gui ");
                    string str = Console.ReadLine();
                    int a = Convert.ToInt32(str);             
                    acc.Deposit(a);
                }
           
                if (choose == 2)
                {
                    Account acc = new Account(200000);

                    Console.WriteLine(" Nhap so tien ban muon rut ");
                    string str = Console.ReadLine();
                    int a = Convert.ToInt32(str);
                    acc.Withdraw(a);
                }
              
                if (choose == 3)
                {

                    Account acc = new Account(200000);
                    acc.Balance();
                }
            }
        }
    }
}
