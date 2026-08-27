using Limbo.Schema.Models.Organizations;
using Limbo.Schema.Models.Places;
using Newtonsoft.Json;

namespace Limbo.Schema.Models.Jobs;

/// <summary>
/// A listing that describes a job opening in a certain organization.
/// </summary>
/// <see href="https://schema.org/JobPosting"/>
public class SchemaJobPosting : SchemaCreativeWork {

    public new const string Type = "JobPosting";

    #region Properties

    /// <summary>
    /// The title of the job.
    /// </summary>
    [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
    public string? Title { get; set; }

    /// <summary>
    /// Publication date of an online listing.
    /// </summary>
    [JsonProperty("datePosted", NullValueHandling = NullValueHandling.Ignore)]
    public IDate? DatePosted { get; set; }

    [JsonProperty("employmentType", NullValueHandling = NullValueHandling.Ignore)]
    public string? EmploymentType { get; set; }

    [JsonProperty("employmentUnit", NullValueHandling = NullValueHandling.Ignore)]
    public IOrganization? EmploymentUnit { get; set; }

    [JsonProperty("hiringOrganization", NullValueHandling = NullValueHandling.Ignore)]
    public IOrganization? HiringOrganization { get; set; }

    [JsonProperty("jobLocation", NullValueHandling = NullValueHandling.Ignore)]
    public SchemaList<SchemaPlace> JobLocation { get; set; } = [];

    [JsonProperty("jobStartDate", NullValueHandling = NullValueHandling.Ignore)]
    public IDate? JobStartDate { get; set; }

    [JsonProperty("validThrough", NullValueHandling = NullValueHandling.Ignore)]
    public IDate? ValidThrough { get; set; }

    #endregion

    #region Constructors

    public SchemaJobPosting() : base(Type) { }

    protected SchemaJobPosting(string type) : base(type) { }

    #endregion

    #region Static methods

    public static new SchemaJobPosting Create() {
        return new SchemaJobPosting();
    }

    #endregion

}