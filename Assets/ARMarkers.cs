using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARMarkers : MonoBehaviour
{
    public Transform markersTransform;
    public Transform tipsTransform;
    int nbScreen = 2;
    int current = 0;
    private void Awake()
    {
        ChangeCurrentFood(0);
    }

    public void ChangeCurrentFood(int offset)
    {
        current += offset;
        if (current < 0)
            current = 2;
        if (current > 2)
            current = 0;

        for (int i = 0; i < markersTransform.childCount; i++)
        {
            Debug.Log("going through transform " + i);
            markersTransform.GetChild(i).gameObject.SetActive(i == current);
            tipsTransform.GetChild(i).gameObject.SetActive(i == current);
        }

    }
}
