using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickValve : MonoBehaviour
{
    [SerializeField] ValveController Controller;
    [SerializeField] GameObject valve;
    private void OnMouseDown()
    {
        valve.SetActive(true);
        Controller.ActiveUI();
        Controller.valvePicked();
        Destroy(gameObject);
    }
}
