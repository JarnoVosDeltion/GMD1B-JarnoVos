using UnityEngine;
using System.Collections;

public class GivePoints : MonoBehaviour {

    public int points;
    public float colorChangeDuration = 0.4f;
    public Material originalMaterial;
    public Material temporaryMaterial;
    Renderer materialRenderer;
    Score scoreScript;


	void Start ()
    {
        scoreScript = GameObject.Find("Manager").GetComponent<Score>();
        materialRenderer = GetComponent<Renderer>();
	}
	
	void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Pinball")
        {
            scoreScript.AddScore(points);
            StartCoroutine(ChangingColors());
        }
    }

    IEnumerator ChangingColors()
    {
        materialRenderer.material = temporaryMaterial;
        yield return new WaitForSeconds(colorChangeDuration);
        materialRenderer.material = originalMaterial;
    }
}
