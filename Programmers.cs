using System;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Globalization;
using System.Reflection.Metadata;
using System.Text;
using System.Collections.Generic;


namespace aleifj
{
    public class Programmers
    {
        public string Solution0913(int age)//외계행성의 나이.
        {
            string answer = "";
            while(age > 0)
            {
                int val = age % 10;//1의 자리(나머지).
                char chr = Convert.ToChar(val + 'a');//1의 자리에서 나온 수와 아스키코드 'a'의 값을 더하여 그 값을 convert한다.
                answer = chr + answer;//answer = 2번째로 구한 chr + 1번째로 구한 chr
                age = age / 10;//10의 자리(몫).그리고 다시 위로감.
            }

            return answer;
        }
        public int Solution09112(string binomial)//간단한 식 계산하기
        {
            int answer = 0;

            string[] word = binomial.Split(' ');//string을 숫자와 수식으로 분리

            int num = Int32.Parse(word[0]);//각 숫자(string)를 integer로 변환
            int num1 = Int32.Parse(word[2]);

            switch (word[1])
            {//각 수식에 맞게 계산
                case "+":
                    answer = num + num1;
                    break;

                case "-":
                    answer = num - num1;
                    break;

                case "*":
                    answer = num * num1;
                    break;

                case "/":
                    answer = num / num1;
                    break;
            }
            return answer;
        }
        public int[] Solution0911(int n)//약수 구하기
        {//정수 n이 매개변수로 주어질 때, n의 약수를 오름차순으로 담은 배열을 return하도록 solution 함수를 완성해주세요.
            List<int> list = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    list.Add(i);
                }

            }
            return list.ToArray();
        }
        public int Solution0909(string number)//9로 나눈 나머지.
        {
            int number1 = 0;//string형태인 number를 int형태로 받을 정수 선언.
            foreach(var item in number)//string은 char의 배열임으로 배열의 각 값을 돌면서 더해준다.
            {
                //각 item의 int값을 더해준다.
                int val = item - '0';
                number1 += val;
            }
            
            return number1 % 9;
        }
        public int Solution09042(int[] numbers)//최댓값 만들기(2)
        {//정수 배열 numbers가 매개변수로 주어집니다. numbers의 원소 중 두 개를 곱해 만들 수 있는 최댓값을 return하도록 solution 함수를 완성해주세요.
            int answer = -100000000;//아니 이게 뭔데

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if(numbers[i] < 0 && numbers[j] < 0)
                    {
                        if(answer < Math.Abs(numbers[i]) * Math.Abs(numbers[j]))
                        answer = Math.Abs(numbers[i]) * Math.Abs(numbers[j]);
                    }
                    else if(answer < numbers[i] * numbers[j])
                    {
                        answer = numbers[i] * numbers[j];
                    }
                }
            }

            return answer;
        }
        public int Solution0904(int[] numbers)//최댓값 만들기(1)
        {//정수 배열 numbers가 매개변수로 주어집니다. numbers의 원소 중 두 개를 곱해 만들 수 있는 최댓값을 return하도록 solution 함수를 완성해주세요.
            int answer = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (answer < numbers[i] * numbers[j])
                    {
                        answer = numbers[i] * numbers[j];
                    }
                }
            }

            return answer;
        }
        public int[] Solution0902(int n)//콜라츠 수열 만들기
        {//개길어
            List<int> list = new List<int>();

            /*while (n != 1)
            {
                list.Add(n);//n을 list에 넣는다.
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = 3 * n + 1;
                }
            }이게 맞음
            list.Add(1);*/
            for (int i = 0; i < list.Count; i++)
            {
                list.Add(n);
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = 3 * n + 1;
                }

            }
            list.Add(1);
            
            return list.ToArray();
        }
        public static int[] Solution0829(int[] arr)//배열의 원소만큼 추가하기, using System.Collections.Generic;
        {


            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i]; j++)
                {
                    list.Add(arr[i]);
                }
            }

            return list.ToArray();
        }
        public static int Solution08282(int a, int b)//주사위 게임1
        {//두 정수 a와 b가 매개변수로 주어질 때, 얻는 점수를 return 하는 solution 함수를 작성해 주세요.
            int answer = 0;

            if (a % 2 != 0 && b % 2 != 0)
            {
                answer = (a * a) + (b * b);
            }
            else if (a % 2 == 0 && b % 2 == 0)
            {
                answer = Math.Abs(a - b);
            }
            else
            {
                answer = 2 * (a + b);
            }

            return answer;
        }

        public static int[] Solution0828(int[] num_list)//뒤에서 5등 위로,using System.Collections.Generic;
        {//정수로 이루어진 리스트 num_list가 주어집니다. num_list에서 가장 작은 5개의 수를 제외한 수들을 오름차순으로 담은 리스트를 return하도록 solution 함수를 완성해주세요.

            //list.sort사용
            List<int> list = new List<int>(num_list);
            List<int> relist = new List<int>();
            list.Sort();//오름차순
            for(int i = 5; i < list.Count; i++)
            {
                relist.Add(list[i]);
            }
            return relist.ToArray();
        }
        public static string Solution0826(string n_str)//0 떼기
        {//정수로 이루어진 문자열 n_str이 주어질 때, n_str의 가장 왼쪽에 처음으로 등장하는 0들을 뗀 문자열을 return하도록 solution 함수를 완성해주세요.
            string answer = "";

            bool zero = true;
            while (zero)
            {
                if (n_str[0] == '0')
                {
                    n_str = n_str.Substring(1, n_str.Length - 1);
                }
                else
                {
                    zero = false;
                }
            }
            answer = n_str;
            return answer;
        }
        public static int Solution0823(int[] box, int n)//주사위의 개수
        {//배열 box와 주사위 모서리의 길이 정수 n이 매개변수로 주어졌을 때, 상자에 들어갈 수 있는 주사위의 최대 개수를 return 하도록 solution 함수를 완성해주세요.
            int answer = 0;

            int garo = box[0] / n;
            int syero = box[1] / n;
            int noppi = box[2] / n;
            answer = garo * syero * noppi;

            return answer;
        }
        public static int Solution0822(int[] num_list)//홀수 vs 짝수
        {//가장 첫 번째 원소를 1번 원소라고 할 때, 홀수 번째 원소들의 합과 짝수 번째 원소들의 합 중 큰 값을 return 하도록 solution 함수를 완성해주세요. 두 값이 같을 경우 그 값을 return합니다.

            //int idx = 1;
            int ON = 0;
            int EV = 0;

            /*foreach (int item in num_list)
            {
                if (idx % 2 == 1)
                    ON += item;
                else
                    EV += item;
                idx++;
            }
            return Math.Max(ON, EV);*/

            List<int> list = new List<int>(num_list);
            for (int i = 0; i < num_list.Length; i++)
            {
                if (i % 2 == 1)
                {
                    ON += num_list[i];
                }
                else if (i % 2 == 0)
                {
                    EV += num_list[i];
                }
                 
            }
            return Math.Max(ON, EV);
        }
        public static int[] Solution0821(int start_num, int end_num)//카운트 업
        {//정수 start_num와 end_num가 주어질 때, start_num부터 end_num까지의 숫자를 차례로 담은 리스트를 return하도록 solution 함수를 완성해주세요.
            int len = end_num - start_num + 1;//배열의 크기를 먼저 잡는다

            int[] answer = new int[len];//크기만큼 배열을 잡는다

            for (int i = 0; i < answer.Length; i++)//잡은 배열을 반복한다
            {
                answer[i] = start_num + i;//start부터 반복해서 넣는다
            }

            return answer;
        }

        public static int Solution0820(int a, int b)//두 수의 연산값 비교하기
        {//양의 정수 a와 b가 주어졌을 때, a ⊕ b와 2 * a * b 중 더 큰 값을 return하는 solution 함수를 완성해 주세요.
         //단, a ⊕ b와 2 * a * b가 같으면 a ⊕ b를 return 합니다.
            int answer = 0;
            string apb = $"{a}{b}";
            int iapb = Convert.ToInt32(apb);
            int tab = 2 * a*b;
            if(iapb == tab)
            {
                answer = iapb;
            }
            else
            {
                answer = Math.Max(iapb, tab);
            }
            return answer;
        }
        public static string Solution08192(int[] numLog)//수 조작하기2
        {//정수 배열 numLog가 주어집니다. 처음에 numLog[0]에서 부터 시작해 "w", "a", "s", "d"로 이루어진 문자열을 입력으로 받아 순서대로 다음과 같은 조작을 했다고 합시다.
            string answer = "";

            for (int i = 0; i < numLog.Length - 1; i++)
            {
                int var = numLog[i + 1] - numLog[i];
                /*if (var == 1)
                {//if사용 시
                    answer += 'w';
                }
                else if (var == -1)
                {
                    answer += 's';
                }
                else if (var == 10)
                {
                    answer += 'd';
                }
                else if (var == -10)
                {
                    answer += 'a';
                }*/
                switch (var)
                {//switch사용 시
                    case 1:
                        answer += 'w';
                        break;
                    case -1:
                        answer += 's';
                        break;
                    case 10:
                        answer += 'd';
                        break;
                    case -10:
                        answer += 'a';
                        break;
                }
            }
            return answer;
        }

        public static int Solution0819(int n, string control)//수 조작하기.
        {//정수 n과 문자열 control이 주어집니다. control은 "w", "a", "s", "d"의 4개의 문자로 이루어져 있으며, control의 앞에서부터 순서대로 문자에 따라 n의 값을 바꿉니다.
            foreach (var item in control)
            {
                switch (item)
                {
                    case 'w':
                        n += 1;
                        break;
                    case 'a':
                        n -= 10;
                        break;
                    case 's':
                        n -= 1;
                        break;
                    case 'd':
                        n += 10;
                        break;
                }
            }
            return n;
        }
        public static int Solution0816(int[] num_list)//첫 번째로 나오는 음수
        {//정수 리스트 num_list가 주어질 때, 첫 번째로 나오는 음수의 인덱스를 return하도록 solution 함수를 완성해주세요. 음수가 없다면 -1을 return합니다.
            int answer = -1;

            for (int i = 0; i < num_list.Length; i++)
            {
                if (num_list[i] < 0)
                {
                    answer = i;
                    break;
                }
            }

            return answer;
        }

        public static int Solution0814(int[] numbers, int n)//n보다 커질 때까지 더하기
        {//numbers의 원소를 앞에서부터 하나씩 더하다가 그 합이 n보다 커지는 순간 이때까지 더했던 원소들의 합을 return 하는 solution 함수를 작성해 주세요.
            int answer = 0;
            int m = 0;
            for (int i = 0; i <= numbers.Length; i++)
            {
                m += numbers[i];
                if (n < m)
                {
                    answer = m;
                    break;
                }
            }
            return answer;
        }

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