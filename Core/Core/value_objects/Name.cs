namespace Domain.value_objects;

public record Name
{
    public string Value { get; private set; }

    private Name(string value) {
        if(string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Name can't be null or empty", nameof(value));
        SetValue(value); 
    }

    private void SetValue(string value) => Value = RequireNonEmpty(value, nameof(value));

    public static Name Create(string firstName, string lastName)
    {
        var first = RequireNonEmpty(firstName, nameof(firstName));
        var last = RequireNonEmpty(lastName, nameof(lastName));
        return new Name($"{first} {last}");
    }

    public static Name Create(string firstName)
    {
        var first = RequireNonEmpty(firstName, nameof(firstName));
        return new Name(first);
    }

    public static Name Parse(string fullName)
    {
        var trimmed = RequireNonEmpty(fullName, nameof(fullName));
        if (!trimmed.Contains(' '))
            throw new ArgumentException("Nome completo precisa ter nome e sobrenome.", nameof(fullName));
        return new Name(trimmed);
    }

    private static string RequireNonEmpty(string value, string paramName)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Não pode ser vazio.", paramName);
        return value.Trim();
    }

    public string FirstName => Value.Split(' ')[0];
    public string LastName => Value.Split(' ')[^1];
    public string Initials => $"{FirstName[0]}{LastName[0]}";

    public override string ToString() => Value;
}