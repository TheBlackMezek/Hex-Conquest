using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapManager : MonoBehaviour
{

    [Header("Settings")]

    [SerializeField] int mapSize;

    [Header("Ground tiles")]

    [SerializeField] Tile landTile;
    [SerializeField] Tile waterTile;
    [SerializeField] Tile capitalTile;
    [SerializeField] Tile townTile;
    [SerializeField] Tile harborTile;

    [Header("Entity tiles")]

    [SerializeField] Tile soldierTile;
    [SerializeField] Tile boatTile;

    [Header("Links")]

    [SerializeField] Tilemap groundMap;
    [SerializeField] Tilemap entityMap;



    private void Start()
    {
        int startX = -mapSize + 1;
        int startY = 0;
        Vector3Int pos = new Vector3Int(startX, startY, 0);

        for (int x = startX; x < mapSize; ++x)
        {
            pos.x = x;
            groundMap.SetTile(pos, landTile);
        }
        startY = 1;
        for (int y = 1; y < mapSize; ++y)
        {
            for (int x = startX + y - (y / 2 + y % 2); x < mapSize - 1 - y + (y / 2) + 1; ++x)
            {
                pos.x = x;
                pos.y = y;
                groundMap.SetTile(pos, landTile);
                pos.y = -y;
                groundMap.SetTile(pos, landTile);
            }
        }
    }

}
