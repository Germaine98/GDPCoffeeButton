using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public GameObject circle;
    public Sprite blueCircle;
    public Sprite greenCircle;
    public SpriteRenderer checkerRenderer;
    private Animator anim;
    Collectable collectable = new Collectable();
    // Start is called before the first frame update
    void Start()
    {
        circle.transform.position = new Vector3(0f, 10f,0f);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            var mouseLoca = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            circle.transform.position = mouseLoca + new Vector3(0f, -0.75f, 10f);//6.43f
            //Checking(circle.transform.position)
            //if (collectable.CollectableChecker(mouseLoca))
            //{
            //    checkerRenderer.sprite = greenCircle;
            //    print("GREEN");
            //}
            //else
            //{
            //    checkerRenderer.sprite = blueCircle;
            //    print("BLUE");
            //}
        }
    }
}