﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject trailObject;

    // Start is called before the first frame update
    void Start()
    {
        trailObject.SetActive(false);
    }

    // Update is called once per frame
    
    public void ActivateTrail ()
    {
        trailObject.SetActive(true);
    }
}
