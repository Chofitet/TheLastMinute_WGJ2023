using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomTo : MonoBehaviour
{
    [SerializeField] GameObject wholeScene;
    [SerializeField] GameObject detailScene;
    [SerializeField] GameObject light;
    float x;
    private void OnMouseDown()
    {
        detailScene.SetActive(true);
        wholeScene.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            detailScene.SetActive(false);
            wholeScene.SetActive(true);
        }
    }
    private void OnMouseOver()
    {
        if (light == null) return;
        else
        {
            light.SetActive(true);
        }
    }
    private void OnMouseExit()
    {
        if (light == null) return;
        else
        {
            light.SetActive(false);
        }
    }
}
