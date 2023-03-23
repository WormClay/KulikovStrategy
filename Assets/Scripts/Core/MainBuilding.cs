using UnityEngine;
public class MainBuilding : CommandExecutorBase<IProduceUnitCommand>, ISelecatable
{
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;
    public Outline Outline { get; private set; }
    [SerializeField] private Transform _unitsParent;
    [SerializeField] private float _maxHealth = 1000;
    [SerializeField] private Sprite _icon;
    private float _health = 800;
    public override void ExecuteSpecificCommand(IProduceUnitCommand command)
    {
        Instantiate(command.UnitPrefab, new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity, _unitsParent);
    }
    public void SetOutline(bool enabled)
    {
        if (Outline == null) Outline = gameObject.AddComponent<Outline>();
        Outline.enabled = enabled;
    }
}