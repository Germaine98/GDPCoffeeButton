using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    //public static Dialogue instance; //static because we want all instances of dialogue to access this

    //private void Awake()
    //{
    //    if(instance == null)
    //    {
    //        instance = this;
    //        DontDestroyOnLoad(this);
    //    } else if (instance != null)
    //    {
    //        Destroy(this);
    //    }

    //}

    public TextMeshProUGUI textComponent;
    public int indexComponentTrigger;

    public GameObject npc;
    //public GameObject dialogueBox;
    private SpriteRenderer npcSprite;

    private int dialogueQuestSep;

    List<List<string>> lineDialogue = new List<List<string>>();
    
    

    public string[] lines;
    public string[] lines2;
    public string[] lines3;
    public string[] lines4;
    public string[] lines5;
    public string[] lines6;
    public string[] lines7;
    public string[] lines8;
    public string[] lines9;
    public string[] lines10;
    public string[] lines11;
    public string[] lines12;
    public string[] lines13;



    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public Sprite sprite7;
    public Sprite sprite8;
    public Sprite sprite9;
    public Sprite sprite10;
    public Sprite sprite11;
    public Sprite sprite12;
    public Sprite sprite13;
    public float textSpeed;
    //public GameManager GameManager;



    private int index;


    // Start is called before the first frame update
    void Start()
    {
        dialogueQuestSep = 1;
        textComponent.text = string.Empty;
        lineDialogue.Add(new List<string>(lines));

        lineDialogue.Add(new List<string>(lines));
        Debug.Log(lineDialogue[0][0]);
        lineDialogue.Add(new List<string>(lines2));
        Debug.Log(lineDialogue[0][1]);
        lineDialogue.Add(new List<string>(lines3));
        lineDialogue.Add(new List<string>(lines4));
        lineDialogue.Add(new List<string>(lines5));
        lineDialogue.Add(new List<string>(lines6));
        lineDialogue.Add(new List<string>(lines7));
        lineDialogue.Add(new List<string>(lines8));
        lineDialogue.Add(new List<string>(lines9));
        lineDialogue.Add(new List<string>(lines10));
        lineDialogue.Add(new List<string>(lines11));
        lineDialogue.Add(new List<string>(lines12));
        lineDialogue.Add(new List<string>(lines13));

        GameObject.Find("DialogueBox").GetComponent<Image>().enabled = false; //set dialogue box to inactive
        
        npc.gameObject.SetActive(false);
        SpriteRenderer npcSprite = npc.GetComponent<SpriteRenderer>();

        GameObject.Find("Worker1").GetComponent<SpriteRenderer>().enabled = false;




        //StartCoroutine(StartDialogue());


    }

    public void EnableAfterDelay()
    {

        npc.gameObject.SetActive(true);
        textComponent.gameObject.SetActive(true);
        //dialogueBox.gameObject.SetActive(true);

        //GameObject.Find("DialogueBox").GetComponent<Image>().enabled = true; //set dialogue box active

        //GameObject.Find("Worker1").GetComponent<SpriteRenderer>().enabled = true; //set workr1 to be active

        Debug.Log("shown!");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && npc.gameObject.activeInHierarchy == true) //if click on box
        {

            if (textComponent.text == lineDialogue[dialogueQuestSep][index]) //text will be faster and complete
            {
                print("Dialogue moved!");
                NextLine(dialogueQuestSep);
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lineDialogue[dialogueQuestSep][index];
            }
        }

        //if (Input.GetKeyDown("space"))//ADD EVENT TRIGGER HERE
        //{
        //    Invoke("EnableAfterDelay", 0f);
        //    StartCoroutine(StartDialogue());
        //}


    }

    public void MakeDialogue(int dialogueQuest)
    {
        Invoke("EnableAfterDelay", 0f);
        dialogueQuestSep = dialogueQuest;
        StartCoroutine(StartDialogue(dialogueQuest));
    }

    IEnumerator StartDialogue(int dialogueQuest2)
    {
        index = 0;
        yield return new WaitForSeconds(1f); //begin talking

        StartCoroutine(TypeLine(dialogueQuest2));


    }

    IEnumerator TypeLine(int dialogueQuest3)
    {
        foreach (char c in lineDialogue[dialogueQuest3][index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine(int dialogueQuestNext)
    {
        if (index < lineDialogue[dialogueQuestNext].Count/*[index].Length*/ - 1)
        {
            print(index);
            Debug.Log("LENGTH "+lineDialogue[dialogueQuestNext][index].Length);
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine(dialogueQuestNext));
        }
        else
        {
            //dialogueBox.gameObject.SetActive(false);
            npc.gameObject.SetActive(false);
            textComponent.gameObject.SetActive(false);
            dialogueQuestSep = 15;
            //gameObject.SetActive(false); //dialogue box disabled
            //GameObject.Find("Worker1").GetComponent<SpriteRenderer>().enabled = false;


        }
    }
}