using UnityEngine;

public class ClassMemberDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //다른 클래스 멤버 호출
        //[1] 정적 멤버 호출 => 클래스이름.정적멤버이름
        ClassOne.Hi();
        ClassTwo.Hi();

        //[2] 인스턴스 멤버 호출 => 클래스인승턴스 생성,
        ClassTwo ct = new ClassTwo();
        ct.Hollo();

    }

   
}
