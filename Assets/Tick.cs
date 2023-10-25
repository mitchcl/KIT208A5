using UnityEngine;

public class ToggleTick : MonoBehaviour
{
    public GameObject targetObject2Activate;
    public GameObject targetObjectBecomeInactive;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (!targetObjectBecomeInactive.activeSelf && !targetObject2Activate.activeSelf)
        {
            targetObject2Activate.SetActive(true);
        }
    }
}