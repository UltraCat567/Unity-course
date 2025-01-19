using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFinishBehavior : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        // ÔŒ«»÷»ﬂ X Ã≈Õ.   0
        float x = Mathf.MoveTowards(transform.position.x, 0, Time.deltaTime * 2f);
        float z = transform.position.z + 3f * Time.deltaTime;
        transform.position = new Vector3(x, 0, z);


        float rot = Mathf.MoveTowardsAngle(transform.eulerAngles.y, 0, Time.deltaTime * 100f);
        transform.position += new Vector3(0, 0, 9 *  Time.deltaTime);

    }
}
