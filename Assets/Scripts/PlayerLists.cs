using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLists : MonoBehaviour
{
    private int bonusCounter;
    public int plotProgress;
    private int[] list1;
    private int[] list2;
    private int[] list3;
    public int currentList;
    private bool[] list1Items;
    private bool[] list2Items;
    private bool[] list3Items;

    // Start is called before the first frame update
    void Start()
    {
        bonusCounter = 0;
        plotProgress = 1;
        currentList = 0;
        for (int k = 1; k < 21; k++)
        {
            if (k < 6)
            {
                list1Items[k] = false;
            }
            else if (k > 5 && k < 11)
            {
                list2Items[k - 5] = false;
            }
            else
            {
                list3Items[k - 10] = false;
            }
        }
        for (int i = 1; i < 21; i++)
        {
            if (i < 6)
            {
                list1[i] = i;
            }
            else if (i >5 && i < 11)
            {
                list2[i-5] = i;
            }
            else
            {
                list3[i-10] = i;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int PlotEvent(int roomNumber)
    {
        if (roomNumber == 1)
        {
            if (plotProgress == 1)
            {
                //bonusCounter++;
                //if (bonusCounter == 1)
                //{
                //    plotProgress = 2;
                //    return 1;
                //}
                //Debug.Log("A" + plotProgress);
                return plotProgress;
            }
            else if (plotProgress == 6)
            {
                return plotProgress;
            }
            else if (plotProgress == 7 /* && observation list all true completed for storeroom*/)
            {
                return plotProgress;
            }
            else
            {
                return 0;
            }
        }
        else if (roomNumber == 2)
        {
            if (plotProgress == 4)
            {
                return plotProgress;
            }
            else if (plotProgress == 5/* && coffee returns true*/)
            {
                return plotProgress;

            }
            else if (plotProgress == 10)
            {
                return plotProgress;
            }
            else if (plotProgress == 11/* &&puzzles return true*/)
            {
                return plotProgress;

            }
            else
            {
                return 0;
            }
        }

        else if (roomNumber == 3)
        {
            if (plotProgress == 2)
            {
                //Debug.Log("B" + plotProgress);
                return plotProgress;
            }
            else if (plotProgress == 3/*AND PUZZLE DONE*/)
            {
                return plotProgress;
            }
            else if(plotProgress == 8)
            {
                return plotProgress;
            }
            else if (plotProgress == 9/*AND PUZZLE DONE*/)
            {
                return plotProgress;
            }
            else if (plotProgress == 12)
            {
                return plotProgress;
            }
            else if (plotProgress == 13/*AND PUZZLE DONE*/)
            {
                return plotProgress;
            }
            else
            {
                return 0;
            }
        }
        else
        {
            return 0;
        }
    }
    public bool FinishedListChecker(int listNumber)
    {
        if (listNumber == 1)
        {
            foreach (bool l in list1Items)
            {
                if (l)
                {

                }
                else
                {
                    return false;
                }
                
            }
            return true;
        }
        else if (listNumber == 2)
        {
            foreach (bool l in list2Items)
            {
                if (l)
                {

                }
                else
                {
                    return false;
                }

            }
            return true;
        }
        else if (listNumber == 3)
        {
            foreach (bool l in list3Items)
            {
                if (l)
                {

                }
                else
                {
                    return false;
                }

            }
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool ListChecker(int indexValue)
    {
        if (currentList == 1)
        {
            foreach (int j in list1)
            {
                if (indexValue == j)
                {
                    list1Items[j] = true;
                    return true;
                    
                    break;
                }
            }
        }
        else if(currentList == 2)
        {
            foreach (int j in list2)
            {
                if (indexValue == j)
                {
                    list2Items[j - 5] = true;

                    return true;
                    break;
                }
            }
        }
        else if(currentList == 3)
        {
            foreach (int j in list3)
            {
                if (indexValue == j)
                {
                    list3Items[j - 10] = true;

                    return true;
                    break;
                }
            }
        }
        else
        {
            return false;
        }
        return false;
    }
}
