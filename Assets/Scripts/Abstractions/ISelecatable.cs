using UnityEngine;
public interface ISelecatable : IHealthHolder, IIconHolder
{
    Transform PivotPoint { get; }
    Outline Outline { get; }
    void SetOutline(bool enabled);
}