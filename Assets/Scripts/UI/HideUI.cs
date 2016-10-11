using UnityEngine;
using System.Collections;

public class HideUI : MonoBehaviour {

    [SerializeField]
    GameObject[] UI_Elements;
    GameObject UI_Element;

    void Start()
    {
        for(int i = 0; i < UI_Elements.Length; i++)
        {
            UI_Element = UI_Elements[i];
        }
    }

    public void Hide_UI_Elements()
    {
        UI_Element.SetActive(false);
    }
}
