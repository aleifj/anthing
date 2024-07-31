﻿using System.Formats.Asn1;
using System.Text;
using Myevan;

internal class Program
{
    private static void Main(string[] args)
    {
        
        int[] n = new int[]{1, 3, 5, 7};
        int[] inv2 = new int[]{89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99};
        //int num1 = 15, num2 = 99;
        //var strl = new string[]{"I", "Love", "Programmers."};
        int[] answer = Solution0731(n);
        //Console.WriteLine(answer);
        //MakeLotto();
        PrintIntArray(answer);

        //nullable이란 null을 담을 수 없는 int, time의 타입이 null을 담을 수 있게 만든다
        int? i = null;//int타입에 ?삽입.
    }


    public static int[] Solution0731(int[] num_list) 
    {//정수가 담긴 리스트 num_list가 주어질 때, num_list의 원소 중 짝수와 홀수의 개수를 담은 배열을 return 하도록 solution 함수를 완성해보세요.
        //리턴할 배열의 크기가 2개로 일정함, 바로 크기를 잡아서 선언.
        int[] answer = new int[2];
        int a = 0;
        int b = 0;
        //num_list의 크기만큼 반복한다.
        for(int i = 0; i < num_list.Length; i++)
        {
            if(num_list[i] % 2 == 0)//num_list의 인덱스에 해당하는 값이 짝수라면.
            {
                a = a+1;//짝수(a)가 1씩 올라가고.
            }
            else//아니면
            {
                b = b + 1;//홀수(b)가 1씩 올라간다.
            }            
        }
        answer[0] = a;
        answer[1] = b;
        //foreach를 사용할 경우
        foreach(var item in num_list)
        {
            if(item % 2 == 0)
            {
                answer[0] += 1;
            }
            if(item % 2 != 0)
            {
                answer[1] += 1;
            }
        }
        return answer;
    }
//프로그래머스에서는 List<>쓸 때 using System.Collections.Generic; 꼭 써줘야함.
static int[] Solution0730(int n)
{//정수 n이 매개변수로 주어질 때, n 이하의 홀수가 오름차순으로 담긴 배열을 return하도록 solution 함수를 완성해주세요.
    //int[] answer = new int[] {};
    List<int> list = new List<int>();

    for (int i = 1; i <= n; i++)
    {
        if(i % 2 != 0)
        {
            list.Add(i);            
        }
    }
    return list.ToArray();
}
public static int Solution0729(int n)
{//정수 n이 주어질 때, n이하의 짝수를 모두 더한 값을 return 하도록 solution 함수를 작성해주세요.
    int answer = 0;

    for(int i = 0; i <= n; i++)
    {
        if(i % 2 == 0)
        {
            answer += i; 
        }
    }

    return answer;
}
    static int Solution0726(int angle)
    {
        int answer = 0;
        if (angle == 90)
        {
            answer = 2;
        }
        else if (angle == 180)
        {
            answer = 4;
        }
        else if ((0<angle) && (angle<90))
        {
            answer = 1;
        }   
        else // 생략 가능한 if...복잡한 식을 여기에 
        {
            answer = 3;
        }

        // ?: 로 풀어보자
        answer = (angle == 90) ? 2 : (angle == 180) ? 4 : ((0<angle) && (angle<90))? 1 : 3; 
        return answer;
    }

    public static void MakeLotto()
    {
        // lotto2는 List를 이용하는 방법, lotto는 배열을 이용
        //List<int> lotto2 = new List<int>();
        int[] lotto = new int[6];

        var random = new Random();
        int count = 0;
        while(count < 6)
        {
            // 공을 하나 뽑고
            int pick = random.Next(1, 46);
            // 이미 뽑은 공들중에 있는지 비교해서
            //if (lotto2.Contains(pick))
            if (IsInIntArray(lotto, pick))
            {
                // 코드를 더 간결하게 할 수 있지만 일부러 continue 써보려고 이렇게 했음
                continue;
            }
            // 없으면 배열에 넣는다    
            else
            {
                //lotto2.Add(pick);
                lotto[count] = pick;
            }
            count++;
        }
        //lotto2.Sort();
        Array.Sort(lotto);

        //PrintIntArray(lotto2.ToArray());
        PrintIntArray(lotto);
    }
    // Integer배열에 주어진 값이 있는지 판단하는 함수
    public static bool IsInIntArray(int[] array, int val)
    {
        // array 안에 val 값이 있으면 true를 리턴
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == val)
                return true;
        }
        // 아니면 false 리턴
        return false;
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

    // Integer 배열을 한줄에 출력해주는 함수
    private static void PrintIntArray(int[] answer)
    {    
        for(int i = 0; i < answer.Length; i++)
        {
            Console.Write(answer[i]);
            if (i != answer.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine();
    }

    static int[] solution0725(string[] strlist)
    {
        int[] answer = new int[strlist.Length];

        // 주어진 string배열의 크기만큼 반복한다
        for (int i = 0; i < strlist.Length; i++)
        {
            //strlist중에 index i 에 해당하는 string의 길이를
            string str = strlist[i];
            int len = str.Length;
            // answer 배열의 index의 위치에 넣는다
            answer[i] = len;
        }

        // foreach를 사용한 방법
        int val = 0;
        foreach (var item in strlist)
        {
            answer[val] = item.Length;
            val++;
        }
        return answer;
    }
    static void KoreanJosa()
    {
        // 한글 조사 변환 > using Myevan 해야 Korean.Re~ 사용할 수 있다
        Console.WriteLine($"나(은)는 지금 탕후루(탕)후루 먹고싶다.");
        string a = Korean.ReplaceJosa($"나(은)는");
        string b = Korean.ReplaceJosa($"탕후루(탕)후루");
        Console.WriteLine($"{a} 지금 {b} 먹고싶다.");
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

    static int solution0723(int[] array)
    {
        int answer = 0;
        List<int> list = new List<int>(array);
        list.Sort();
        //list.Count 대신 array.Length를 사용해도 된다
        int index = (list.Count - 1)/2;
        answer = list[index];
        return answer;
    }

    static void STnQ()
    {
        Stack<int> st = new Stack<int>();
        st.Push(1);
        st.Push(2);
        st.Push(3);
        //int val1 = st.Pop();

        Queue<int> qu = new Queue<int>();
        qu.Enqueue(1);
        qu.Enqueue(2);
        qu.Enqueue(3);
        //int val2 = qu.Dequeue();

        int len = st.Count;
        for (int i = 0; i < len; i++)
            Console.WriteLine($"{i + 1} : {st.Pop()} , {qu.Dequeue()}");

        // 배열 연산, 정렬등은 List 를 이용하자
        int[] ina = new int[5] {3, 5, 7, 1, 2};
        List<int> li = new List<int>(ina);
        int val = li[0];
        li.Sort();
        // 리스트에 있는 값은 배열에 있는 값을 이용하듯이 인덱스로 지정하면 됨
        val = li[0];
        li.Add(6);
        // Remove는 주어진 값을 지우는 것...없으면 안지움
        // 같은 값이 2개 이상 있을 때 앞에서 부터 지운다
        li.Remove(2);
        // RemoveAt은 해당 인덱스에 있는 값을 지운다 
        li.RemoveAt(2);
        li.Clear();
    }
    
    private static bool YesOrNo(bool val)
    {
        if (!val)
        {
            val = !val;
        }
        return val;
    }

    static int solution07242(int n)
    {
        int answer = 0;
        // 나머지를 구하는 연산자는 %
        int piz = n / 7;
        int res = ((n % 7) == 0 )? 0 : 1;
        answer = piz + res;

        return answer;
    }

    static int solution0724(int num1, int num2)
    {
        int answer = 0;
        // if ~ else 를 사용했을 때
        if (num1 != num2)
        {
            answer = -1;
        }
        else// if (num1 != num2) <- 이부분 생략 가능
        {
            answer = 1;
        }

        // ?: (삼항연산자)를 사용했을 때
        answer = (num1 != num2) ? -1 : 1;

        return answer;
    }

    private static int Func(int val)
    {
        // StringBuilder를 사용하기 위해서는 using System.Text; 가 필요하다.
        // VSCode에서는 자동으로 넣어준다...다른 곳에서 사용할 때 주의하자
        StringBuilder sb = new StringBuilder();
        sb.Append("What");
        
        // for문은 간단한 식이라면 {} 없이도 사용할 수 있다
        for (int i = 0; i < 5; i++) 
            sb.Append(val);

        // StringBuilder의 값을 실제로 string으로 사용하기 위해선 ToString() 이 필요하다
        Console.WriteLine(sb.ToString());
        
        // if문도 {} 안 쓰고 사용 가능
        if (val > 90) 
            val--; 
        else 
            val++;
        
        return val;
    }

    private static string Sample(int aaa)
    {
        //Func();
        string[] city = new string[5] { "도쿄", "타이베이", "오사카", "홍콩", "발리" };
        var country = new string[5] { "일본", "대만", "일본", "중국", "인도네시아" };
        string[,] trip = new string[2, 5]{{"도쿄", "타이베이", "오사카", "홍콩", "발리"},
        {"일본", "대만", "일본", "중국", "인도네시아"}};

        // 하니가 3살 때 코나키타발루 를 다녀온것을 기억했다. 이걸 list로 만들어 보자
        List<string> city2 = new List<string>(city);
        city2.Insert(3, "코타키나발루");
        // 배열에 있는 모든 요소에 접근하려할 때 foreach 사용하면 좋다
        foreach (string item in city2)
        {
            //Console.WriteLine(item);
        }

        return string.Empty;
    }

    public static int solution0722(int[] array, int n) 
    {
        int answer = 0;
        
        // for문 사용
        // 배열의 크기만큼 반복한다
/*         for (int i = 0; i < array.Length; i++)
        {
            // 배열안에 있는 값을 하나씩 가져온다
            int nn = array[i];
            // 가져온 값과 n과 비교한다. 두개의 값이 같으면
            if (nn == n)
            {
                //  넘겨주는 값에 1을 더한다
                answer++;
            }
        } */

        // foreach
        // 배열의 크기만큼 반복한다
        foreach(int val in array)
        {
            // foreach문에서 차례로 넘겨주는 값을 가져온다
            // 가져온 값과 n과 비교한다. 두개의 값이 같으면
            if (val == n)
            // 넘겨주는 값에 1을 더한다
                answer += 1;
        }
        return answer;
    }

    public static string solution0719(string my_string, int n){
        string answer = "";
        // my_string에 들어있는 각 문자를 처음부터 돌면서 하나씩 얻어와서
        foreach (var item in my_string)
        {
            // n번만큼 돌려서
            for (var i = 0; i < n; i++)
            {
                // 그걸 answer에 담는다
                // string연산을 할 경우엔 StringBuilder를 쓰면 효율적이다.
                answer += item; 
            }
        }
        return answer;
    }
}