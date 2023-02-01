using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    //public GameObject File;
    public int indexNumber;
    public GameObject clicks;
    //public PlayerLists indexList;
    private Vector2 worldPosition;
    private Vector2 screenPosition;

    void Start()
    {
        gameObject.tag = "File";
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //screenPosition = Input.GetTouch(0).position;

            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (CollectableChecker(mousePos))
            {
                print("YES I WIN");
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
                spriteRenderer.gameObject.SetActive(false);
                //if (indexList.ListChecker(indexNumber))
                //{
                //    //INCLUDE UI COLOR CHANGE CODE HERE
                //    gameObject.SetActive(false);
                //}
            }
        }

    }
    public bool CollectableChecker(Vector3 mouseLocation)
    {
        print("BOOMBOOMBOOM");
        //RaycastHit hit;
        //Debug.DrawRay(clicks.transform.position, transform.forward * 1000, Color.red, 100, false);
        //if (Physics.SphereCast(clicks.transform.position, 5f, transform.forward*1000, out hit, 1000))
        if (Physics2D.CircleCast(mouseLocation, 0.5f, transform.forward))
        {
            print("ITWORKSSSSSSS");
            return true;
        }
        return false;







        //worldPosition = Camera.main.ScreenToWorldPoint(mouseLocation);

        //RaycastHit2D hit = Physics2D.Raycast(worldPosition, Vector2.zero);
        //if (hit.collider != null)
        //{

        //    print("ITWORKSSSSSSS");
        //    return true;
        //}
        //return false;

    }
}

