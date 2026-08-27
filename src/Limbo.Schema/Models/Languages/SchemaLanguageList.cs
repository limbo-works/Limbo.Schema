using System.Collections.Generic;

namespace Limbo.Schema.Models.Languages;

public class SchemaLanguageList : List<ILanguage> {

    public void Add(string value) {
        base.Add(new SchemaText { Value = value });
    }

}