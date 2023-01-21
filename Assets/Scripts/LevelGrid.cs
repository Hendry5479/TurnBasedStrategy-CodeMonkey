using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGrid : MonoBehaviour
{
    [SerializeField] Transform gridDebugObjectPrefab;
    GridSystem gridSystem;

    private void Awake()
    {
        gridSystem = new GridSystem(10, 10, 2f);
        gridSystem.CreateDebugObjects(gridDebugObjectPrefab);
    }

    //public void SetUnitAtGridPosition(GridPosition gridPosition, Unit unit)
    //{
    //    GridObject gridObject = gridSystem.GetGridObject
    //}

    //public Unit GetUnitAtGridPosition(GridPosition gridPosition)
    //{
    //}

    //public void ClearUnitAtGridPosition(GridPosition gridPosition)
    //{

    //}
}
