using UnityEngine;
using System.Collections;

public class BasicSyntax : MonoBehaviour 
{
    void Start ()
    {
        Debug.Log(transform.position.x);

        if(transform.postition.y <= 5f)
        {
            object p = Debug.Log ("I am Beyonce Always!");
        }
    }
}