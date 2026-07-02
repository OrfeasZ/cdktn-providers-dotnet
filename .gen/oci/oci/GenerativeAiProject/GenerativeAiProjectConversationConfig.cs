using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiProject
{
    [JsiiByValue(fqn: "oci.generativeAiProject.GenerativeAiProjectConversationConfig")]
    public class GenerativeAiProjectConversationConfig : oci.GenerativeAiProject.IGenerativeAiProjectConversationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/generative_ai_project#conversations_retention_in_hours GenerativeAiProject#conversations_retention_in_hours}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "conversationsRetentionInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConversationsRetentionInHours
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/generative_ai_project#responses_retention_in_hours GenerativeAiProject#responses_retention_in_hours}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responsesRetentionInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ResponsesRetentionInHours
        {
            get;
            set;
        }
    }
}
