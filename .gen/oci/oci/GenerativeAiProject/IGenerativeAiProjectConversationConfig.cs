using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiProject
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiProjectConversationConfig), fullyQualifiedName: "oci.generativeAiProject.GenerativeAiProjectConversationConfig")]
    public interface IGenerativeAiProjectConversationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/generative_ai_project#conversations_retention_in_hours GenerativeAiProject#conversations_retention_in_hours}.</summary>
        [JsiiProperty(name: "conversationsRetentionInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConversationsRetentionInHours
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/generative_ai_project#responses_retention_in_hours GenerativeAiProject#responses_retention_in_hours}.</summary>
        [JsiiProperty(name: "responsesRetentionInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ResponsesRetentionInHours
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiProjectConversationConfig), fullyQualifiedName: "oci.generativeAiProject.GenerativeAiProjectConversationConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiProject.IGenerativeAiProjectConversationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/generative_ai_project#conversations_retention_in_hours GenerativeAiProject#conversations_retention_in_hours}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "conversationsRetentionInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConversationsRetentionInHours
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/generative_ai_project#responses_retention_in_hours GenerativeAiProject#responses_retention_in_hours}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "responsesRetentionInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ResponsesRetentionInHours
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
