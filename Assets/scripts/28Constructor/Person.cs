using UnityEngine;

namespace Constructor
{
    public class Person
    {
        //1필드
        private string name;

        //2기본 생성자: 매개변수x 필드 초기화
        public Person()
        {
            name = "홍길동";
        }

        //[3]매개변수가 있는 생성자 - 매개변수를 입력 바당 이름을 초기화
        public Person(string value)
        {
            name = value;
        }

        //[4]aptjem - 이름값을 외부에서 사용하도록 메서드 구현
        public string GetName()
        {
            return name;
        }




    }

}

