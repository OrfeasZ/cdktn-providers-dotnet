using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgentEndpoint
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentAgentEndpointOutputConfig), fullyQualifiedName: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointOutputConfig")]
    public interface IGenerativeAiAgentAgentEndpointOutputConfig
    {
        /// <summary>output_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_agent_endpoint#output_location GenerativeAiAgentAgentEndpoint#output_location}
        /// </remarks>
        [JsiiProperty(name: "outputLocation", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointOutputConfigOutputLocation\"}")]
        oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointOutputConfigOutputLocation OutputLocation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_agent_endpoint#retention_period_in_minutes GenerativeAiAgentAgentEndpoint#retention_period_in_minutes}.</summary>
        [JsiiProperty(name: "retentionPeriodInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetentionPeriodInMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiAgentAgentEndpointOutputConfig), fullyQualifiedName: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointOutputConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointOutputConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>output_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_agent_endpoint#output_location GenerativeAiAgentAgentEndpoint#output_location}
            /// </remarks>
            [JsiiProperty(name: "outputLocation", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointOutputConfigOutputLocation\"}")]
            public oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointOutputConfigOutputLocation OutputLocation
            {
                get => GetInstanceProperty<oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointOutputConfigOutputLocation>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_agent_endpoint#retention_period_in_minutes GenerativeAiAgentAgentEndpoint#retention_period_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionPeriodInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionPeriodInMinutes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
