using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CameraController : MonoBehaviour
{
    public Vector3 MovePosition;
    public Camera mainCamera;
    //private Vector3[] VectorList;
    //List<Vector3> VectorList;

    public Button cubicleOffice;
    public Button officeCubicle;
    public Button officePaper;
    public Button officeMeet;
    public Button meetOffice;
    public Button paperOffice;
    public Button paperKit;
    public Button kitPaper;

    //PlayerLists playerLists = new PlayerLists();
    public PlayerLists playerLists;

    //Dialogue dialogue = new Dialogue();
    public Dialogue dialogue;

    //public int doorIndex;
    // Start is called before the first frame update
    void Start()
    {
        Button cubicleOfficeBtn = cubicleOffice.GetComponent<Button>();
        cubicleOfficeBtn.onClick.AddListener(CameraMoveOffice);
        Button officeCubicleBtn = officeCubicle.GetComponent<Button>();
        officeCubicleBtn.onClick.AddListener(CameraMoveCubicle);
        Button officePaperBtn = officePaper.GetComponent<Button>();
        officePaperBtn.onClick.AddListener(CameraMovePaper);
        Button officeMeetBtn = officeMeet.GetComponent<Button>();
        officeMeetBtn.onClick.AddListener(CameraMoveMeet);
        Button meetOfficeBtn = meetOffice.GetComponent<Button>();
        meetOfficeBtn.onClick.AddListener(CameraMoveOffice);
        Button paperOfficeBtn = paperOffice.GetComponent<Button>();
        paperOfficeBtn.onClick.AddListener(CameraMoveOffice);
        Button paperKitchenBtn = paperKit.GetComponent<Button>();
        paperKitchenBtn.onClick.AddListener(CameraMoveKitchen);
        Button kitchenPaperBtn = kitPaper.GetComponent<Button>();
        kitchenPaperBtn.onClick.AddListener(CameraMovePaper);
        //VectorList = new List<Vector3>();
        //VectorList[1] = new Vector3(-25f, 0f, 10f);
        //VectorList[2] = new Vector3(0f, 0f, -10f);
        //VectorList[3] = new Vector3(-25f, 20f, -10f);
        CameraMoveCubicle();

    }

    // Update is called once per frame
    void Update()
    {
        if(playerLists.plotProgress == 14)
        {
            print("WINWINWIWNWINWIWNWIWNWINWIWN");
            //win here
        }
        if (playerLists.plotProgress == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                playerLists.plotProgress++;
            }
        }
        //if (Input.GetMouseButtonDown(0))
        //{
        //    var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //    if (Physics2D.OverlapCircle(mousePos, 0.5f))
        //    {
        //        print("DOOR WORKS");
        //        //mainCamera.transform.position = VectorList[doorIndex];
        //        moveCam(doorIndex);
        //    }

        //}
    }
    //void moveCam(int roomIndex)
    //{
    //    if(roomIndex == 1)
    //    {
    //        //CODE FOR EVENT TRIGGER HERE
    //        mainCamera.transform.position = new Vector3(0f, 0f, -10f);

    //    }
    //    else if (roomIndex == 2)
    //    {
    //        mainCamera.transform.position = new Vector3(-25f, 0f, -10f);

    //    }
    //    else if (roomIndex == 3)
    //    {
    //        mainCamera.transform.position = new Vector3(-25f, 20f, -10f);

    //    }
    //    else if (roomIndex == 4)
    //    {

    //    }
    //    else if (roomIndex == 5)
    //    {

    //    }
    //    else if (roomIndex == 6)
    //    {

    //    }
    //    else
    //    {

    //    }

    //}
    void CameraMoveCubicle()
    {
        mainCamera.transform.position = new Vector3(0f, 0f, -10f);
        //CODE FOR EVENT TRIGGER HERE
        //Debug.Log("C" + playerLists.plotProgress);
        if (playerLists.PlotEvent(1) > 0)
        {
            //Debug.Log("D" + playerLists.plotProgress);
            dialogue.MakeDialogue(playerLists.PlotEvent(1));
            //Debug.Log("E" + playerLists.plotProgress);
            playerLists.plotProgress++;
            //Debug.Log("F" + playerLists.plotProgress);

        }

        //Debug.Log("G" + playerLists.plotProgress);

        officeCubicle.gameObject.SetActive(false);
        officePaper.gameObject.SetActive(false);
        officeMeet.gameObject.SetActive(false);
        meetOffice.gameObject.SetActive(false);
        kitPaper.gameObject.SetActive(false);
        paperKit.gameObject.SetActive(false);
        paperOffice.gameObject.SetActive(false);

        cubicleOffice.gameObject.SetActive(true);
    }
    void CameraMoveOffice()
    {
        print("FUNCTIN CALLED");
        mainCamera.transform.position = new Vector3(-25f, 0f, -10f);
        if (playerLists.PlotEvent(2) > 0)
        {
            dialogue.MakeDialogue(playerLists.PlotEvent(2));
            playerLists.plotProgress++;

        }
        paperKit.gameObject.SetActive(false);
        //paperStore.gameObject.SetActive(false);
        paperOffice.gameObject.SetActive(false);
        meetOffice.gameObject.SetActive(false);
        cubicleOffice.gameObject.SetActive(false);
        officePaper.gameObject.SetActive(true);
        officeCubicle.gameObject.SetActive(true);
        officeMeet.gameObject.SetActive(true);
    }
    void CameraMovePaper()
    {
        mainCamera.transform.position = new Vector3(-25f, 20f, -10f);
        //CODE FOR EVENT TRIGGER HERE
        paperKit.gameObject.SetActive(true);
        //paperStore.gameObject.SetActive(true);
        paperOffice.gameObject.SetActive(true);
        officePaper.gameObject.SetActive(false);
        officeCubicle.gameObject.SetActive(false);
        officeMeet.gameObject.SetActive(false);
        kitPaper.gameObject.SetActive(false);
        //storePaper.gameObject.SetActive(false);
    }
    void CameraMoveMeet()
    {
        mainCamera.transform.position = new Vector3(-25f, -15f, -10f);
        print("PROGRESS1" + playerLists.plotProgress);
        if (playerLists.PlotEvent(3) > 0)
        {
            dialogue.MakeDialogue(playerLists.PlotEvent(3));
            playerLists.plotProgress++;
        }
        print("PROGRESS2" + playerLists.plotProgress);

        officePaper.gameObject.SetActive(false);
        officeCubicle.gameObject.SetActive(false);
        officeMeet.gameObject.SetActive(false);
        meetOffice.gameObject.SetActive(true);
    }
    void CameraMoveKitchen()
    {
        mainCamera.transform.position = new Vector3(-50f, 20f, -10f);
        //CODE FOR EVENT TRIGGER HERE
        paperOffice.gameObject.SetActive(false);
        //paperStore.gameObject.SetActive(false);
        paperKit.gameObject.SetActive(false);
        kitPaper.gameObject.SetActive(true);
    }
}


