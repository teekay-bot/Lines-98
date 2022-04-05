using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    private int width = 9, height = 9;
    [SerializeField] private GameObject tilePrefab;

    #region Singleton
    public static GridManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    #endregion

    private void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {
                GameObject spawnTile = Instantiate(tilePrefab,new Vector3(x, 0, z), Quaternion.identity);
                spawnTile.name = $"Tile {x} {z}";
            }
        }
    }
}
