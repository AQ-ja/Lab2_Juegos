﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Other;
    // Update is called once per frame
    void Update()
    {
        Destroy(Other);
    }
}
