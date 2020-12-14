using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhepToan_MaTran_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            MaTran mt1 = new MaTran();
            MaTran mt2 = new MaTran();
            do
            {
                Console.WriteLine("========================\n0. Thoat chuong trinh\n1. Khoi tao 2 ma tran\n2. Phep cong ma tran\n3. Phep tru ma tran\n4. Phep nhan ma tran\n5. Dinh thuc cua ma tran\n========================");
                Console.Write("Nhap lua chon: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("1. Khoi tao 2 ma tran\n");
                            mt1.TaoMaTran();
                            mt1.XuatMaTran();

                            Console.WriteLine();

                            mt2.TaoMaTran();
                            mt2.XuatMaTran();

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("2. Phep cong ma tran");
                            MaTran mt3 = new MaTran();
                            mt3.PhepCong(mt1, mt2);

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("3. Phep tru ma tran\n");
                            MaTran mt4 = new MaTran();
                            mt4.PhepTru(mt1, mt2);

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("4. Phep nhan ma tran\n");
                            MaTran mt5 = new MaTran();
                            mt5.PhepNhan(mt1, mt2);

                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("5. Dinh thuc cua ma tran\n");
                            MaTran mt6 = new MaTran();
                            mt6.TaoMaTran();
                            mt6.XuatMaTran();

                            mt6.DinhThuc(mt6);

                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Thoat chuong trinh!");
                            break;
                        }
                    default: Console.WriteLine("Khong ton tai lua chon nay!");
                        break;
                }
            } while (choice != 0);
            Console.ReadLine();
        }
    }
}
