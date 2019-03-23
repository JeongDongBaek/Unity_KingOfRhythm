using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNote : MonoBehaviour
{
    Transform my;
    Vector3 move = new Vector3(-1.0f, 0, 0);

    void Start()
    {
        my = this.transform;
    }

    void Update()
    {
        my.Translate(move);
    }
}
