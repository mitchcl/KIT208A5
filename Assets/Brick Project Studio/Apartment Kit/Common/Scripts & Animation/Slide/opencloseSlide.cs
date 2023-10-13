using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
	public class opencloseSlide : MonoBehaviour
	{

		public Animator openandclosewindow;
		public bool open;
		public Transform Player;
        public static event Action reportDoorCheck;

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
                    reportDoorCheck.Invoke();
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
			print("you are opening the Window");
			openandclosewindow.Play("OpeningSlide");
			open = true;
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			print("you are closing the Window");
			openandclosewindow.Play("ClosingSlide");
			open = false;
			yield return new WaitForSeconds(.5f);
		}


	}
}