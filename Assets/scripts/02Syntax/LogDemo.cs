using UnityEngine;

public class LogDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("LogDemo 스크립트 시작됨!");


        //Debug.Log("들여쓰기는 공백 4칸 또는 탬을 사용한다");
        //Debug.Log("C# 문법");



        //Debug.Log(("결과는: " + 5));       //

        //Debug.Log("결과는: " + (5 + 10));  //

        //Debug.Log("결과는: " + 5 + 10);    //
        
        //공백(띄어쓰기)은 프로그램에서 무시됨

        UnityEngine. Debug.Log("C# 문법");
        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



/*
C# Syntax(문법) : 반드시 지켜야하는 규칙
코딩 스타일 : 프로그램 작성에 대한 가이드 라인, 개발자간들의 암묵적 약속

들여쓰기(Indent) : 공백 4칸,탭 코드의 가독성을 높이기 위해서 사용하는 방법

*/