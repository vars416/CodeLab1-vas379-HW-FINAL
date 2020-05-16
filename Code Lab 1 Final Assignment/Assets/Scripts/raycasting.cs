using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycasting : MonoBehaviour
{
    private Inventory inventory;
    public GameObject hand;

    public Camera mycam;
    Ray myRay = new Ray();
    // Start is called before the first frame update
    void Start()
    {
        //obj = GetComponent<Collider>();
        inventory = gameObject.GetComponent<Inventory>();
        mycam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            myRay = Camera.main.ScreenPointToRay(Input.mousePosition); 
            PointAtStar();
        }
    }

    void PointAtStar()
    {
        RaycastHit myRayHitInfo = new RaycastHit();
        Debug.DrawLine(gameObject.transform.position, myRayHitInfo.point, Color.red);

        if (Physics.Raycast(myRay , out myRayHitInfo, 1000f))
        {
            Debug.Log(myRayHitInfo.transform.name);


            for (int i = 0; i < inventory.obj.Length; i++)
            {
                //GameManager.instance.Counter++;
                if (myRayHitInfo.collider.tag == "star")
                {
                    //inventory.obj[i].GetComponent<Light>().enabled = false;
                    //Debug.Log(GameManager.instance.score);
                    GameManager.instance.Counter++;
                }
                /*if (myRayHitInfo.collider.tag == "star2")
                {
                    inventory.obj[i].GetComponent<MeshRenderer>().enabled = false;
                }*/
            }

            /*for (int i = 0; i < inventory.obj.Length; i++)
            {
                
            }*/

            /*if (myRayHitInfo.collider.tag == "star")
            {

                GameManager.instance.Counter++;
                for (int i = 0; i < inventory.obj.Length; i++)
                {
                    inventory.obj[i].GetComponent<Light>().enabled = false;
                }
            }

            if (myRayHitInfo.collider.tag == "star2")
            {
                GameManager.instance.Counter++;
                for (int i = 0; i < inventory.obj.Length; i++)
                {
                    inventory.obj[i].GetComponent<MeshRenderer>().enabled = false;
                }
            }*/
        }
    }
}
