using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject target;
    public float moveSpeed;
    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target.gameObject != null){
            targetPosition.Set(target.transform.position.x, target.transform.position.y, this.transform.position.z);
            // this 란 이 스크립트가 적용되는 객체를 말한다. 카메라일 것이다.
            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, moveSpeed * Time.deltaTime); // lerp는 a값과 b값 사이의 선형 보간으로 중간값 리턴함.
        }
    }
}
