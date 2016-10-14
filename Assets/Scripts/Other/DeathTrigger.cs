using UnityEngine;
using System.Collections;

public class DeathTrigger : MonoBehaviour {

    string _this_gameObject_tag;

    void Start()
    {
        _this_gameObject_tag = this.gameObject.tag;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (_this_gameObject_tag != other.transform.parent.gameObject.tag)
        {
            Destroy(other.transform.parent.gameObject);
            Debug.Log("Object destoryed!");
        }

    }
}
