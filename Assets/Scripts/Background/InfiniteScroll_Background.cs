using UnityEngine;
using System.Collections;

public class InfiniteScroll_Background : MonoBehaviour {

    [SerializeField]
    float ScrollSpeed = 0.1f;

    void Update()
    {
            Vector2 offset = new Vector2(Time.time * -ScrollSpeed, 0);

            GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
