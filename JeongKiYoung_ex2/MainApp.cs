using System;

namespace JeongKiYoung_ex2
{
    class MainApp
    {

        


        static void Main(string[] args)
        {


            double mean = 0;  // mean 의 값을 초기화 해주었다. 

            Mean(1, 2, 3, 4, 5,ref mean);  //  Mean 함수를 발동한다. .

            Console.WriteLine("평균 : {0}", mean);

        }

        public static void Mean(double a, double b, double c, double d, double e, ref double mean)
        {

            mean = (a + b + c + d + e) / 5;

        }

        // 
        // Mean 메서드내부에서 ref를 선언하지 않았을때
        // mean 은 참조형식이 아닌 값이 복사되서 대입된다.
        // 복사된 mean 은 0으로 초기화 되었기 때문에 스택에 쌓이게 된다.
        // 메서드 내부에서는 또다른 mean 은 3의 값을 갖지만 호출자에게 다가가지 못한다..
        // 이 문제를 해결하려면 Mean 메서드에 ref 를 매개변수 double mean 앞에 선언해 주고
        // 메서드를 발동 시킬 때도 ref mean 을 선언해서 작성해줘야 한다. .

    }
}
