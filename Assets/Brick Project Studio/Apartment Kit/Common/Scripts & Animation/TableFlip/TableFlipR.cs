using OVR.OpenVR;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableFlipR: MonoBehaviour {

	public Animator FlipR;
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
                reportDoorCheck.Invoke(openedAtLeastOnce);
                openedAtLeastOnce = true;
                StartCoroutine(opening());

            }
            else if (open == true)
            {

                StartCoroutine(closing());

            }
        }
    }

    IEnumerator opening(){
		print ("you are opening the door");
        FlipR.Play ("Rup");
		open = true;
		yield return new WaitForSeconds (.5f);
	}

	IEnumerator closing(){
		print ("you are closing the door");
        FlipR.Play ("Rdown");
		open = false;
		yield return new WaitForSeconds (.5f);
	}


}

