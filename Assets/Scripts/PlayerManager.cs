using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;

    public string correctStamp;
    public string currentStatus;
    public int docsProcessed;
    public int docsCorrect;

    [SerializeField]
    public GameObject[] documents;
    //public List<DocumentData> documents;

    /*public class DocumentData
    {
        public string name;
        public GameObject document;
        public bool makeSet = false;
*//*        public string correctStamp;
        public string currentStatus;*//*
    }*/


    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance == null) Destroy(gameObject);
    }

    void AssignDocuments()
    {
        /*for (int i = 0; i < documents.Count; i++)
        {
            documents[i].document.GetComponent<Collider2D>().enabled = false;
        }*/
    }

    // Start is called before the first frame update
    void Start()
    {
        //creates array with different documents in it when game starts up
        documents = new GameObject[9];

        documents[0] = GameObject.Find("Doc1");
        documents[1] = GameObject.Find("Doc2");
        documents[2] = GameObject.Find("Doc3");
        documents[3] = GameObject.Find("Doc4");
        documents[4] = GameObject.Find("Doc5");
        documents[5] = GameObject.Find("Doc6");
        documents[6] = GameObject.Find("Doc7");
        documents[7] = GameObject.Find("Doc8");
        documents[8] = GameObject.Find("Doc9");

        docsProcessed = 0;
        docsCorrect = 0;

        GameObject.Find("Doc1").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("Doc2").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("Doc3").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("Doc4").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("Doc5").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("Doc6").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("Doc7").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("Doc8").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("Doc9").GetComponent<SpriteRenderer>().enabled = false;


        /* int k = 0;
         while (k < DocumentCount)
         {
             int randomVal = Random.Range(0, documents.Count);
             if (!documents[randomVal].makeSet)
             {
                 documents[randomVal].document.name = "" + k; //ensure when any object is tapped,
                                                                      //object match the list
                 documents[randomVal].makeSet = true;

                 documents[randomVal].document.GetComponent<Collider2D>().enabled = true;

                 k++;


             }
         }*/

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButton(0))  
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector3.zero);

            if (hit && hit.collider != null)
            {
                //when stack of papers on the right is clicked, a new document is instantiated for the player 
                print("Document given");
               
                documents[docsProcessed].GetComponent<SpriteRenderer>().enabled = true;

                //**change this to switch statement with docsProcessed number instead**
                if (GameObject.Find("Doc1"))
                {
                    //Case 1
                    print("Doc 1 retrieved");
                    correctStamp = "approved";
                    currentStatus = "";
                }
                else if (GameObject.Find("Doc2"))
                {
                    //Case 2
                    print("Doc 2 retrieved");
                    correctStamp = "approved";
                    currentStatus = "";
                }
                else if (GameObject.Find("Doc3"))
                {
                    //Case 3
                    print("Doc 3 retrieved");
                    correctStamp = "approved";
                    currentStatus = "";
                }
                else if (GameObject.Find("Doc4"))
                {
                    //Case 4
                    print("Doc 4 retrieved");
                    correctStamp = "denied";
                    currentStatus = "";
                }
                else if (GameObject.Find("Doc5"))
                {
                    //Case 5
                    print("Doc 5 retrieved");
                    correctStamp = "approved";
                    currentStatus = "";
                }
                else if (GameObject.Find("Doc6"))
                {
                    //Case 6
                    print("Doc 6 retrieved");
                    correctStamp = "denied";
                    currentStatus = "";
                }
                else if (GameObject.Find("Doc7"))
                {
                    //Case 7
                    print("Doc 7 retrieved");
                    correctStamp = "denyreason";
                    currentStatus = "";
                }
                else if (GameObject.Find("Doc8"))
                {
                    //Case 8
                    print("Doc 8 retrieved");
                    correctStamp = "denyreason";
                    currentStatus = "";
                }
                else if (GameObject.Find("Doc9"))
                {
                    //Case 9
                    print("Doc 9 retrieved");
                    correctStamp = "approved";
                    currentStatus = "";
                }

            }
        }
    }

    public void SetApproved()
    {
        print("status set as approved");
        currentStatus = "approved";
    }

    public void SetDenied()
    {
        if (currentStatus == "reason")
        {
            SetDenyReason();
        }
        else
        {
            print("status set as denied");
            currentStatus = "denied";
        }
    }

    public void SetReason()
    {
        print("status set as reason");
        currentStatus = "reason";
    }

    public void SetDenyReason()
    {
        if (currentStatus == "denied" || currentStatus == "reason")
        {
            print("status set as denied with reason");
            currentStatus = "denyreason";
        }
        else
        {
            SetReason();
        }
    }

    public void CheckStamp()
    {
        if (currentStatus == "" || currentStatus == "reason")
        {
            print("uhhh stamp something first???");
        }
        else if (currentStatus == correctStamp)
        {
            documents[docsProcessed].GetComponent<SpriteRenderer>().enabled = false;
            docsProcessed += 1;
            docsCorrect += 1;
        }
        else
        {
            documents[docsProcessed].GetComponent<SpriteRenderer>().enabled = false;
            docsProcessed += 1;
        }
    }
}
