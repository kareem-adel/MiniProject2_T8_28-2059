using UnityEngine;
using System.Collections;

public class MalcomMoving : MonoBehaviour {

    private Animator Anim;

    private bool isMoving;
    private bool isMovingBackwords;
    private bool isTurningRight;
    private bool isTurningLeft;


    // Use this for initialization
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1, 0);
            isTurningLeft = true;
        }
        else
        {
            isTurningLeft = false;
        }
        if (Input.GetKey(KeyCode.W))
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
        if (Input.GetKey(KeyCode.S))
        {
            isMovingBackwords = true;
        }
        else
        {
            isMovingBackwords = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1, 0);
            isTurningRight = true;
        }
        else
        {
            isTurningRight = false;
        }


        Anim.SetBool("isMoving", isMoving);
        Anim.SetBool("isMovingBackwords", isMovingBackwords);
        Anim.SetBool("isTurningRight", isTurningRight);
        Anim.SetBool("isTurningLeft", isTurningLeft);
    }
}
