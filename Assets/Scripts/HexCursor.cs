using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class HexCursor : MonoBehaviour
{

    [Header("Links")]

    [SerializeField] private Sprite greenCursor;
    [SerializeField] private Sprite redCursor;
    [SerializeField] private Sprite yellowCursor;
    [SerializeField] private Sprite blueCursor;
    [SerializeField] private Sprite purpleCursor;
    [SerializeField] private SpriteRenderer cursorRenderer;
    [SerializeField] private SpriteRenderer selectionRenderer;
    [SerializeField] private Grid grid;



    private void Reset()
    {
        cursorRenderer = GetComponent<SpriteRenderer>();
    }

    private void Awake()
    {
        selectionRenderer.gameObject.SetActive(false);
    }

    private void Update()
    {
        Vector3Int hex = grid.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        Vector3 pos = grid.CellToWorld(hex);

        cursorRenderer.transform.position = pos;
    }

}
