using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridObject
{
    GridSystem gridSystem;
    GridPosition gridPosition;
    private Unit unit;

    public GridObject(GridSystem gridSystem, GridPosition gridPosition)
    {
        this.gridSystem = gridSystem;
        this.gridPosition = gridPosition;
    }

    public void SetUnit(Unit unit)
    {
        this.unit = unit;
    }

    public Unit GetUnit()
    {
        return this.unit;
    }

    public override string ToString()
    {
        return gridPosition.ToString();
    }
}
