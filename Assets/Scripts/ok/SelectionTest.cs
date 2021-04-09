using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Selectable))]
public class SelectionTest : Selectable
{
    bool selected = false;

    public UnityEvent selectedAction;
    public UnityEvent deSelectedAction;

    // Start is called before the first frame update

    public override void OnSelect(BaseEventData eventData)
    {
        selected = !selected;
        Debug.Log("Selected: "  + selected);

        if (selected)
        {
            selectedAction.Invoke();
        } else
        {
            deSelectedAction.Invoke();
        }
        
    }

    public void OnSelected()
    {
        transform.position = new Vector3(0, 3, 0);
    }

    public void OnDeSelected()
    {
        transform.position = new Vector3(0, 0, 0);

    }






}
