using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private Vector2 StartPos;
    [SerializeField] private float moveModifier;

    private void Start()
    {
        StartPos = transform.localPosition;
    }

    private void Update()
    {
        Vector2 pz = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        float posX = Mathf.Lerp(transform.localPosition.x, StartPos.x + (pz.x * moveModifier), 2f );
        float posY = Mathf.Lerp(transform.localPosition.y, StartPos.y + (pz.y * moveModifier), 2f );
        
        transform.localPosition = new Vector3(posX, posY, transform.position.y);
    }
}
