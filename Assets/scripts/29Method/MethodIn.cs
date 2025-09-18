using UnityEngine;

namespace Method
{
    public struct Point
    {
        public int x;
        public int y;
    }

    //[1] 값 전달 방법 (int num), 구조체

    public class MethodIn : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            /*int num = 10;
            Debug.Log($"[1]: {num}");       //10

            printNumber(num);

            Debug.Log($"[3]: {num}");       //10*/

            //구조체 변수 선언하고 초기화
            Point point = new Point();
            point.x = 10;

            Debug.Log($"[1]: {point.x}");

            printNumber(point);
            Debug.Log($"[3]: {point.x}");


        }

        private void printNumber(Point p)
        {
            p.x = 20;
            Debug.Log($"[2]: {p.x}");       //20
        }

    }


}

