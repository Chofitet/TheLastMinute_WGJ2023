using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyOnPick : MonoBehaviour
{
    [SerializeField] GameObject _Objects;
    [SerializeField] GameObject _ObjectsDisenable;
    private void OnMouseDown()
    {

        _Objects.SetActive(true);
        _ObjectsDisenable.SetActive(false);
        Destroy(gameObject);
    }
}
