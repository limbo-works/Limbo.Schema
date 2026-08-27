using System.Collections.Generic;

namespace Limbo.Schema.Models.Keywords;

public class SchemaKeywordList : List<IKeyword> {

    public void Add(string value) {
        base.Add(new SchemaText { Value = value });
    }

}