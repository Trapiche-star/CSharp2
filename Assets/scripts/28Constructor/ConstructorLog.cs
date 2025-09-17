using UnityEngine;


namespace Constructor
{
    public class ContructorLog
    {
        //기본 생성자 
        public ContructorLog()
        {
            Debug.Log("기본 생성자 실행");
        }

        //매개변수 string 이 있는 생성자
        public ContructorLog(string name)
        {

        }



    }

}

/*
생성자 MethodOverload : 함수의 다중 정의
: 동일한 이름의 생성자를 매개변수를 달리해서 여러개 생성(정의) 
*/