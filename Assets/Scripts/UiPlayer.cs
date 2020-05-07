using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UiPlayer : MonoBehaviour, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{

    private RectTransform rectTransform; 
    private bool spawnedNewPlayer = false;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>(); 
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        GameObject canvas =  GameObject.FindGameObjectWithTag("Canvas");
        rectTransform.anchoredPosition += eventData.delta / canvas.GetComponent<Canvas>().scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if ( !spawnedNewPlayer )
        {
            var SpawnManager = GameObject.FindGameObjectWithTag("SpawnPlayerManager");
            SpawnManager.GetComponent<PlayerSpawn>().SpawnNewPlayer();
            spawnedNewPlayer = true;
        }      
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
    }
}
