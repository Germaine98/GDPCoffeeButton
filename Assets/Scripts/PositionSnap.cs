using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PositionSnap : MonoBehaviour
{
    public Draggable[] stampArray;
    //public PlayerManager[] docArray;
    public Container[] containerArray;
    public PlayerManager StampManager;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<BoxCollider2D>();
        

        foreach (Draggable i in stampArray)
        {
            foreach (Container j in containerArray)
            {
                if (Vector2.Distance(i.transform.position, j.transform.position) <= 3)
                {
                    //j.filled = true;
                    //print("1here");
                }
                else
                {
                    //print("FILE LOCATION ERROR");
                    //j.filled = false;
                }
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonUp(0))
        {
            NewClick();
            //CheckPositions();
        }
        //TRIGGER NEWCLICK USING MOUSE BUTTON LET GO
    }
    public void NewClick()
    {
        foreach (Draggable i in stampArray)
        {
            foreach (Container j in containerArray)
            {
                if (Vector2.Distance(i.transform.position, j.transform.position) <= 5)
                {
                    //j.filled = true;
                    //print(filled);
                    print("Stamped");
                    i.transform.position = i.originPos;

                    //OnCollisionEnter2D();
                    StampSetter();

                    break;
                }

                else
                {
                    i.transform.position = i.originPos;
                    //SEND OLD FILE TO OLD POSITION
                }
            }
        }
    }

    /* public void StampSetter(Collision2D collision)
     {
         if (collision.gameObject.name == "ApprovalStamp")
         {
             print("setting approved");
             StampManager.SetApproved();
         }
         else if (collision.gameObject.name == "DenialStamp")
         {
             print("setting denied");
             StampManager.SetDenied();
             StampManager.SetDenyReason();
         }
         else if (collision.gameObject.name == "ReasonStamp")
         {
             print("setting reason");
             StampManager.SetReason();
             StampManager.SetDenyReason();
         }
     }*/


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "ApprovalStamp")
        {
            print("setting approved");
            StampManager.SetApproved();
        }
        else if (collision.gameObject.name == "DenialStamp")
        {
            print("setting denied");
            StampManager.SetDenied();
            StampManager.SetDenyReason();
        }
        else if (collision.gameObject.name == "ReasonStamp")
        {
            print("setting reason");
            StampManager.SetReason();
            StampManager.SetDenyReason();
        }
    }
    public void StampSetter()
    {
        if (GameObject.Find("ApprovalStamp"))
        {
            print("setting approved");
            StampManager.SetApproved();
        }
        else if (GameObject.Find("DenialStamp"))
        {
            print("setting denied");
            StampManager.SetDenied();
            StampManager.SetDenyReason();
        }
        else if (GameObject.Find("ReasonStamp"))
        {
            print("setting reason");
            StampManager.SetReason();
            StampManager.SetDenyReason();
        }
    }

    /*public void CheckPositions()
    {
        foreach (Draggable i in stampArray)
        {
            foreach (PlayerManager j in docArray)
            {
                if (i.transform.position == j.transform.position)
                {
                    if (i.finalValue == j.answerValue)
                    {
                        correctCount = correctCount + 1;
                    }
                }
            }
        }

    }*/
}