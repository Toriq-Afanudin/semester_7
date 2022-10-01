using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jaring5 : MonoBehaviour
{
    public float speed = 1;
    private string sumbu;
    private bool putar;
    // Update is called once per frame
    void Update()
    {
        if (putar)
        {
            if (sumbu.ToUpper().Equals("Y"))
            {
                transform.Rotate(Vector3.right*speed);
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
