using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
   // [SerializeField] AudioClip bgSound;
    // Start is called before the first frame update
    void Start()
    {
        BackGroundSound();
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    void BackGroundSound()
    {
        audioSource.Play();
    }

}
