using UnityEngine;
using OculusSampleFramework;
using Meta.WitAi;

public class OculusControllerInteraction : MonoBehaviour
{
    //public OVRCameraRig ovrCameraRig; // Reference to the OVRCameraRig in your scene
    public GameObject openDoorRayOrigin0;
    public GameObject openDoorRayOrigin1;
    public GameObject openDoorRayOrigin2;
    public GameObject openDoorRayOrigin3;
    public GameObject openDoorRayOrigin4;
    public float raycastDistance; // Maximum distance for the raycast

    private InventoryController inventoryController;


    void Start()
    {
        inventoryController = GetComponent<InventoryController>();
    }


    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            bool triggered = false;
            Debug.Log("PrimaryIndexTrigger");
            // When the trigger is pulled, cast a ray from the Oculus controller
            //Ray ray = new Ray(ovrCameraRig.centerEyeAnchor.position, ovrCameraRig.centerEyeAnchor.forward);
            Ray ray0 = new Ray(openDoorRayOrigin1.transform.position, openDoorRayOrigin1.transform.forward);
            Ray ray1 = new Ray(openDoorRayOrigin1.transform.position, openDoorRayOrigin1.transform.forward);
            Ray ray2 = new Ray(openDoorRayOrigin2.transform.position, openDoorRayOrigin2.transform.forward);
            Ray ray3 = new Ray(openDoorRayOrigin3.transform.position, openDoorRayOrigin3.transform.forward);
            Ray ray4 = new Ray(openDoorRayOrigin4.transform.position, openDoorRayOrigin4.transform.forward);
            RaycastHit hit0;
            RaycastHit hit1;
            RaycastHit hit2;
            RaycastHit hit3;
            RaycastHit hit4;

            // Draw the ray for debugging
            Debug.DrawRay(ray0.origin, ray0.direction * raycastDistance, Color.blue, 3.0f);
            Debug.DrawRay(ray1.origin, ray1.direction * raycastDistance, Color.blue, 3.0f);
            Debug.DrawRay(ray2.origin, ray2.direction * raycastDistance, Color.blue, 3.0f);
            Debug.DrawRay(ray3.origin, ray3.direction * raycastDistance, Color.blue, 3.0f);
            Debug.DrawRay(ray4.origin, ray4.direction * raycastDistance, Color.blue, 3.0f);

            Debug.Log("Did it hit sxomething:" + Physics.Raycast(ray0, out hit0, raycastDistance));
            Debug.Log("Does it have Door tag:" + hit0.collider.CompareTag("Door"));
            Debug.Log("Does it have Equipment tag:" + hit0.collider.CompareTag("Equipment"));
            Debug.Log("Name of Object:" + hit0.collider.name);

            if ((Physics.Raycast(ray0, out hit0, raycastDistance)) && hit0.collider.CompareTag("Door") && (triggered == false))
            {
                Debug.Log("Name of Object:" + hit0.collider.name);
                // Check the tag of the raycast hit object and call the "OpenUp" function
                hit0.collider.gameObject.SendMessage("OpenUp", SendMessageOptions.DontRequireReceiver);
                triggered = true;
            }
            else if ((Physics.Raycast(ray1, out hit1, raycastDistance)) && hit1.collider.CompareTag("Door") && (triggered == false))
            {
                Debug.Log("Name of Object:" + hit1.collider.name);
                // Check the tag of the raycast hit object and call the "OpenUp" function
                hit1.collider.gameObject.SendMessage("OpenUp", SendMessageOptions.DontRequireReceiver);
                triggered = true;
            }
            else if (((Physics.Raycast(ray2, out hit2, raycastDistance)) && hit2.collider.CompareTag("Door")) && (triggered == false))
            {
                Debug.Log("Name of Object:" + hit2.collider.name);
                hit2.collider.gameObject.SendMessage("OpenUp", SendMessageOptions.DontRequireReceiver);
                triggered = true;
            }
            else if (((Physics.Raycast(ray3, out hit3, raycastDistance)) && hit3.collider.CompareTag("Door")) && (triggered == false))
            {
                Debug.Log("Name of Object:" + hit3.collider.name);
                hit3.collider.gameObject.SendMessage("OpenUp", SendMessageOptions.DontRequireReceiver);
                triggered = true;
            }
            else if (((Physics.Raycast(ray4, out hit4, raycastDistance)) && hit4.collider.CompareTag("Door")) && (triggered == false))
            {
                Debug.Log("Name of Object:" + hit4.collider.name);
                hit4.collider.gameObject.SendMessage("OpenUp", SendMessageOptions.DontRequireReceiver);
                triggered = true;
            }
            // EQUIPMENT
            else if ((Physics.Raycast(ray0, out hit0, raycastDistance)) && hit0.collider.CompareTag("Equipment") && (triggered == false))
            {
                Debug.Log("Name of Object:" + hit0.collider.name);
                inventoryController.AddItem(hit0.collider.gameObject); // Add the object hit by the ray to the inventory
                hit0.collider.gameObject.SetActive(false);
                triggered = true;
            }
            else if ((Physics.Raycast(ray1, out hit1, raycastDistance)) && hit1.collider.CompareTag("Equipment") && (triggered == false))
            {
                Debug.Log("Name of Object:" + hit1.collider.name);
                inventoryController.AddItem(hit1.collider.gameObject); // Add the object hit by the ray to the inventory
                hit1.collider.gameObject.SetActive(false);
                triggered = true;
            }
            else if (((Physics.Raycast(ray2, out hit2, raycastDistance)) && hit2.collider.CompareTag("Equipment")) && (triggered == false))
            {
                Debug.Log("Name of Object:" + hit2.collider.name);
                inventoryController.AddItem(hit2.collider.gameObject); // Add the object hit by the ray to the inventory
                hit2.collider.gameObject.SetActive(false);
                triggered = true;
            }
            else if (((Physics.Raycast(ray3, out hit3, raycastDistance)) && hit3.collider.CompareTag("Equipment")) && (triggered == false))
            {
                Debug.Log("Name of Object:" + hit3.collider.name);
                inventoryController.AddItem(hit3.collider.gameObject); // Add the object hit by the ray to the inventory
                hit3.collider.gameObject.SetActive(false);
                triggered = true;
            }
            else if (((Physics.Raycast(ray4, out hit4, raycastDistance)) && hit4.collider.CompareTag("Equipment")) && (triggered == false))
            {
                Debug.Log("Name of Object:" + hit4.collider.name);
                inventoryController.AddItem(hit4.collider.gameObject); // Add the object hit by the ray to the inventory
                hit4.collider.gameObject.SetActive(false);
                triggered = true;
            }

        }
    }
}

