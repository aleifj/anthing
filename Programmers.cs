using System;
using System.Text;

namespace aleifj
{
    public class Programmers
    {

        public static string Solution0813(string my_string)//모음 제거.
        {//문자열 my_string이 매개변수로 주어질 때 모음을 제거한 문자열을 return하도록 solution 함수를 완성해주세요.
            string answer = "";

            answer = my_string.Replace("a", "");
            answer = answer.Replace("e", "");
            answer = answer.Replace("i", "");
            answer = answer.Replace("o", "");
            answer = answer.Replace("u", "");
//처음 my_string에 담겨있는 단어를 바꾼다음 answer에 담고, 그 answer에 다음 단어를 바꾸어 담는다.
            answer = my_string.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "");
            //이것도 됨. 아니 이게 되네...
            foreach(var item in my_string)
            {//foreach 사용 시.
                if((item != 'a') &&
                   (item != 'e') &&
                   (item != 'i') &&
                   (item != 'o') &&
                   (item != 'u'))
                   {
                        answer += item;
                   }
            }
            return answer;
        }
        public static int[] Solution0812(int[] numbers, int num1, int num2)//배열 자르기
        {//numbers의 num1번 째 인덱스부터 num2번째 인덱스까지 자른 정수 배열을 return 하도록 solution 함수를 완성해보세요.
            int len = num2 - num1 + 1;//리턴 할 배열의 크기 구하기

            int[] answer = new int[len];//구한 크기의 배열 선언
            for (int i = 0; i < len; i++)
            {
                answer[i] = numbers[i + num1];
            }
            return answer;
        }
        public static string Solution08092(string my_string, int s, int e)//문자열 뒤집기2.
        {//문자열 my_string과 정수 s, e가 매개변수로 주어질 때, my_string에서 인덱스 s부터 인덱스 e까지를 뒤집은 문자열을 return 하는 solution 함수를 작성해 주세요.

            char[] chr = my_string.ToArray();//프로그래머스에서는 ToCharArray로 해야함.
            Array.Reverse(chr, s, e - s + 1);


            return new string(chr);
        }
        public static string Solution0809(string my_string)//문자열 뒤집기.
        {//문자열 my_string이 매개변수로 주어집니다. my_string을 거꾸로 뒤집은 문자열을 return하도록 solution 함수를 완성해주세요.
            string answer = "";
            //array 사용 시.
            char[] chr = my_string.ToArray();
            Array.Reverse(chr);//array의 뒤집기
            for (int i = 0; i < chr.Length; i++)
            {
                answer += chr[i];
            }
            //list 사용 시.
            var list = new List<char>(my_string);
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                answer += list[i];
            }
            //for 사용 시/
            for(int i = my_string.Length -1; i >= 0; i--)
            {
                answer += my_string[i];
            }
            //foreach 사용 시
            foreach(var item in my_string)
            {
                answer = item + answer;
            }

            return answer;
        }
        public static int[] Solution0808(int money)//아이스아메리카노.
        {//한잔에 5,500원입니다. 가지고 있는 돈 money가 매개변수로 주어질 때, 최대로 마실 수 있는 아메리카노의 잔 수와 남는 돈을 순서대로 담은 배열을 return 하도록 solution 함수를 완성해보세요.
            int[] answer = new int[2];
            int ice = 5500;

            answer[0] = money / ice;
            answer[1] = money % ice;

            return answer;
        }//if쓸 필요 없었음.
        public static int Solution0807(int[] dot)//점의 위치 구하기.
    {//x 좌표 (x, y)를 차례대로 담은 정수 배열 dot이 매개변수로 주어집니다. 좌표 dot이 사분면 중 어디에 속하는지 1, 2, 3, 4 중 하나를 return 하도록 solution 함수를 완성해주세요.
        int answer = 0;
        
        if(dot[0] > 0 && dot[1] > 0)
        {
            answer = 1;
        }
        else if(dot[0] < 0 && dot[1] > 0)
        {
            answer = 2;
        }
        else if(dot[0] < 0 && dot[1] < 0)
        {
            answer = 3;
        }
        else if(dot[0] > 0 && dot[1] < 0)
        {
            answer = 4;
        }

        return answer;
    }
        public static int[] Solution0806(int[] numbers)//배열 두 배 만들기.
        {//정수 배열 numbers가 매개변수로 주어집니다. numbers의 각 원소에 두배한 원소를 가진 배열을 return하도록 solution 함수를 완성해주세요.
            int[] answer = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                answer[i] = numbers[i] * 2;
            }

            return answer;
        }

        public static int Solution0805(int[] array, int height)//머쓱이보다 키 큰 사람.
        {
            //머쓱이네 반 친구들의 키가 담긴 정수 배열 array와 머쓱이의 키 height가 매개변수로 주어질 때, 머쓱이보다 키 큰 사람 수를 return 하도록 solution 함수를 완성해보세요.
            int answer = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > height)
                {
                    answer ++;
                }
            }
            /*foreach(var item in array)//foreach사용.
            {
                answer += 1;
            }*/
            return answer;
        }
        public static string Solution0802(string rsp) //가위바위보.
        {//가위 바위 보를 내는 순서대로 나타낸 문자열 rsp가 매개변수로 주어질 때, rsp에 저장된 가위 바위 보를 모두 이기는 경우를 순서대로 나타낸 문자열을 return하도록 solution 함수를 완성해보세요.
            string answer = "";
            //주어진 string의 크기만큼 반복하다.
            for (int i = 0; i < rsp.Length; i++)
            {//차례대로(인덱스에 따라) 주어진 문자열을 나열한다.
                char chr = rsp[i];
                if (chr == '2')
                {
                    answer += "0";
                }
                else if (chr == '0')
                {
                    answer += "5";
                }
                else
                {
                    answer += "2";
                }
            }
            return answer;
        }

        public static int[] Solution0731(int[] num_list)
        {//정수가 담긴 리스트 num_list가 주어질 때, num_list의 원소 중 짝수와 홀수의 개수를 담은 배열을 return 하도록 solution 함수를 완성해보세요.
         //리턴할 배열의 크기가 2개로 일정함, 바로 크기를 잡아서 선언.
            int[] answer = new int[2];
            int a = 0;
            int b = 0;
            //num_list의 크기만큼 반복한다.
            for (int i = 0; i < num_list.Length; i++)
            {
                if (num_list[i] % 2 == 0)//num_list의 인덱스에 해당하는 값이 짝수라면.
                {
                    a = a + 1;//짝수(a)가 1씩 올라가고.
                }
                else//아니면
                {
                    b = b + 1;//홀수(b)가 1씩 올라간다.
                }
            }
            answer[0] = a;
            answer[1] = b;
            //foreach를 사용할 경우
            foreach (var item in num_list)
            {
                if (item % 2 == 0)
                {
                    answer[0] += 1;
                }
                if (item % 2 != 0)
                {
                    answer[1] += 1;
                }
            }
            return answer;
        }
        static int[] Solution0730(int n)
        {//정수 n이 매개변수로 주어질 때, n 이하의 홀수가 오름차순으로 담긴 배열을 return하도록 solution 함수를 완성해주세요.
         //int[] answer = new int[] {};
            List<int> list = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }
        public static int Solution0729(int n)
        {//정수 n이 주어질 때, n이하의 짝수를 모두 더한 값을 return 하도록 solution 함수를 작성해주세요.
            int answer = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
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
            else if ((0 < angle) && (angle < 90))
            {
                answer = 1;
            }
            else // 생략 가능한 if...복잡한 식을 여기에 
            {
                answer = 3;
            }
            // ?: 로 풀어보자
            answer = (angle == 90) ? 2 : (angle == 180) ? 4 : ((0 < angle) && (angle < 90)) ? 1 : 3;
            return answer;
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

        static int solution07242(int n)
        {
            int answer = 0;
            // 나머지를 구하는 연산자는 %
            int piz = n / 7;
            int res = ((n % 7) == 0) ? 0 : 1;
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

        static int solution0723(int[] array)
        {
            int answer = 0;
            List<int> list = new List<int>(array);
            list.Sort();
            //list.Count 대신 array.Length를 사용해도 된다
            int index = (list.Count - 1) / 2;
            answer = list[index];
            return answer;
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
            foreach (int val in array)
            {
                // foreach문에서 차례로 넘겨주는 값을 가져온다
                // 가져온 값과 n과 비교한다. 두개의 값이 같으면
                if (val == n)
                    // 넘겨주는 값에 1을 더한다
                    answer += 1;
            }
            return answer;
        }
        public static string solution0719(string my_string, int n)
        {
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
}