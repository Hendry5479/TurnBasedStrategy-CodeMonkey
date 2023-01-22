using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GridDebugObject : MonoBehaviour
{
    GridObject gridObject;
    [SerializeField] TMP_Text textMeshPro;

    public void SetGridObject(GridObject gridObject)
    {
        this.gridObject = gridObject;
    }

    private void Update()
    {
        textMeshPro.text = gridObject.ToString();
    }
}
