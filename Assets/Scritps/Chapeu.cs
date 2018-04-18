using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapeu : MonoBehaviour {
    private float currentTime;
    public GameObject chapeu;
    private float x;
    // Use this for initialization
    void Start () {
        currentTime = 0;
        x = 0.15f;
	}

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= 3)
        {
            Destroy(chapeu);
        }
        else
        {
            x +=1f;
            transform.position = new Vector3(x, transform.position.y, 50f);
        }
    }
}
