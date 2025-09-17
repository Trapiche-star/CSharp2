using UnityEngine;

namespace Constructor
{
    public class ConstructorDemo : MonoBehaviour
    {
        // 생성자 메서드
        public ConstructorDemo()
        {
            //Debug.Log("생성자가 호출되었습니다.");
        }
        
        void Start()
        {
            // ConstructorDemo 클래스의 인스턴스 생성
            // ConstructorDemo cons = new ConstructorDemo();

            //Studeent 클래스의 인스턴스(객체)를 생성 - 클래스의 생성자 호출
            Studeent studeent = new Studeent();

        }
    }
}

/*
생성자(Constructor)
: 클래스가 사용될때 제일 먼저 호출되는 메서드,
: 클래스의 필드,속성들의 기본값 설정하는 역할 한다

생성자(Constructor)
: 메서드
: 클래스 이름과 동일한 이름을 사용
: 접근 제한자는 public를 사용
: 반환값도 없고, void도 없다

- 만들지 않으면 기본 생성자를 자동으로 만들어준다
- 생성되는 인스턴스(객체)의 필드, 속성들의 값을 설정하지 않았을 경우 기본값 초기화
- 기본값: 값형 변수 zero(0), 참조형은: null
class Date
{
    //생성자 
    public Date()
    {
        
    }

}

 
*/

