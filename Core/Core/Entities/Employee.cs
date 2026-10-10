using Domain.value_objects;

namespace Domain.Entities;

public class Employee
{
    public IDGuid ID { get; }
    public IDGuid EnterpriseID { get; }
    public Name Name { get; private set; }
    private readonly List<Model> _models = new();
    public IReadOnlyCollection<Model> Models => _models;
    internal Employee(Name name, IDGuid enterpriseID)
    {
        ID = new IDGuid();
        Name = name ?? throw new ArgumentNullException(nameof(name));
        EnterpriseID = enterpriseID ?? throw new ArgumentNullException(nameof(enterpriseID));
    }
    public void AddModel(Model model)
    {
        if (model == null)
            throw new ArgumentNullException(nameof(model));
        _models.Add(model);
    }
    public override bool Equals(object? obj) =>
        obj is Employee other && ID.Equals(other.ID);

    public override int GetHashCode() => ID.GetHashCode();
}