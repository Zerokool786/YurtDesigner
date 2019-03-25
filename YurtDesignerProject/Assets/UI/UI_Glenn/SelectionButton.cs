using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionButton : MonoBehaviour
{
    public GameObject content;
    
    /// <summary>
    /// Sets the scrollrect list content to active or inactive on button press
    /// </summary>
    public void ShowHideContent()
    {
        if(content.activeInHierarchy == true)
        {
            content.SetActive(false);

        }else if(content.activeInHierarchy == false)
        {
            content.SetActive(true);
        }
    }
}
