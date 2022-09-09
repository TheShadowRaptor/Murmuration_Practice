using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    private GameObject dest;
    // Start is called before the first frame update
    void Start()
    {
        dest = GameObject.Find("Dest");
    }

    // Update is called once per frame
    void Update()
    {
        FollowMouse();
        OnClick();
    }

    private void FollowMouse()
    {
        mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        transform.position = mouseWorldPosition;
    }

    private void OnClick()
    {
        if (Input.GetMouseButton(0))
        {
            dest.transform.position = transform.position;
        }
    }
}
