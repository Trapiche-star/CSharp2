using UnityEngine;

namespace Indexer
{
    public class IndexerNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //person클래스의 인스턴스 생성
            Person person = new Person();

            //인덱서 사용
            person[0] = "홍길동";
            Debug.Log(person[0]);   // 홍길동 출력

            person[1] = "백두산";
            Debug.Log(person[1]);   // 백두산

            Debug.Log(person[0]);   //백두산

        }


    }

}
