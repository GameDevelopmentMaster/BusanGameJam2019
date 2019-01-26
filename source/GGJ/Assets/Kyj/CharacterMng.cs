using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterMng : MonoBehaviour
{ 
    public  bool CheckPoint1 = false;

    [SerializeField] private GameObject Monster;
    private ColiderMng col;

    [SerializeField]
    private Image[] HP;

    [SerializeField] private ColiderMng colmng;
    public int Hp = 3;
    public float Speed = 6.0f;
    public float JumpSpeed = 8.0f;
    public float gravity = 20.0f;
     
    private CharacterController controller;
    private Vector3 MoveDir;

    void Start()
    {
        MoveDir = Vector3.zero;
        controller = GetComponent<CharacterController>();

        colmng = GameObject.Find("GameController").GetComponent("ColiderMng") as ColiderMng;
    }

    void Update()
    {
        if(controller.isGrounded)
        {
            MoveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            MoveDir = transform.TransformDirection(MoveDir);

            MoveDir *= Speed;

            if(Input.GetButton("Jump"))
            {
                MoveDir.y = JumpSpeed;
            }
        }
        MoveDir.y -= gravity * Time.deltaTime;

        controller.Move(MoveDir * Time.deltaTime);


    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CheckPoint1")
        {
            CheckPoint1 = true;

            Monster.SetActive(true);
             
        }
      if(other.tag == "Enemy")
        {
            Monster.SetActive(false);
            HP[Hp].gameObject.SetActive(false);
            Hp--;
        }
    
    }
    public void OnTriggerExit(Collider other)
    {
  
    }

}
