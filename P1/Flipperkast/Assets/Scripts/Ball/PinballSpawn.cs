using UnityEngine;
using System.Collections;

public class PinballSpawn : MonoBehaviour
{
    public float minPower = 5.0f;
    public float maxPower = 7.0f;
    public GameObject prefab;
    Transform pinballSpawn;

    void Start ()
    {
        pinballSpawn = GameObject.Find("PinballSpawn").GetComponent<Transform>();
    }
    
    public void SpawnPinball ()
    {

        GameObject pinball = (GameObject)Instantiate(prefab, pinballSpawn.position, pinballSpawn.rotation);

        pinball.GetComponent<Rigidbody>().velocity = pinballSpawn.transform.forward * Random.Range(minPower, maxPower);
    }

    /*
    void Update ()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            SpawnPinball();
        }
    }
    */
}