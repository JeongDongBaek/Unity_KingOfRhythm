using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgementNote : MonoBehaviour
{

    void Start(){    }
    
    void Update(){    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Note Clear");
        Destroy(col.gameObject);
    }
}
