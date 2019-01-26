using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
 
    [SerializeField] GameObject player;
    [SerializeField] CharacterMng CharMng;
    [SerializeField] NavMeshAgent nav;
    [SerializeField] private ColiderMng colmng;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        CharMng = GameObject.Find("PlayerController").GetComponent("CharacterMng") as CharacterMng;
        nav = GetComponent<NavMeshAgent>();
    }
     void Update()
    {

        if(CharMng.CheckPoint1 == true)
        {
            nav.destination = (player.transform.position);
        }
       
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            CharMng.Hp--;
            Debug.Log(CharMng.Hp);
        }
        if(CharMng.Hp == 0)
        {
            Time.timeScale = 0;
        }
    }

}
 
