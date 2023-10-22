using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableFlipL: MonoBehaviour {

	public Animator FlipL;
	public bool open;
	public Transform Player;
    public static event Action<bool> reportDoorCheck;
    private bool openedAtLeastOnce = false;

    void Start (){
		open = false;
	}

    private void OnEnable()
    {
        debugScript.openButtonPressed += OpenUp;
        
    }

    private void OnDisable()
    {
        debugScript.openButtonPressed -= OpenUp;
    }


    void OpenUp()
    {
        {
            Debug.Log("Count doors.");
            if (open == false)
            {
                Debug.Log("Before Invoke");
                reportDoorCheck.Invoke(openedAtLeastOnce);
                Debug.Log("After Invoke");
                openedAtLeastOnce = true;
                Debug.Log("Before Coroutine");
                StartCoroutine(opening());
                Debug.Log("After Coroutine");

            }
            else if (open == true)
            {

                StartCoroutine(closing());

            }
        }
    }



	IEnumerator opening(){
		print ("you are opening the door");
        FlipL.Play ("Lup");
		open = true;
		yield return new WaitForSeconds (.5f);
	}

	IEnumerator closing(){
		print ("you are closing the door");
        FlipL.Play ("Ldown");
		open = false;
		yield return new WaitForSeconds (.5f);
	}


}



