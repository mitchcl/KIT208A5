using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
	public class Drawer_Pull_Zopp : MonoBehaviour
	{

		public Animator pull;
		public bool open;
		public Transform Player;
        public static event Action<bool> reportDoorCheck;
        private bool openedAtLeastOnce = false;

        void Start()
		{
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
                Debug.Log("picked up by TableFlip.");
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

        IEnumerator opening()
		{
			print("you are opening the door");
			pull.Play("openpullopp");
			open = true;
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			print("you are closing the door");
			pull.Play("closepushopp");
			open = false;
			yield return new WaitForSeconds(.5f);
		}


	}
}