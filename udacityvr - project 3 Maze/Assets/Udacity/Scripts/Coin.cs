using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    public GameObject poof;
    public GameObject coin;

    float xpos;
    float ypos;
    float zpos;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, 2 + Mathf.Sin(Time.time * 1.2f), transform.position.z);
    }

    public void OnCoinClicked() {

        xpos = transform.position.x;
        ypos = transform.position.y;
        zpos = transform.position.z;

        Object.Instantiate(poof, new Vector3(xpos, ypos, zpos), Quaternion.Euler(-90, 0, 0));

        Destroy(gameObject);   
    }
}
