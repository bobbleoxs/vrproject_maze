using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    public GameObject poof;
    public GameObject key;
    public Door door;

    void Update()
	{
        transform.position = new Vector3(transform.position.x, 4 + Mathf.Sin(Time.time * 1.5f), transform.position.z);
    }

	public void OnKeyClicked()
	{
        Object.Instantiate(poof, new Vector3(0.4f, 5.12f, 61.3f), Quaternion.Euler(-90, 0, 0));
        door.Unlock();
        Destroy(gameObject);
     }
}
