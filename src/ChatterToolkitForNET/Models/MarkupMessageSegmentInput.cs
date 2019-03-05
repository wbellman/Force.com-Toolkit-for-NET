using Newtonsoft.Json;

namespace Salesforce.Chatter.Models
{
    public class MarkupMessageSegmentInput : MessageSegmentInput {

      [JsonProperty(PropertyName = "markuptype")]
      public string MarkupType { get; set; }

    }
}
