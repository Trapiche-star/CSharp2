using UnityEngine;


public class ClassTwo
{
    // 정적 메서드
    public static void Hi()
    {
        Debug.Log("ClassTwo says Hi!");
    }

    // 인스턴스 메서드
    public void Hollo()
    {
        Debug.Log("ClassTwo instance says Hollo!");
    }
}