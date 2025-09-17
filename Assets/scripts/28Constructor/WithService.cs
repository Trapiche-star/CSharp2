using Unity.Android.Gradle.Manifest;
using UnityEngine;

namespace Constructor
{
    public class WithService
    {
        //필드 선언부
        //일기 전용 필드
        private readonly string serviceName;
        
        //기본 생성자
        //생성자를 통해서 일기 전용 필드도 초기화가 가능하다
        public WithService()
        {
            serviceName = "파일";
        }

        public WithService(string service)
        {
            this.serviceName = service;
        }

        public void Run()
        {

            Debug.Log($"{serviceName}를 실행합니다");
        }

    }

}

