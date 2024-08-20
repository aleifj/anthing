using System.Formats.Asn1;
using System.Text;
using Myevan;
using aleifj;
using System.Globalization;
using System.Runtime.CompilerServices;

internal class Program
{
    public struct Scustomer
    {//struct는 상속 불가
        public string name;
        public int age;
        public string GetCData()
        {
            string data = $"{name}, {age}";
            return data;
        }
    }
    public class Ccustomer
    {//class는 상속 가능
        public string name;
        public int age;
        public string GetSData()
        {
            string data = $"{name}, {age}";
            return data;
        }
        
    }
    private static void Main(string[] args)
    {
        /*Scustomer sc;
        sc.name = "Lee";
        sc.age = 30;
        Console.WriteLine(sc.GetCData());

        Ccustomer cc = new Ccustomer();
        cc.name = "Kim";
        cc.age = 26;
        Console.WriteLine(cc.GetSData());*/

        //int[] numLog = new int[]{0, 1, 0, 10, 0, 1, 0, 10, 0, -1, -2, -1};
        int a = 2;
        int b = 91;
        int answer = Programmers.Solution0820(a, b);
        Console.WriteLine(answer);
        //Utils.PrintIntArray(answer);//뜻: Utils 안에있는 PrintIntArray를 쓴다.
        //CSharpStudy.DicSample();

        //nullable이란 null을 담을 수 없는 int, time의 타입이 null을 담을 수 있게 만든다
        //int? i = null;//int타입에 ?삽입.
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

        //=> while
        ai = 5;
        int ii = 10;
        while (ii > 0)
        {
            ai++;
            ii--;
        }
        //=> do~whild문 으로 해보자.
        do
        {
            ai++;
            ii--;
        } while (ii > 0);
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