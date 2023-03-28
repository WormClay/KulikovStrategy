using UnityEngine;
public interface ISelecatable : IHealthHolder
{
    Sprite Icon { get; }
    Outline Outline { get; }
    void SetOutline(bool enabled);
}