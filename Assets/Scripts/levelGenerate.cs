using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGenerate : MonoBehaviour
{
    int width = 5;

    int height = 10;

    public gridElement gridElement;

    public gridElement[] gridElements;

    // Start is called before the first frame update
    void Start()
    {
        gridElements = new gridElement[width * width * height];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                for (int z = 0; z < width; z++)
                {
                    gridElement gridElementInstance = Instantiate(gridElement, new Vector3(x, y, z), Quaternion.identity, this.transform);
                    gridElementInstance.name = "GridElemet" + "_" + x + "_" + y + "_" + z;
                    gridElements[x + width * (z + width * y)] = gridElementInstance;
                }
            }
        }
    }

}
