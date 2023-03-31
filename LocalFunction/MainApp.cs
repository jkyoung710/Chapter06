using System;

namespace LocalFunction
{
    class MainApp
    {

        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();
            for (int i =0; i<arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);

                // ToCharArray : 이 인스턴스의 문자를 유니코드 문자배열에 복사합니다
                // 단어를 쪼개서 배열공간에 문자를 한개씩 배정한다.
                // 단어를 쪼개서 문자배열로 만들어 준다..

                // arr 배열에  h e l l o 가 각각 따로따로 들어간다. 

            }

            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90)  // A~Z 의 ASCII 값 : 65~90
                    return arr[i];
                else // a~z 의 ASCII 값 : 97~122
                    return (char)(arr[i] + 32);
            }
            return new string(arr);

        }



        static void Main(string[] args)
        {

            Console.WriteLine(ToLowerString("Hello!"));
            Console.WriteLine(ToLowerString("Good Morning"));
            Console.WriteLine(ToLowerString("This is C#."));

        }
    }
}
