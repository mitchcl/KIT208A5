using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{

    public GameObject inventoryHolder;
    public GameObject evidenceBag;
    public GameObject cameraObject;

    private class InventoryNode
    {
        public GameObject item;
        public InventoryNode next;

    }

    private InventoryNode head; // Reference to the first item in the inventory
    private InventoryNode currentItem; // Reference to the currently selected item


    // Add item to the inventory
    public void AddItem(GameObject item)
    {
        InventoryNode newNode = new InventoryNode();
        newNode.item = item;

        if (head == null)
        {
            // If the inventory is empty, the new item becomes the head, and it points to itself
            head = newNode;
            head.next = head;
        }
        else
        {
            // Add the new item to the end of the inventory (cyclical)
            InventoryNode temp = head;
            while (temp.next != head)
            {
                temp = temp.next;
            }
            temp.next = newNode;
            newNode.next = head;
        }

        currentItem = newNode;
        // Activate the newly added item
        if (CurrentItemIsEvidenceBag())
        {
            evidenceBag.SetActive(true);
            cameraObject.SetActive(false);
        }
        else if (CurrentItemIsCamera())
        {
            evidenceBag.SetActive(false);
            cameraObject.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        evidenceBag.SetActive(false);
        cameraObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            SwitchInventoryItem();
        }
    }

    void SwitchInventoryItem()
    {
        if (head == null || head.next == head)
        {
            // Inventory is empty or has only one item, nothing to switch
            return;
        }

        if (currentItem == null)
        {
            // If currentItem is null, set it to the head
            currentItem = head;
        }
        else
        {
            // Move to the next item in the inventory (cyclical)
            currentItem = currentItem.next;
        }

        // Deactivate all items in the inventory first
        evidenceBag.SetActive(false);
        cameraObject.SetActive(false);

        // Activate the corresponding item in the inventory based on its type
        if (CurrentItemIsEvidenceBag())
        {
            evidenceBag.SetActive(true);
        }
        else if (CurrentItemIsCamera())
        {
            cameraObject.SetActive(true);
        }
    }



    public bool CurrentItemIsCamera()
    {
        return currentItem != null && currentItem.item != null && currentItem.item.name.Contains("Camera");
    }

    public bool CurrentItemIsEvidenceBag()
    {
        return currentItem != null && currentItem.item != null && currentItem.item.name.Contains("Evidence Bag");
    }
}
