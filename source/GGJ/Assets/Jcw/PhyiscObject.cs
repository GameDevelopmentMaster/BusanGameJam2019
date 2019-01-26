using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PhyiscObject : MonoBehaviour
{
    private bool[] Chick;
    [SerializeField]
    private GameObject[][] Obejcts;
    [SerializeField]
    private Text EKey;
    [SerializeField]
    private Camera mainCara;
    // Start is called before the first frame update
    void Start()
    {
        Chick = new bool[4];
        for (int i = 0; i < 4; i++)
        {
            Chick[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = mainCara.ScreenPointToRay(this.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1))
        {
            if (hit.transform.tag != "Ground" && hit.transform.tag != "CheckPoint1")
            {
                Debug.Log(hit.transform.name);  
                EKey.gameObject.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    switch (hit.transform.tag)
                    {
                        case "door":
                            if (Chick[hit.transform.GetComponent<ObjectKey>().key])
                            {

                            }
                            else
                            {

                            }
                            break;
                        case "Space":
                            Chick[hit.transform.GetComponent<ObjectKey>().key] = true;
                            break;
                        case "a":

                            break;
                    }
                }
            }
        }
        else
        {
            EKey.gameObject.SetActive(false);
        }
    }
}
