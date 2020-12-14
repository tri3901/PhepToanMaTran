using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhepToan_MaTran_v1
{
    public class MaTran
    {
        int[,] array;
        int rows, cols;

        #region Properties
        public int[,] Array
        {
            get { return array; }
            set { array = value; }
        }

        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        public int Cols
        {
            get { return cols; }
            set { cols = value; }
        }
        #endregion

        #region Construtor
        public MaTran()
        {
        }
        #endregion

        public void TaoMaTran()
        {
            do
            {
                Console.Write("Nhap so dong: ");
                rows = int.Parse(Console.ReadLine());
                Console.Write("Nhap so cot: ");
                cols = int.Parse(Console.ReadLine());
            } while (rows < 0 || cols < 0); 

            array = new int[rows, cols];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("Phan tu ma tran [{0}, {1}]: ", i, j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void XuatMaTran()
        {
            Console.WriteLine("Ma tran: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("\t" + array[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void PhepCong(MaTran a, MaTran b)    
        {
            int[,] tmp1 = a.Array;
            int[,] tmp2 = b.Array;    
        
            if (a.rows == b.rows && a.cols == b.cols)
            {
                int[,] tmp = new int[a.rows, a.cols];
                for (int i = 0; i < a.rows; i++)
                {
                    for (int j = 0; j < a.cols; j++)
                    {
                        tmp[i, j] = tmp1[i, j] + tmp2[i, j];
                    }
                }

                Console.WriteLine("Ma tran ket qua phep cong: ");
                for (int i = 0; i < tmp.GetLength(0); i++)
                {
                    for (int j = 0; j < tmp.GetLength(1); j++)
                    {
                        Console.Write("\t" + tmp[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Hai ma tran khong dong cap, khong the cong!");
            }
        }

        public void PhepTru(MaTran a, MaTran b)
        {
            int[,] tmp1 = a.Array;
            int[,] tmp2 = b.Array;

            if (a.rows == b.rows && a.cols == b.cols) //Kiem tra dong cap ma tran
            {
                int[,] tmp = new int[a.rows, a.cols];
                for (int i = 0; i < a.rows; i++)
                {
                    for (int j = 0; j < a.cols; j++)
                    {
                        tmp[i, j] = tmp1[i, j] - tmp2[i, j];
                    }
                }

                Console.WriteLine("Ma tran ket qua phep tru: ");
                for (int i = 0; i < tmp.GetLength(0); i++)
                {
                    for (int j = 0; j < tmp.GetLength(1); j++)
                    {
                        Console.Write("\t" + tmp[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Hai ma tran khong dong cap, khong the tru!");
            }
        }

        public void PhepNhan(MaTran a, MaTran b)
        {
            int[,] tmp1 = a.Array;
            int[,] tmp2 = b.Array;

            if (a.cols == b.rows) 
            {
                int[,] tmp = new int[a.rows, b.cols];
                for (int i = 0; i < a.rows; i++)
                {
                    for (int j = 0; j < b.cols; j++) 
                    {
                        for (int k = 0; k < b.rows; k++)
                        {
                            tmp[i, j] += tmp1[i, k] * tmp2[k, j];
                        }
                    }
                }

                Console.WriteLine("Ma tran ket qua phep nhan: ");
                for (int i = 0; i < tmp.GetLength(0); i++)
                {
                    for (int j = 0; j < tmp.GetLength(1); j++)
                    {
                        Console.Write("\t" + tmp[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Hai ma tran khong thoa dieu kien, khong the nhan!");
            }
        }

        //public void NghichDao(MaTran a)
        //{
        //    for (int i = 0; i < a.rows; i++)
        //    {
        //        for (int j = 0; j < a.cols; j++)
        //        {
        //            Swap(a[i, j], a[i, j]);
        //        }
        //    }
        //}

        public static void Swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        } 

        public void DinhThuc(MaTran a)
        {
            int[,] tmp = a.Array;
            int n = a.rows;

            if (a.rows == a.cols)
            {
                Console.WriteLine("Dinh thuc cua ma tran: {0}", TinhDinhThuc(tmp, n));
            }
            else
            {
                Console.WriteLine("Khong phai ma tran vuong, khong the tinh dinh thuc!");
            }
        }

        //public int TinhDinhThuc1(int[,] maTran, int n)
        //{
        //    int tong = 0;
        //    int flag;
        //    int[,] tmp = new int[n, n];

        //    if (n == 2)
        //    {
        //        return tong = (maTran[0, 0] * maTran[1, 1]) - (maTran[0, 1] * maTran[1, 0]);
        //    }
        //    else
        //    {
        //        for (int k = 0; k < n; k++)
        //        {
        //            for (int i = 0; i < n; i++) //dong
        //            {
        //                for (int j = 1; j < n; j++) //tinh dinh thuc theo cot, bo cot 0 (1 trong thuc te)
        //                {
        //                    if (i < k)
        //                    {
        //                        tmp[i, j - 1] = maTran[i, j];
        //                    }
        //                    else if (i > k)
        //                    {
        //                        tmp[i - 1, j - 1] = maTran[i, j];
        //                    }
        //                }
        //                if (k % 2 == 0)
        //                {
        //                    flag = 1;
        //                }
        //                else
        //                {
        //                    flag = -1;
        //                }

        //                tong += maTran[k, 0] * flag * TinhDinhThuc1(tmp, n - 1);
        //            }
        //        }
        //    }
        //    return tong;
        //}

        public int TinhDinhThuc(int[,] maTran, int n)
        {
            int tong = 0;
            int flag;
            int[,] tmp = new int[n, n];

            if (n == 2)
            {
                return tong = (maTran[0, 0] * maTran[1, 1]) - (maTran[1, 0] * maTran[0, 1]);
            }
            else
            {
                for (int k = 0; k < n; k++)
                {
                    int tmpRow = 0;
                    for (int i = 1; i < n; i++)
                    {
                        int tmpCol = 0;
                        for (int j = 0; j < n; j++)
                        {
                            if (j == k)
                            {
                                continue;
                            }
                            tmp[tmpRow, tmpCol] = maTran[i, j];
                            tmpCol++;
                        }
                        tmpRow++;
                    }
                    if (k % 2 == 0)
                    {
                        flag = 1;
                    }
                    else
                    {
                        flag = -1;
                    }

                    tong += flag * maTran[0, k] * TinhDinhThuc(tmp, n - 1);
                }
            }
            return tong;
        }
    }
}
