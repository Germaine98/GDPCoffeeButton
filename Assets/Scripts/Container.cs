using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{

    public GameObject[] fileArray;
    public bool filled;
    // Start is called before the first frame update
    void Start()
    {
        //foreach (GameObject i in fileArray)
        //{
        //    if (Vector2.Distance(i.transform.position, transform.position) <= 2.2)
        //    {
        //        i.transform.position = transform.position;
        //        filled = true;
        //        print("1here");
        //    }
        //    else
        //    {
        //        print("FILE LOCATION ERROR");
        //        filled = false;
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    NewClick();
        //}
        //TRIGGER NEWCLICK USING MOUSE BUTTON LET GO
    }

    public void ClickIntoPlace(GameObject usedFile)
    {


        if (Vector2.Distance(usedFile.transform.position, transform.position) <= 2.2)
        {
            if (filled != true)
            {
                usedFile.transform.position = transform.position;
                //FileSort();
            }
            else
            {
                //ReturnToOriginalPosition(usedFile);
            }
        }
        else
        {
            //ReturnToOriginalPosition(usedFile);
        }

    }
    //public void NewClick()
    //{
    //    foreach (GameObject i in fileArray)
    //    {
    //        if (Vector2.Distance(i.transform.position, transform.position) <= 2.2 /CHANGE NUMBER HERE/ && filled == false)
    //        {
    //            i.transform.position = transform.position;
    //            filled = true;
    //            print(filled);
    //        }
    //        else
    //        {
    //            //i.transform.position = ;
    //            //SEND OLD FILE TO OLD POSITION
    //            //print("FILE LOCATION ERROR");
    //            filled = false;
    //        }
    //    }
    //}
}