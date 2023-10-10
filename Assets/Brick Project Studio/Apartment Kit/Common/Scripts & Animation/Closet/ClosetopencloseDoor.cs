using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
	public class ClosetopencloseDoor : MonoBehaviour
	{

		public Animator Closetopenandclose;
		public bool open;
		public Transform Player;

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
			Closetopenandclose.Play("ClosetOpening");
			open = true;
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			print("you are closing the door");
			Closetopenandclose.Play("ClosetClosing");
			open = false;
			yield return new WaitForSeconds(.5f);
		}


	}
}