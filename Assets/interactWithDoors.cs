using UnityEngine;
using OculusSampleFramework;

public class OculusControllerInteraction : MonoBehaviour
{
    //public OVRCameraRig ovrCameraRig; // Reference to the OVRCameraRig in your scene
    public GameObject openDoorRayOrigin;
    public float raycastDistance = 5.0f; // Maximum distance for the raycast

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Debug.Log("PrimaryIndexTrigger");
            // When the trigger is pulled, cast a ray from the Oculus controller
            //Ray ray = new Ray(ovrCameraRig.centerEyeAnchor.position, ovrCameraRig.centerEyeAnchor.forward);
            Ray ray = new Ray(openDoorRayOrigin.transform.position, openDoorRayOrigin.transform.forward);
            RaycastHit hit;

            // Draw the ray for debugging
            Debug.DrawRay(ray.origin, ray.direction * raycastDistance, Color.blue, 3.0f);

            Debug.Log("Did it hit sxomething:" + Physics.Raycast(ray, out hit, raycastDistance));
            Debug.Log("Does it have Door tag:" + hit.collider.CompareTag("Door"));
            Debug.Log("Name of Object:" + hit.collider.name);

            if (Physics.Raycast(ray, out hit, raycastDistance) && hit.collider.CompareTag("Door"))
            {
                Debug.Log("Ray hit something");
                // Check the tag of the raycast hit object and call the "OpenUp" function
                hit.collider.gameObject.SendMessage("OpenUp", SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}
