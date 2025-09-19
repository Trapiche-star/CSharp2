using UnityEngine;

namespace Property
{
    public class User
    {
        private int birthYear;              // 생년

        public string Name { get; set; }    // 이름

        // 쓰기 전용 속성
        public int BirthYear
        {
            set
            {
                if (value >= 1900)
                    birthYear = value;
                else
                    birthYear = 0;
            }
        }

        // 읽기 전용 속성
        public int Age
        {
            get { return (System.DateTime.Now.Year - birthYear); }
        }

        // 생성자 - 매개변수를 받아서 속성값 초기화
        public User(string name)
        {
            Name = name;
        }
    }



}



