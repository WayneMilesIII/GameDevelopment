using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Behavior : MonoBehaviour
{

    void OnBecameInvisible() 
    {
        Destroy(gameObject);
    }

}
