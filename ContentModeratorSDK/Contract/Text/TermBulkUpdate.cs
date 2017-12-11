using System.Collections.Generic;

namespace Microsoft.CognitiveServices.ContentModerator.Contract.Text
{
    public class TermBulkUpdate
    {
        public List<TermList> Add { get; set; }
        public List<TermList> Delete { get; set; }
    }

    public class TermList
    {
        public string Language { get; set; }
        public List<string> Terms { get; set; }
    }
}
