namespace Aspirate.Shared.Models.AspireManifests.Components.V1;

[ExcludeFromCodeCoverage]
public class SqlServerDatabase : Resource, IResourceWithParent
{
    /// <summary>
    /// The parent server of the database.
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }
}
