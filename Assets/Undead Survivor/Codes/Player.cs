using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // �ൿ �Լ�
    public Vector2 inputVec;
    public float speed;
    Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        //1. ���� �ش�
        //rigid.AddForce(inputVec);

        //2. �ӵ� ����
        //rigid.velocity = inputVec;

        //3. ��ġ �̵�
        //rigid.position -> ���� ��ġ
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime; //�밢�� ���� �ӵ� 
        rigid.MovePosition(rigid.position + nextVec); 
    }
}
