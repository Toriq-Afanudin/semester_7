using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jaring4 : MonoBehaviour
{
    public float speed = 1;
    private string sumbu;
    private bool putar;
    // Update is called once per frame
    void Update()
    {
        if (putar)
        {
            if (sumbu.ToUpper().Equals("Z"))
            {
                transform.Rotate(Vector3.forward*speed);
            }
        }
    }
    public void RotateCube(string sumbu)
    {
        this.sumbu=sumbu;
        putar=true;
    }
    public void StopRotation()
    {
        putar=false;
    }
}
