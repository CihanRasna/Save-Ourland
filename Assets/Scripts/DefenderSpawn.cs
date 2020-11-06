using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawn : MonoBehaviour
{
    [SerializeField] private GameObject defender;
    private Camera mainCam;
    void Awake()
    {
        if (!(Camera.main is null))
        {
            mainCam = Camera.main;
        }
    }

    private void OnMouseDown()
    {
        DefenderSpawner(GetClickedPosition());
    }

    private Vector2 GetClickedPosition()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
        Vector2 worldPos = mainCam.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 rawPos)
    {
        float newXPos = Mathf.RoundToInt(rawPos.x);
        float newYPos = Mathf.RoundToInt(rawPos.y);

        return new Vector2(newXPos,newYPos);
    }

    private void DefenderSpawner(Vector2 roundedPos)
    {
        GameObject newDefender = Instantiate(defender, roundedPos, transform.rotation);
    }
}
