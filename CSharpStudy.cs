using System;
using Myevan;
using System.Text;
using System.Runtime.CompilerServices;
using System.Data.SqlTypes;

namespace aleifj
{
    public class CSharpStudy
    {
        #region Delegate
        //Delegate선언
        delegate void MyDelegate(int i);

        void RunThis(int val)
        {
            Console.WriteLine($"Run This : {val}");
        }

        void RunThat(int value)
        {
            Console.WriteLine($"Run That : {value}");
        }

        void RunWho(int val1, int val2)
        {
            Console.WriteLine($"Run Who : {val1 + val2}");
        }

        public void Perform()
        {
            //Delegate의 instance생성
            MyDelegate run = new MyDelegate(RunThis);
            //Delegate의 실행(run.Invoke();이게 원형)
            run(100);
            //새로운 매서드 연결(위의것과 이름이 같아도 상관없음)
            run = new MyDelegate(RunThat);
            run(100);

            run = RunThis;//이렇게 요약 가능
            run(100);
        }
        #endregion
    }
}