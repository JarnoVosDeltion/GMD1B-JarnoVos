using UnityEngine;
using System.Collections;

public class GivePoints : MonoBehaviour {

    public int points;
    public float colorChangeDuration = 0.4f;
    public Material originalMaterial;
    public Material temporaryMaterial;
    Renderer materialRenderer;
    Score scoreScript;

    //Zoekt het score script op en vraagt naar de Renderer component.
	void Start ()
    {
        scoreScript = GameObject.Find("Manager").GetComponent<Score>();
        materialRenderer = GetComponent<Renderer>();
	}
	
    //Wanneer hij wordt aangeraakt zal hij het Addscore aanropen en het aantal verdiende punten meesturen en start coroutine ChangingColors();
	void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Pinball")
        {
            scoreScript.AddScore(points);
            StartCoroutine(ChangingColors());
        }
    }

    //Zal de material tijdelijk vervangen.
    IEnumerator ChangingColors()
    {
        materialRenderer.material = temporaryMaterial;
        yield return new WaitForSeconds(colorChangeDuration);
        materialRenderer.material = originalMaterial;
    }
}
