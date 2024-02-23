using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNumbers
{
    class Calculator
    {
        static void Main()
        {
            try
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
            catch (FormatException)
            {
                Console.WriteLine("잘못된 입력 형식입니다. 프로그램을 종료합니다.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("입력한 값이 너무 큽니다. 프로그램을 종료합니다.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"오류 발생: {ex.Message}");
            }
        }

        // 두 수를 더하는 함수
        static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}