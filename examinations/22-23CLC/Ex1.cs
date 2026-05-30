// b this.Close(); : Dùng để đóng Form hiện tại đang được gọi. Nếu đây là Form chính (Form đầu tiên mở lên), 
// toàn bộ ứng dụng cũng sẽ tắt.
using System;
namespace Examinations._22_23CLC
{
    public class Ex1
    {
        public static void Main()
        {
            // d
            // int[,] TwoDArr= new int [3,5];
            int[,] TwoDArr={
                {12,24,32,21,42},
                {99,8,68,32,92},
                {95,34,21,11,7}
            };
            for (int i = 0; i < TwoDArr.GetLength(0); i++)
            {
                for (int j = 0; j < TwoDArr.GetLength(1); j++)
                {
                    Console.Write(TwoDArr[i,j] + " ");
                }
                Console.WriteLine();
            }

            // e
            int[][] JaggedArr = new int[3][];
            JaggedArr[0] = new int[] { 2,4,6};
            JaggedArr[1] = new int[] { 3,5,7,9};
            JaggedArr[2] = new int[] { 5,9,11,17,21};
            for (int i = 0; i < JaggedArr.Length; i++)
            {
                for (int j = 0; j < JaggedArr[i].Length; j++)
                {
                    Console.Write(JaggedArr[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}