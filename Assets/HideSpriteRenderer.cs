using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideSpriteRenderer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
