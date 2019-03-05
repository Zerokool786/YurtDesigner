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
		if(SelectionPanelObj == null)
        {
            Debug.Log("Selection Panel is not set");
        }

		anim = SelectionPanelObj.GetComponent<Animator>();
    }
    
	public void ShowHidePanel(){
		
		Debug.Log ("I is a button");

		if (isHidden) {
			
			Debug.Log ("Show panel");
			isHidden = false;
            			
            anim.Play("SelectionPanelAnim");

		}else{
			
			Debug.Log ("Hide Panel");
			isHidden = true;

            anim.Play("SelectionPanelAnimHide");
		}
	}
}
