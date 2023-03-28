using System;
using UnityEngine;
[CreateAssetMenu(fileName = nameof(SelectableValue), menuName = "Strategy Game/" + nameof(SelectableValue), order = 0)]
public class SelectableValue : ScriptableObjectValueBase<ISelecatable>
{
    public override void SetValue(ISelecatable value)
    {
        CurrentValue?.SetOutline(false);
        base.SetValue(value);
        CurrentValue?.SetOutline(true);
    }
}