using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class timeDestroyer : MonoBehaviour
{
    public float aliveTimer;
    void Start()
    {
        Destroy(gameObject, aliveTimer);
    }
}
