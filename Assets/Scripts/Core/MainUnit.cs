using UnityEngine;
public class MainUnit : MonoBehaviour, ISelecatable
{
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;

    public Outline Outline { get; private set; }

    [SerializeField] private float _maxHealth = 100;
    [SerializeField] private Sprite _icon;
    private float _health = 100;

    public void SetOutline(bool enabled)
    {
        if (Outline == null) Outline = gameObject.AddComponent<Outline>();
        Outline.enabled = enabled;
    }
}