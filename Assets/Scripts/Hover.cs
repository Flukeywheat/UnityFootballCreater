using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField] private TextMeshProUGUI tmp;
    private float dilateSpeed = 0.0015f;
    private bool isHovering = false;
    private bool dilateAscending = true;
    private float dilatePar;
    private const float dilateParBase = -0.124f;
    private const float dilateParMax = 0.07f;
    

    public void OnPointerEnter(PointerEventData eventData)
    {
        isHovering = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        this.tmp.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, -0.124f);
        isHovering = false;
    }

    private void Start()
    {
        dilatePar = dilateParBase;
    }

    private void Update()
    {
        if ( isHovering )
        {            
            if ( dilateAscending )
            {
                this.tmp.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, dilatePar);
                dilatePar += dilateSpeed;
                if ( dilatePar > dilateParMax)
                {
                    dilateAscending = false;
                }
            }
            else
            {
                this.tmp.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, dilatePar);
                dilatePar -= dilateSpeed;
                if (dilatePar < dilateParBase)
                {
                    dilateAscending = true;
                }
            }
            
        }
    }
}
