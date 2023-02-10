using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private KitchenObjectsSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;

    public void Interact()
    {
        Transform kitchenObjTransf = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
        kitchenObjTransf.localPosition = Vector3.zero;
    }
}
