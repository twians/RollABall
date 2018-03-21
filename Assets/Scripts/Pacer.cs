using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacer : MonoBehaviour {

    public float speed = 0.05f;

    private float zMax = 7.5f;
    private float zMin = -7.5f;
    private float xMax = 7.5f;
    private float xMin = -7.5f;
    private int direction = 1;
    private int xAxis = 0;
    private int zAxis = 1;

	
	// Update is called once per frame
	void Update () {

        float zNew = transform.position.z + direction * speed * Time.deltaTime * zAxis;
        float xNew = transform.position.x + direction * speed * Time.deltaTime * xAxis;

        if (zNew >= zMax && zAxis == 1)
        {
            zNew = zMax;
            xAxis = 1;
            zAxis = 0;
            direction *= -1;
        }        
        else if (xNew <= xMin && xAxis == 1)
        {
            xNew = xMin;
            xAxis = 0;
            zAxis = 1;
        }
        else if (zNew <= zMin && zAxis == 1)
        {
            zNew = zMin;
            xAxis = 1;
            zAxis = 0;
            direction *= -1;
        }
        else if (xNew >= xMax && xAxis == 1)
        {
            xNew = xMax;
            xAxis = 0;
            zAxis = 1;
        }
        
        transform.position = new Vector3(xNew, 0.75f, zNew);
       
    }
}
