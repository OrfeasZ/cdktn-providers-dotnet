using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplicationIam
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiHostedApplicationIamNetworkingConfig), fullyQualifiedName: "oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfig")]
    public interface IGenerativeAiHostedApplicationIamNetworkingConfig
    {
        /// <summary>inbound_networking_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_hosted_application_iam#inbound_networking_config GenerativeAiHostedApplicationIam#inbound_networking_config}
        /// </remarks>
        [JsiiProperty(name: "inboundNetworkingConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigInboundNetworkingConfig\"}")]
        oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfigInboundNetworkingConfig InboundNetworkingConfig
        {
            get;
        }

        /// <summary>outbound_networking_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_hosted_application_iam#outbound_networking_config GenerativeAiHostedApplicationIam#outbound_networking_config}
        /// </remarks>
        [JsiiProperty(name: "outboundNetworkingConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfig\"}")]
        oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfig OutboundNetworkingConfig
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiHostedApplicationIamNetworkingConfig), fullyQualifiedName: "oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>inbound_networking_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_hosted_application_iam#inbound_networking_config GenerativeAiHostedApplicationIam#inbound_networking_config}
            /// </remarks>
            [JsiiProperty(name: "inboundNetworkingConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigInboundNetworkingConfig\"}")]
            public oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfigInboundNetworkingConfig InboundNetworkingConfig
            {
                get => GetInstanceProperty<oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfigInboundNetworkingConfig>()!;
            }

            /// <summary>outbound_networking_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_hosted_application_iam#outbound_networking_config GenerativeAiHostedApplicationIam#outbound_networking_config}
            /// </remarks>
            [JsiiProperty(name: "outboundNetworkingConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfig\"}")]
            public oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfig OutboundNetworkingConfig
            {
                get => GetInstanceProperty<oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfig>()!;
            }
        }
    }
}
