using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adjust : MonoBehaviour
{
    public RectTransform canvas;

    // Update is called once per frame
    public void AdjustSize(float v)
    {
        var cur = (transform as RectTransform).localPosition;
        cur.z = 0.5f*v;
        (transform as RectTransform).localPosition = cur;
    }
}
