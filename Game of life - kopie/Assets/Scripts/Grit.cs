using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grit : MonoBehaviour {

    private GameObject[,] grid;
    public int Columns;
    public int Rows;
    public GameObject rect;

    void Start()
    {
        grid = new GameObject[Columns, Rows];

        for (int i = 0; i < Columns; i++)
        {
            for (int j = 0; j < Rows; j++)
            {
                grid[i, j] = Instantiate(rect, new Vector3(transform.position.x + i, transform.position.y + j, transform.position.z), Quaternion.identity);
            }
        }
    }
}
