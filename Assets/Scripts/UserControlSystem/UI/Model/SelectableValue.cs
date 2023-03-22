using System;
using UnityEngine;
[CreateAssetMenu(fileName = nameof(SelectableValue), menuName = "Strategy Game/" + nameof(SelectableValue), order = 0)]
public class SelectableValue : ScriptableObject
{
    public ISelecatable CurrentValue { get; private set; }
    public event Action<ISelecatable> OnSelected;
    public void SetValue(ISelecatable value)
    {
        CurrentValue?.SetOutline(false);
        CurrentValue = value;
        CurrentValue?.SetOutline(true);
        OnSelected?.Invoke(value);
    }
}