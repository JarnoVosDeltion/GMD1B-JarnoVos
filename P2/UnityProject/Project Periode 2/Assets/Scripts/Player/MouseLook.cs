using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour
{

    public float sensitivityX = 15F;
    public float sensitivityY = 15F;

    public float minimumY = -60F;
    public float maximumY = 60F;

    GameObject player;

    public bool standingStill;


    float rotationY = 0F;

    void Start()
    {
        player = transform.root.gameObject;
    }

    void Update()
    {
        if (standingStill == false)
        {
            rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
            rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

            transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);

            player.transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
        }
    }
}