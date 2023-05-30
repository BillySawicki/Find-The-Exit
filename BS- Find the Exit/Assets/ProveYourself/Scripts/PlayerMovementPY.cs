using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementPY : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void FixedUpdate(){
        Vector3 destination = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 1);
        transform.Translate(destination * speed * Time.deltaTime);
    }
}
