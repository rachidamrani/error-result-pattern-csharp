namespace ErrorResultPattern.Domain.Abstractions;

public abstract class Entity
{
    protected Entity(Guid id)
    {
        Id = id;
    }

    protected Entity()
    {
    }

    public Guid Id { get; init; }

    public List<IDomainEvent> DomainEvents => _domainEvents.ToList();
    
    private readonly List<IDomainEvent> _domainEvents = new();

    protected void Raise(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}