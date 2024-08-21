using System;
using Myevan;
using System.Text;

namespace aleifj
{
    public class CSharpStudy
    {
        public static void CompareTo()
        {
            int a = 0;//2개가 같으면 0나옴
            int b = 1;
            a.CompareTo(b);//a를 기준으로 b와 비교하라.
            string s1 = "abc";
            string s2 = "aaa";
            s1.CompareTo(s2);
            if (s1.CompareTo(s2) == 0)
            {//s1이 s2와 같은것이 참이라면...
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(s1);
        }

        public class chessPiece
        {//부모클레스
            public virtual void Move()
            {//virtual을 붙이면 자식클래스에서 Override를 써 부모의 상속을 변경할 수 있음.
                Console.WriteLine("do not move");
            }
            public void SerPosition(int x)
            {//오버로딩:같은 이름의 함수를 다른 내용물로 많이 만드는거?

            }
            public void SerPosition(int x, int y)
            {//오버로딩:같은 이름의 함수를 다른 내용물로 많이 만드는거?

            }
            public void SerPosition()
            {//오버로딩:같은 이름의 함수를 다른 내용물로 많이 만드는거?

            }
            public void SerPosition(char x)
            {//오버로딩:같은 이름의 함수를 다른 내용물로 많이 만드는거?

            }
        }
        public class Knight : chessPiece
        {//자식클레스
            public override void Move()
            {//override를 써 부모의 상속 변경.
                Console.WriteLine("말처럼 이동 가능");
            }
        }
        public class Rook : chessPiece
        {//자식클레스
            public override void Move()
            {
                Console.WriteLine("직선 이동 가능");
            }
        }
        public class vishop : chessPiece
        {//자식클레스
            public override void Move()
            {
                Console.WriteLine("대각선 이동 가능");
            }
        }

 /*chessPiece cp = new chessPiece();
            chessPiece Kn = new Knight();//부모형식에서 자식형식들의 상속 형태.
            chessPiece ro = new Rook();//ChessPiece을 Knight,Rook,Vishop에게 상속함.
            chessPiece vi = new vishop();//왼쪽에 있는게 부모, 오른쪽에 잇는게 자식클래스.

            cp.Move();
            Kn.Move();
            ro.Move();
            vi.Move();

            cp.SerPosition();//오버로딩    
            cp.SerPosition(1);//이런식으로 
            cp.SerPosition(1, 2);//불러 
            cp.SerPosition('z');//옴.*/
            
        /*public static enum Direction//enum 열거형.
        {//함수 안에서 이넘을 정의할 수 없다.
            East,
            West,
            South,
            North
        }
        public static void Basic()
        {
            Direction dir = Direction.South;
            switch (dir)
            {
                case Direction.West:
                    break;
                case Direction.East:
                    break;
                case Direction.South:
                    break;
                case Direction.North:
                    break;
            }
            Console.WriteLine($"your direction is {dir}, value : {(int)dir}");
        }*/

        public static void DicSample()//0816
        {//csharpstudy 헤시테이블, 딕셔너리.
            //Dictionary<string, string> loginData = new Dictionary<string, string>();원형
            var loginData = new Dictionary<string, string>();
            //형식 형식명명 = new dictionary<키(key), 값(value)>();
            loginData.Add("zinine", "password");//위에서 string으로 선언해서, int 쓰면 정수 사용.
            loginData.Add("whdgus", "qwer");
            loginData.Add("aleifj", "asdf");
            loginData.Add("yuyuyu7878", "zxcv1");

            string pw = loginData["zinine"];
            foreach(var item in loginData)
            {
                //Console.WriteLine($"{item.key},{itme.value}");
            }

            foreach(string item in loginData.Keys)
            {
                Console.WriteLine(item);//키만 나옴.values하면 값만 나옴.
            }
            string checkid = "uiop";
            if(loginData.ContainsKey(checkid) == false)
            {
                Console.WriteLine($"{checkid}는 없습니다.");
            }
            else
            {
                Console.WriteLine($"{checkid}의 암호는 {loginData}");
            }
        }

        static void KoreanJosa()
        {
            // 한글 조사 변환 > using Myevan 해야 Korean.Re~ 사용할 수 있다
            Console.WriteLine($"나(은)는 지금 탕후루(탕)후루 먹고싶다.");
            string a = Korean.ReplaceJosa($"나(은)는");
            string b = Korean.ReplaceJosa($"탕후루(탕)후루");
            Console.WriteLine($"{a} 지금 {b} 먹고싶다.");
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
            int[] ina = new int[5] { 3, 5, 7, 1, 2 };
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


    }
}
