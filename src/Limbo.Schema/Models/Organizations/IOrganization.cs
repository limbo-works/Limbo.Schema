using Limbo.Schema.Models.Authors;
using Limbo.Schema.Models.Publishers;

namespace Limbo.Schema.Models.Organizations;

/// <summary>
/// Interface describing an organization.
/// </summary>
/// <see cref="SchemaOrganization"/>
/// <see cref="SchemaGovernmentOrganization"/>
/// <see cref="SchemaReference"/>
/// <see href="https://schema.org/Organization"/>
public interface IOrganization : IAuthor, IOrganizer, IPublisher;