using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
[CreateAssetMenu(fileName ="New Default Object", menuName="Inventory System/Items/Default")]
public class DefaultObject : ItemObject
{
    private void Awake()
    {
        type=ItemType.Default;
    }
}
