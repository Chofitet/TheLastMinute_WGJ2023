using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ValveController : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    [SerializeField] GameObject UI;
    [SerializeField] GameObject background;
    [SerializeField] DragAndDropMultiply valve1;
    [SerializeField] DragAndDropMultiply valve2;
    [SerializeField] DragAndDropMultiply valve3;
    bool _valve1;
    bool _valve2;
    bool _valve3;
    int count;
    private bool x;

    [SerializeField] GameObject Door;

    public void valvePicked()
    {
        count += 1;
       text.text = count.ToString();
        x = true;
    }

    public void ActiveUI()
    {
        UI.SetActive(true);
    }

    private void Update()
    {
        if (valve1.finish && !_valve1)
        {
            valve1.transform.SetParent(background.transform);
            count -= 1;
            _valve1 = true;
            text.text = count.ToString();
        }
        if (valve2.finish && !_valve2)
        {
            valve2.transform.SetParent(background.transform);
            count -= 1;
            _valve2 = true;
            text.text = count.ToString();
        }
        if (valve3.finish && !_valve3)
            {
            valve3.transform.SetParent(background.transform);
            count -= 1;
                _valve3 = true;
            text.text = count.ToString();
        }
        if (count == 0 && x)
        {
            UI.SetActive(false);
        }

        if (_valve1 && _valve2 && _valve3)
        {
            Door.SetActive(true);
        }
    }
}
