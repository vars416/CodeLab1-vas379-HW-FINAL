using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycasting : MonoBehaviour
{
    private Inventory inventory;

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
        if (Input.GetMouseButton(0))
        {
            myRay = Camera.main.ScreenPointToRay(Input.mousePosition); 
            PointAtStar();
        }
    }

    void PointAtStar()
    {
        RaycastHit myRayHitInfo = new RaycastHit();
        

        if (Physics.Raycast(myRay , out myRayHitInfo, 100f))
        {
            Debug.Log(myRayHitInfo.transform.name);
            Debug.DrawLine(gameObject.transform.position, myRayHitInfo.point, Color.red);

            for (int i = 0; i < inventory.obj.Length; i++)
            {
                if (myRayHitInfo.collider.tag == "star")
                {
                    inventory.obj[i].GetComponent<Light>().enabled = false;
                }
                else if (myRayHitInfo.collider.tag == "star2")
                {
                    inventory.obj[i].GetComponent<MeshRenderer>().enabled = false;
                }
            }

            /*for (int i = 0; i < inventory.obj.Length; i++)
            {
                
            }*/
            /*if (myRayHitInfo.collider.tag == "star")
            {
                for (int i = 0; i < inventory.obj.Length; i++)
                {
                    inventory.obj[i].GetComponent<Light>().enabled = false;
                }
            }

            if (myRayHitInfo.collider.tag == "star2")
            {
                for (int i = 0; i < inventory.obj.Length; i++)
                {
                    inventory.obj[i].GetComponent<MeshRenderer>().enabled = false;
                }
            }*/
        }
    }
}
