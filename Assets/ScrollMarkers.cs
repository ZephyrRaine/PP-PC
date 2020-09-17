using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollMarkers : MonoBehaviour
{
    ARMarkers _marks;
    ARMarkers marks
    {
        get
        {
            if (_marks == null)
                _marks = FindObjectOfType<ARMarkers>();

            return _marks;
        }
    }

    public void Previous()
    {
        marks?.ChangeCurrentFood(-1);
    }
    public void Next()
    {
        marks?.ChangeCurrentFood(1);
    }

    public void Accueil()
    {
        marks?.GoBackAccueil();
    }
}
