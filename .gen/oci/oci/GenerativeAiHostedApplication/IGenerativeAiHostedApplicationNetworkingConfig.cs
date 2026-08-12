using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplication
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiHostedApplicationNetworkingConfig), fullyQualifiedName: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfig")]
    public interface IGenerativeAiHostedApplicationNetworkingConfig
    {
        /// <summary>inbound_networking_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#inbound_networking_config GenerativeAiHostedApplication#inbound_networking_config}
        /// </remarks>
        [JsiiProperty(name: "inboundNetworkingConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig\"}")]
        oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig InboundNetworkingConfig
        {
            get;
        }

        /// <summary>outbound_networking_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#outbound_networking_config GenerativeAiHostedApplication#outbound_networking_config}
        /// </remarks>
        [JsiiProperty(name: "outboundNetworkingConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigOutboundNetworkingConfig\"}")]
        oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfigOutboundNetworkingConfig OutboundNetworkingConfig
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiHostedApplicationNetworkingConfig), fullyQualifiedName: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>inbound_networking_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#inbound_networking_config GenerativeAiHostedApplication#inbound_networking_config}
            /// </remarks>
            [JsiiProperty(name: "inboundNetworkingConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig\"}")]
            public oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig InboundNetworkingConfig
            {
                get => GetInstanceProperty<oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig>()!;
            }

            /// <summary>outbound_networking_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#outbound_networking_config GenerativeAiHostedApplication#outbound_networking_config}
            /// </remarks>
            [JsiiProperty(name: "outboundNetworkingConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigOutboundNetworkingConfig\"}")]
            public oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfigOutboundNetworkingConfig OutboundNetworkingConfig
            {
                get => GetInstanceProperty<oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfigOutboundNetworkingConfig>()!;
            }
        }
    }
}
