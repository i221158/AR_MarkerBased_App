using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPopupController : MonoBehaviour
{
    [Header("Rotation Settings")]
    public GameObject markerParent;   // The AR marker that holds your spawned model
    private bool switch1=false;

    public void hehehhe()
    { if (switch1)
        {
            ShowInfo();
            switch1= true;
        }   
      else
        {
            HideInfo();
            switch1 = false;
        }
    }
    //public void ShowInfo()
    //{
    //    GameObject infoPanel = GameObject.FindGameObjectWithTag("info");
    //    if (infoPanel != null && markerParent != null && markerParent.transform.childCount > 0)
    //    {
    //        infoPanel.SetActive(true);
    //    }
    //    else
    //    {
    //        Debug.LogWarning("Info panel not found, markerParent is null, or markerParent has no children.");
    //    }
    //}
    public void ShowInfo()
    {
        if (markerParent != null)
        {
            GameObject infoPanel = FindInactiveObject(markerParent.transform, "info");
            if (infoPanel != null)
            {
                infoPanel.SetActive(true);
            }
            else
            {
                Debug.LogWarning("No descendant with tag 'info' found under markerParent (active or inactive).");
            }
        }
        else
        {
            Debug.LogWarning("markerParent is null.");
        }
    }

    // Recursively searches all GameObjects in the scene for a tag, including inactive ones
    private GameObject FindInactiveObject(Transform parent,string tag)
    {
        foreach (Transform child in parent)
        {
            if (child.CompareTag(tag))
                return child.gameObject;

            GameObject found = FindInactiveObject(child, tag);
            if (found != null)
                return found;
        }
        return null;
    }

    private GameObject FindInHierarchyRecursive(Transform parent, string tag)
    {
        if (parent.CompareTag(tag))
            return parent.gameObject;

        foreach (Transform child in parent)
        {
            GameObject found = FindInHierarchyRecursive(child, tag);
            if (found != null)
                return found;
        }
        return null;
    }



    public void HideInfo()
    {
        GameObject infoPanel = GameObject.FindGameObjectWithTag("info");
        if (infoPanel != null)
        {
            infoPanel.SetActive(false);
        }
        else
        {
            Debug.LogWarning("Info panel not found.");
        }
    }
}
