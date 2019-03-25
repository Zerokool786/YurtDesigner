using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UI_Glenn : MonoBehaviour
{
	bool isHidden = false;
	public GameObject SelectionPanelObj;
    private Animator anim; 

    // Start is called before the first frame update
    void Start()
    {
        //Checks there is a selection panel in scene
		if(SelectionPanelObj == null)
        {
            Debug.Log("Selection Panel is not set");
        }

		anim = SelectionPanelObj.GetComponent<Animator>();//Gets animation 
    }

    /// <summary>
    /// Plays the show of hide selection anel animation
    /// </summary>
	public void ShowHidePanel()
    {
		if (isHidden)
        {		
			isHidden = false;            			
            anim.Play("SelectionPanelAnim");
		}
        else
        {			
			isHidden = true;
            anim.Play("SelectionPanelAnimHide");
		}
	}
}
