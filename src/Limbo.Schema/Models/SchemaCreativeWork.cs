using Limbo.Schema.Models.Authors;
using Limbo.Schema.Models.Keywords;
using Limbo.Schema.Models.Languages;
using Limbo.Schema.Models.Publishers;
using Newtonsoft.Json;

namespace Limbo.Schema.Models;

public class SchemaCreativeWork : SchemaThing, IPartOf, IHasKeywords, IMainEntity {

    #region Properties

    [JsonProperty("headline", NullValueHandling = NullValueHandling.Ignore)]
    public string? Headline { get; set; }

    [JsonProperty("dateCreated", NullValueHandling = NullValueHandling.Ignore)]
    public IDate? DateCreated { get; set; }

    [JsonProperty("dateModified", NullValueHandling = NullValueHandling.Ignore)]
    public IDate? DateModified { get; set; }

    [JsonProperty("datePublished", NullValueHandling = NullValueHandling.Ignore)]
    public IDate? DatePublished { get; set; }

    [JsonProperty("expires", NullValueHandling = NullValueHandling.Ignore)]
    public IDate? Expires { get; set; }

    [JsonProperty("authors")]
    public SchemaAuthorList Authors { get; set; } = [];

    [JsonProperty("creator")]
    public SchemaPublisherList Creators { get; set; } = [];

    [JsonProperty("editor")]
    public SchemaPublisherList Editors { get; set; } = [];

    [JsonProperty("publisher")]
    public SchemaPublisherList Publishers { get; set; } = [];

    [JsonProperty("creditText", NullValueHandling = NullValueHandling.Ignore)]
    public string? CreditText { get; set; }

    [JsonProperty("inLanguage")]
    public SchemaLanguageList InLanguages { get; set; } = [];

    [JsonProperty("keywords")]
    public SchemaKeywordList Keywords { get; set; } = [];

    [JsonProperty("isPartOf")]
    public SchemaList<IPartOf> IsPartOf { get; set; } = [];

    #endregion

    #region Constructors

    public SchemaCreativeWork() : base("CreativeWork") { }

    public SchemaCreativeWork(string type) : base(type) { }

    #endregion

    #region Member methods

    public bool ShouldSerializeAuthors() => ShouldSerialize(Authors);

    public bool ShouldSerializePublishers() => ShouldSerialize(Publishers);

    public bool ShouldSerializeCreators() => ShouldSerialize(Creators);

    public bool ShouldSerializeEditors() => ShouldSerialize(Editors);

    public bool ShouldSerializeInLanguages() => ShouldSerialize(InLanguages);

    public bool ShouldSerializeKeywords() => ShouldSerialize(Keywords);

    #endregion

    #region Static methods

    public static SchemaCreativeWork Create() {
        return new SchemaCreativeWork();
    }

    #endregion

}