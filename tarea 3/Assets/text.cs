using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      Debug.Log("Start");  
    }

    // Update is called once per frame
    void Update()
    {
      Debug.Log("Update"+transform.position);
      transform.rotation = Quaternion.Euler(0,0,(1 * Time.deltaTime) + transform.rotation.eulerAngles.z);


    }
}
