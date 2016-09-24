using UnityEngine;
using System.Collections;

public class DeathTrigger : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer != LayerMask.NameToLayer("Death"))
        {
            Destroy(other.gameObject);
        }
    }
}
