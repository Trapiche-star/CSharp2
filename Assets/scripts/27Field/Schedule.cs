using UnityEngine;

namespace Field
{
    //Schedyle  클래스 : 사용자 정의 데이터 형식
    public class Schedule
    {
        //[1] 필드(전역변수) - 배열 선언하고 초기화
        string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thy", "Fri", "Sat" };

        //[2]메서드(엔스턴스)
        public void PrintWeekDays()
        {
            for (int i = 0; i < weekDays.Length; i++)
            {
                Debug.Log(weekDays[i]);
            }
        }

    }

}
