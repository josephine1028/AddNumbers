using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNumbers
{
    class Program
    {
        static void Main()
        {
            // 사용자로부터 두 개의 수 입력 받기
            Console.WriteLine("첫 번째 수를 입력하세요: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("두 번째 수를 입력하세요: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // 두 수를 더하고 결과 출력
            int sum = AddNumbers(num1, num2);
            Console.WriteLine($"두 수의 합: {sum}");
        }

        // 두 수를 더하는 함수
        static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
