using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour
{
    public GameObject effectObject;

    void Start()
    {
        effectObject.SetActive (false);
    }
    // Start is called before the first frame update
    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.GetComponent<Ball> () != null)
        {
            effectObject.SetActive (true);
        }
    }
}
