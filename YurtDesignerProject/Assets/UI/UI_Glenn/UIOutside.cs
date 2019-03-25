using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIOutside : MonoBehaviour
{    
    ActiveYurt activeYurt;
    GameObject yurt;

    private void Start()
    {       
        activeYurt = GameObject.Find("Yurts").GetComponent<ActiveYurt>();//Get ActiveYurt script/object
    }

    /// <summary>
    /// Cream wall colour button pressed
    /// Calls ColourWall() method of active yurt.
    /// Passes colour index
    /// </summary>
    public void SetColourWallCream()
    {
        activeYurt.ColourWalls(0);        
    }

    /// <summary>
    /// Olive wall colour button pressed
    /// Calls ColourWall() method of active yurt.
    /// Passes colour index
    /// </summary>
    public void SetColourWallOlive()
    {
        activeYurt.ColourWalls(1);       
    }

    /// <summary>
    /// Sand wall colour button pressed
    /// Calls ColourWall() method of active yurt.
    /// Passes colour index
    /// </summary>
    public void SetColourWallSand()
    {
        activeYurt.ColourWalls(2);        
    }

    /// <summary>
    /// Cream roof colour button pressed
    /// Calls ColourRoof() method of active yurt.
    /// Passes colour index
    /// </summary>
    public void SetColourRoofCream()
    {
        activeYurt.ColourRoof(0);       
    }

    /// <summary>
    /// Olive roof colour button pressed
    /// Calls ColourRoof() method of active yurt.
    /// Passes colour index
    /// </summary>
    public void SetColourRoofOlive()
    {
        activeYurt.ColourRoof(1);        
    }

    /// <summary>
    /// Sand roof colour button pressed
    /// Calls ColourRoof() method of active yurt.
    /// Passes colour index
    /// </summary>
    public void SetColourRoofSand()
    {
        activeYurt.ColourRoof(2);       
    }

    /// <summary>
    /// Maroon Starcap colour button pressed
    /// Calls ColourStarcap() method of active yurt.
    /// Passes colour index
    /// </summary>
    public void SetColourCapMaroon()
    {
        activeYurt.ColourStarcap(0);        
    }

    /// <summary>
    /// Blue Starcap colour button pressed
    /// Calls ColourStarcap() method of active yurt.
    /// Passes colour index
    /// </summary>
    public void SetColourCapBlue()
    {
        activeYurt.ColourStarcap(1);       
    }

    /// <summary>
    /// Navy Starcap colour button pressed
    /// Calls ColourStarcap() method of active yurt.
    /// Passes colour index
    /// </summary>
    public void SetColourCapNavy()
    {
        activeYurt.ColourStarcap(2);        
    }

    /// <summary>
    /// Light Navy Starcap colour button pressed
    /// Calls ColourStarcap() method of active yurt.
    /// Passes colour index
    /// </summary>
    public void SetColourCapLightNavy()
    {
        activeYurt.ColourStarcap(3);        
    }

    /// <summary>
    /// Call Show() method of ActiveYurt
    /// </summary>
    public void ShowRoof()
    {
        activeYurt.Show();
    }
}


