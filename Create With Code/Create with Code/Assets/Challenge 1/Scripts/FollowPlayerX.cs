﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(16,2,2);

    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
