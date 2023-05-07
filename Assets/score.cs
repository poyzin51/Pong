using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class score : MonoBehaviour

{
    public EventTrigger.TriggerEvent scoreTrigger;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("ball"))
           { 
            Destroy(other.gameObject);
            BaseEventData eventData = new  BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);
           }
    }
}
