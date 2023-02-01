using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoffeePuzzle : MonoBehaviour
{
    public Button btn0, btn1, btn2, btn3, btn4;

    void Start()
    {
        btn0.onClick.AddListener(TaskOnClick0); //coffee button
        btn1.onClick.AddListener(TaskOnClick);
        btn2.onClick.AddListener(TaskOnClick2);
        btn3.onClick.AddListener(TaskOnClick3);
        btn4.onClick.AddListener(TaskOnClick4);

        /*GameObject.Find("coffee background").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("StrawberryCup").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("ChocolateCup").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("HazelnutCup").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("BlueberryCup").GetComponent<SpriteRenderer>().enabled = false;

        GameObject.Find("StrawberryButton").GetComponent<Image>().enabled = false;
        GameObject.Find("ChocolateButton").GetComponent<Image>().enabled = false;
        GameObject.Find("HazelnutButton").GetComponent<Image>().enabled = false;
        GameObject.Find("BlueberryButton").GetComponent<Image>().enabled = false;

        GameObject.Find("StrawberryCapsule").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("ChocolateCapsule").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("HazelnutCapsule").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("BlueberryCapsule").GetComponent<SpriteRenderer>().enabled = false;*/
    }

    void TaskOnClick0()
    {
        Debug.Log("Start coffee puzzle");

        Invoke("StartCoffeePuzzle", 1f);


    }

    void TaskOnClick()
    {
        Debug.Log("Clicked on strawberry!");

        Invoke("MakeSDrink", 3f);
        Invoke("DoneWithSDrink", 6f);

    }

    void TaskOnClick2()
    {
        Debug.Log("Clicked on chocolate!");

        Invoke("MakeCDrink", 3f);
        Invoke("DoneWithCDrink", 6f);


    }

    void TaskOnClick3()
    {
        Debug.Log("Clicked on hazelnut!");

        Invoke("MakeHDrink", 3f);
        Invoke("DoneWithHDrink", 6f);


    }

    void TaskOnClick4()
    {
        Debug.Log("Clicked on blueberry!");

        Invoke("MakeBDrink", 3f);
        Invoke("DoneWithBDrink", 6f);

    }

    void StartCoffeePuzzle() //press coffee button, make coffee background and buttons appear
    {
        GameObject.Find("coffee background").GetComponent<SpriteRenderer>().enabled = true;
        GameObject.Find("StrawberryButton").GetComponent<Image>().enabled = true;
        GameObject.Find("ChocolateButton").GetComponent<Image>().enabled = true;
        GameObject.Find("HazelnutButton").GetComponent<Image>().enabled = true;
        GameObject.Find("BlueberryButton").GetComponent<Image>().enabled = true;

    }




    void MakeSDrink() //press strawberry button, capsule appear
    {
        GameObject.Find("StrawberryCapsule").GetComponent<SpriteRenderer>().enabled = true;

    }

    void MakeCDrink() //press choc button, capsule appear
    {
        GameObject.Find("ChocolateCapsule").GetComponent<SpriteRenderer>().enabled = true;

    }


    void MakeHDrink() //press hazelnut button, capsule appear
    {
        GameObject.Find("HazelnutCapsule").GetComponent<SpriteRenderer>().enabled = true;

    }

    void MakeBDrink() //press hazelnut button, capsule appear
    {
        GameObject.Find("BlueberryCapsule").GetComponent<SpriteRenderer>().enabled = true;

    }



    void DoneWithCDrink() //chocolate capsule gone, drink appear
    {
        GameObject.Find("ChocolateCapsule").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("ChocolateCup").GetComponent<SpriteRenderer>().enabled = true;


    }

    void DoneWithSDrink() // strawberry capsule gone, drink appear
    {
        GameObject.Find("StrawberryCapsule").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("StrawberryCup").GetComponent<SpriteRenderer>().enabled = true;

    }

    void DoneWithHDrink() // hazelnut capsule gone, drink appear
    {
        GameObject.Find("HazelnutCapsule").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("HazelnutCup").GetComponent<SpriteRenderer>().enabled = true;

    }

    void DoneWithBDrink() // hazelnut capsule gone, drink appear
    {
        GameObject.Find("BlueberryCapsule").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("BlueberryCup").GetComponent<SpriteRenderer>().enabled = true;

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject.Find("StrawberryCup").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("ChocolateCup").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("HazelnutCup").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("BlueberryCup").GetComponent<SpriteRenderer>().enabled = false;


            GameObject.Find("coffee background").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("StrawberryButton").GetComponent<Image>().enabled = false;
            GameObject.Find("ChocolateButton").GetComponent<Image>().enabled = false;
            GameObject.Find("HazelnutButton").GetComponent<Image>().enabled = false;
            GameObject.Find("BlueberryButton").GetComponent<Image>().enabled = false; //coffee background and buttons disappear

            Debug.Log("Take drink!");
        }

    }





}
