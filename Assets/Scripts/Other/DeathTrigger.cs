using UnityEngine;
using System.Collections;

public class DeathTrigger : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer != LayerMask.NameToLayer("Death"))
        {
            Destroy(other.gameObject);
            Debug.Log("Object destoryed!");
           
        }
    }
}
