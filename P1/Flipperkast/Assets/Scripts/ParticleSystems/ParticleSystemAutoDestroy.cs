using UnityEngine;
using System.Collections;

public class ParticleSystemAutoDestroy : MonoBehaviour
{
    ParticleSystem ps;

    //Vraagt naar het component Particlesystem
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    //Wanneer de ParticleSystem afgelopen is zal hij zichzelf vernietigen.
    void Update()
    {
        if (ps)
        {
            if (!ps.IsAlive())
            {
                Destroy(gameObject);
            }
        }
    }
}