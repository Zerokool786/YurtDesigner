using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InsideUI : MonoBehaviour
{
    ActiveYurt activeYurt;
    
    private void Start()
    {
        activeYurt = GameObject.Find("Yurts").GetComponent<ActiveYurt>();//Get ActieYurt script/obj
    }

    /// <summary>
    /// Call Hide() method of ActiveYurt
    /// </summary>
    public void HideRoof()
    {
        activeYurt.Hide();
    }    
}

