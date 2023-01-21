using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] Transform gridDebugObjectPrefab;
    GridSystem gridSystem;

    void Start()
    {
        gridSystem = new GridSystem(10, 10, 2f);
        gridSystem.CreateDebugObjects(gridDebugObjectPrefab);
        Debug.Log(new GridPosition(1,0));
    }

    private void Update()
    {
        Debug.Log(gridSystem.GetGridPosition(MouserWorld.GetPosition()));
    }

}
