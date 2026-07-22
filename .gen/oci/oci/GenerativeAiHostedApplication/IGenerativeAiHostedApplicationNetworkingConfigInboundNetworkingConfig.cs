using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplication
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig), fullyQualifiedName: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig")]
    public interface IGenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/generative_ai_hosted_application#endpoint_mode GenerativeAiHostedApplication#endpoint_mode}.</summary>
        [JsiiProperty(name: "endpointMode", typeJson: "{\"primitive\":\"string\"}")]
        string EndpointMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/generative_ai_hosted_application#private_endpoint_id GenerativeAiHostedApplication#private_endpoint_id}.</summary>
        [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateEndpointId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig), fullyQualifiedName: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/generative_ai_hosted_application#endpoint_mode GenerativeAiHostedApplication#endpoint_mode}.</summary>
            [JsiiProperty(name: "endpointMode", typeJson: "{\"primitive\":\"string\"}")]
            public string EndpointMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/generative_ai_hosted_application#private_endpoint_id GenerativeAiHostedApplication#private_endpoint_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateEndpointId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
