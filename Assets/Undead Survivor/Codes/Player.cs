using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    // 행동 함수
    public Vector2 inputVec;
    public float speed;

    Rigidbody2D rigid;
    SpriteRenderer spriter;
    Animator anim;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    //구시대 input 사용 -> input package 사용!
    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");
    }

    //신시대 input package 내장함수 -> 이거 나중에 써야햠!
    /*void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }*/

    void FixedUpdate()
    {
        //1. 힘을 준다
        //rigid.AddForce(inputVec);

        //2. 속도 제어
        //rigid.velocity = inputVec;

        //3. 위치 이동
        //rigid.position -> 현재 위치
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime; //대각선 같은 속도 
        rigid.MovePosition(rigid.position + nextVec); 
    }

    //후처리 함수
    void LateUpdate()
    {
        anim.SetFloat("Speed",inputVec.magnitude);

        if (inputVec.x != 0)
        {
            spriter.flipX = inputVec.x < 0;
        }
    }

}
