using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARMarkers : MonoBehaviour
{
    public Transform markersTransform;
    public Transform tipsTransform;

    int nbScreen = 2;
    int current = 0;

    public CustomPanel next;
    public CustomPanel before;
    public CustomPanel accueil;
    
    private void OnEnable()
    {
        ChangeCurrentFood(current-current);
    }

    public void GoBackAccueil()
    {
        InterfaceManager.Instance.ShowScreen(accueil, null, false, 0f);
        InterfaceManager.Instance.ShowPanels();
    }

    public void ChangeCurrentFood(int offset)
    {
        current += offset;
        if (current < 0)
        {
            InterfaceManager.Instance.ShowScreen(before, null,false, 0f) ;
            InterfaceManager.Instance.ShowPanels();
        }
        if (current > 2)
        {
            InterfaceManager.Instance.ShowScreen(next, null, false, 0f);
            InterfaceManager.Instance.ShowPanels();
        }

        for (int i = 0; i < markersTransform.childCount; i++)
        {
            Debug.Log("going through transform " + i);
            markersTransform.GetChild(i).gameObject.SetActive(i == current);
            tipsTransform.GetChild(i).gameObject.SetActive(i == current);
        }

    }
}
