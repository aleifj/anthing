using System.Formats.Asn1;
using System.Text;
using Myevan;
using aleifj;

internal class Program
{
    private static void Main(string[] args)
    {
        
        //int n = new int{1, 3, 5, 7};
        int[] inv2 = new int[]{89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99};
        //int num1 = 15, num2 = 99;
        //var strl = new string[]{"I", "Love", "Programmers."};
        //string rsp = "0,2,5";
        //string answer = Programmers.Solution0802("0");
        //Console.WriteLine(answer);
        
        
        //Utils.PrintIntArray(answer);//뜻: Utils 안에있는 PrintIntArray를 쓴다.

        //nullable이란 null을 담을 수 없는 int, time의 타입이 null을 담을 수 있게 만든다
        int? i = null;//int타입에 ?삽입.
    }
    static void WhileSample()
    {
        int ai = 0;
        while (ai < 10)
        {
            ai++;
        }
        //Console.WriteLine(ai);

        ai = 5;
        for (var i = 10; i > 0; i--)
        {
            ai++;
        }

        // ===> while
        ai = 5;
        int ii = 10;
        while (ii > 0)
        {
            ai++;
            ii--;
        }
        Console.WriteLine(ai);
    }
    static void csSwitch()
    {
        // switch문은 if문으로 바꿀 수 있다
        int ia = 0;
        // ia값 (0<ia<100) 중 1,2,3 값만 출력하는 switch문
        switch (ia)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine(ia);
                break;
            default:
                break;
        }

        ia = 1;
        // switch에는 1일때 상황이 있지만 if문에는 없어서 결과가 다르다 
        Console.WriteLine(switchSample(ia));
        Console.WriteLine(ifSample(ia));
    }

    static int switchSample(int ia)
    {
        int answer = 0;
        switch (ia)
        {
            case 0: 
                answer += 1; 
                break;
            case 1: // 1일 때 아무것도 안하고 break...default문도 거치지 않는다
                break;            
            case 2: 
                answer--;    
                break;

            default:
                answer = answer + 2;
                break;
        }
        return answer;
    }

    static int ifSample(int ia)
    {
        int answer = 0;
        if (ia == 0)
            answer += 1;
        else if (ia == 2)
            answer--;
        else
        {
            // ia가 1일때 상황을 코딩하지 않았으므로 1일때 여기로 들어온다
            answer = answer + 2;
        }
        return answer;
    }
}