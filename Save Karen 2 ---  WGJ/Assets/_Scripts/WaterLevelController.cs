using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WaterLevelController : MonoBehaviour
{
    [SerializeField] Slider slider;
    Vector3 StartPosition;
    private void Start()
    {
        StartPosition = transform.position;
    }
    private void Update()
    {
        Vector3 _position = transform.position;
        _position.y = Mathf.Lerp(StartPosition.y, 0, slider.value * Time.deltaTime * 0.0005f);
        transform.position = new Vector3(transform.position.x, _position.y, transform.position.z);
        StartPosition = transform.position;
    }
}
