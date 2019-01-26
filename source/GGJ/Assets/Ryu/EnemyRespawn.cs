using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    public GameObject Respawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        GameObject respawn = Instantiate(Respawn) as GameObject;
        respawn.transform.position = new Vector3(6, 20, -28);
    }
}
