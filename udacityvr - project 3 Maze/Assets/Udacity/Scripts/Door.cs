using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    public GameObject door;
    public AudioClip Door_Opened;
    public AudioClip Door_Locked;

    bool locked = true;
    bool opening = false;
    float doorPosition;

    void Start() { }
     
    void Update()
    {
        //check door y position
        doorPosition = transform.position.y;

        //move door up
        if (opening == true && doorPosition < 8)
        {
            door.transform.Translate(0, 8f * Time.deltaTime, 0);
        }
    }
    public void OnDoorClicked() {

        print("locked = " + locked);
        if (locked == false)
        {
            opening = true;
            print(opening);
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(Door_Opened);
        }

        else
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(Door_Locked);
        }
    }

    public void Unlock()
    {
        locked = false;
    }
}
