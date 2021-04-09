using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Token : Selectable
{
    public Pile parentPile { get; set; }

    bool selected = false;

    public UnityEvent selectedAction;
    public UnityEvent deSelectedAction;

    Vector3 originalPosition;

    protected override void Start()
    {
        originalPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        parentPile = GetComponentInParent<Pile>();
    }

    public override void OnSelect(BaseEventData eventData)
    {
        if (Game.Instance.selectablePile == null || Game.Instance.selectablePile == parentPile)
        {
            selected = !selected;
            Debug.Log("Selected: " + selected);

            if (selected)
            {
                selectedAction.Invoke();
            }
            else
            {
                deSelectedAction.Invoke();
            }
        }
    }

    public void OnSelected()
    {
        Game.Instance.selectedTokens.Add(this);
        parentPile.SelectedTokens++;
        transform.position = new Vector3(originalPosition.x, originalPosition.y + 1, originalPosition.z);
    }

    public void OnDeSelected()
    {
        Game.Instance.selectedTokens.Remove(this);
        parentPile.SelectedTokens--;
        transform.position = originalPosition;
    }

}
