using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

    public Transform MyPlayer;

    public void Update()
    {
        if (MyPlayer != null)
        {
            transform.LookAt(MyPlayer);
        }
    }
}

