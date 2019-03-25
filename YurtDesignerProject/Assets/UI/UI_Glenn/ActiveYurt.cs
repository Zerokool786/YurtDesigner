using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveYurt : MonoBehaviour
{
    /**
     * Class keeps track of active Yurts and logs all changes in design made by user.
     * Allows colours etc to be kept if size changes
     * */

    public GameObject[] yurts = new GameObject[3];//Array of Yurts    
    public Material[] colRoofWall = new Material[3];//Array of colours for roof and wall
    public Material[] colStarcap = new Material[4];//Array of colours for starcap

    GameObject activeYurt;//current yurt active in hierarchy
    GameObject roofStructure;//Roof structure for hiding in build mode
    GameObject roof;//roof material reference of activeyurt
    GameObject walls;//wall material reference of active yurt
    GameObject starcap;//starcap material reference of active

    Material currRoofMat;
    Material currWallMat;
    Material currStarcapMat;

    /// <summary>
     /// Holds current colour of yurt Roof
     /// </summary>
    public Material CurrRoofMat
    {
        get { return currRoofMat; }
        set { currRoofMat = value; }
    }
    /// <summary>
    /// Holds current colour of yurt walls
    /// </summary>
    public Material CurrWallMat
    {
        get { return currWallMat; }
        set { currWallMat = value; }
    }

    /// <summary>
    /// Holds current colour of starcap
    /// </summary>
    public Material CurrStarcapMat
    {
        get { return currStarcapMat; }
        set { currStarcapMat = value; }
    }

    void Start()
    {
        //Set initial values for current yurt materials
        CurrRoofMat = colRoofWall[0];
        CurrWallMat = colRoofWall[1];
        CurrStarcapMat = colStarcap[0];
        
        //Initialise active yurt and yurt materials objects
        SetYurtValues();                       
    }
    

    /// <summary>
    /// Set Yurt values 
    /// WHEN SIZE IS CHANGED AND ON LOAD
    /// </summary>
    public void SetYurtValues()
    {
        IsActive();
        
        if (activeYurt != null)
        {
            roofStructure = activeYurt.transform.Find("RoofStructure").gameObject;

            roof = roofStructure.transform.Find("Roof").gameObject;
            walls = activeYurt.transform.Find("Walls").gameObject;
            starcap =roofStructure.transform.Find("Starcap").gameObject;

            roof.GetComponent<Renderer>().material = CurrRoofMat;
            walls.GetComponent<Renderer>().material = CurrWallMat;
            starcap.GetComponent<Renderer>().material = CurrStarcapMat;
        }            

        Debug.Log("Set values");
     }

    /// <summary>
    /// Check which Yurt is size is active in hierarchy.
    /// Set that as active Yurt.
    /// Call only when game starts or size changed.
    /// Called only through SetYurtValues(). 
    /// </summary>
    public GameObject IsActive()
    {
        if (yurts[0] != null && yurts[0].activeInHierarchy == true)
        {
            activeYurt = yurts[0];
            return activeYurt;
        }
        else if (yurts[1] != null && yurts[0].activeInHierarchy == true)
        {
            activeYurt = yurts[1];
            return activeYurt;
        }
        else if (yurts[2] != null && yurts[0].activeInHierarchy == true)
        {
            activeYurt = yurts[2];
            return activeYurt;
        }
        else
        {
            Debug.Log("No Yurt reference or no active Yurt");
            return null;
        }        
    }

    /// <summary>
    /// Set colour of Walls based on button pressed in OutsideUI.
    /// Sets currRoofMat and roof colour itself.
    /// </summary>
    /// <param name="colIndex"></param>
    public void ColourRoof(int colIndex)
    {
        currRoofMat = colRoofWall[colIndex];

        if (roof)
        {
            roof.GetComponent<Renderer>().material = CurrRoofMat;
        }
    }

    /// <summary>
    /// Set colour of Walls based on button pressed in OutsideUI.
    ///  /// Sets currWallMat and wall colour itself.
    /// </summary>
    /// <param name="colIndex"></param>
    public void ColourWalls(int colIndex)
    {
        CurrWallMat = colRoofWall[colIndex];

        if (walls)
        {
            walls.GetComponent<Renderer>().material = CurrWallMat;
        }
    }

    /// <summary>
    /// Set colour of Starcap based on button pressed in OutsideUI.
    /// Sets currStarcapMat and starcap colour itself.
    /// </summary>
    /// <param name="colIndex"></param>
    public void ColourStarcap(int colIndex)
    {
        CurrStarcapMat = colStarcap[colIndex];

        if (starcap)
        {
            starcap.GetComponent<Renderer>().material = CurrStarcapMat;
        }
    }
       
   
    /**
     * Methods used with roof structure when in build mode
     * */

    /// <summary>
    /// if roofstructure isnt null and is active in hierarchy 
    /// then set to false and hide it.
    /// </summary>
    public void Hide()
    {
        if (roofStructure && roofStructure.activeInHierarchy == true)
        {
            roofStructure.SetActive(false);
        }
    }

    /// <summary>
    /// If roofstructure isnt null and is inactive in hierarchy
    /// then set to true and show it.
    /// </summary>
    public void Show()
    {
        if(roofStructure && roofStructure.activeInHierarchy == false)
        {
            roofStructure.SetActive(true);
        }
    }

}





