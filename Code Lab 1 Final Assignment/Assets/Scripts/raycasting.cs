using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycasting : MonoBehaviour
{
    private Inventory inventory; //access static object- instance
    public GameObject hand; //get a hand gameobject

    public Camera mycam; //get camera in player
    Ray myRay = new Ray(); //declare a new ray named myRay
    
    // Start is called before the first frame update
    void Start()
    {
        //obj = GetComponent<Collider>();
        inventory = gameObject.GetComponent<Inventory>(); //get inventory
        mycam = GetComponent<Camera>(); //get camera
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //on clicking lmb
        {
            myRay = Camera.main.ScreenPointToRay(Input.mousePosition); //hit ray camera to center of viewport
            PointAtStar(); //call PointAtStar
        }
    }

    void PointAtStar() 
    {
        RaycastHit myRayHitInfo = new RaycastHit(); //store info of casted ray
        Debug.DrawLine(gameObject.transform.position, myRayHitInfo.point, Color.red); //draw line for raycast in editor

        if (Physics.Raycast(myRay , out myRayHitInfo, 1000f)) //define distance for casted ray
        {
            Debug.Log(myRayHitInfo.transform.name); //write name of hit gameobject in console


            for (int i = 0; i < inventory.obj.Length; i++) //go through length of obj. This is obsolete since I am no longer using the array
            {
                if (myRayHitInfo.collider.tag == "star") //if tag is star
                {
                    GameManager.instance.Counter++; //increase the score. (For some reason, the score is increasing by two numbers)
                }              
            }
        }
    }
}
