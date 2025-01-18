using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CloudsMovement : MonoBehaviour
{
    [SerializeField] float cloudSpeed;
   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right*cloudSpeed*Time.deltaTime);
        if(transform.position.x > 9f)
        {
            Destroy(gameObject);
        }
    }

  

}
