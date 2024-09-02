using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInteractable : Interactable
{
    [SerializeField] private Material objectMaterial;  //Renderer
    public override void OnFocus()
    {
        print("LOOKING AT " + gameObject.name);
        objectMaterial.color = Color.green;
    }

    public override void OnInteract()
    {
        print("INTERACTED WITH " + gameObject.name);
        objectMaterial.color = Color.red;
    }

    public override void OnLoseFocus()
    {
        print("STOPPED LOOKING AT " + gameObject.name);
        objectMaterial.color = Color.white;
    }
}
