using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplicationIam
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfig), fullyQualifiedName: "oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfig")]
    public interface IGenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application_iam#network_mode GenerativeAiHostedApplicationIam#network_mode}.</summary>
        [JsiiProperty(name: "networkMode", typeJson: "{\"primitive\":\"string\"}")]
        string NetworkMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application_iam#custom_subnet_id GenerativeAiHostedApplicationIam#custom_subnet_id}.</summary>
        [JsiiProperty(name: "customSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomSubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application_iam#nsg_ids GenerativeAiHostedApplicationIam#nsg_ids}.</summary>
        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NsgIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfig), fullyQualifiedName: "oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application_iam#network_mode GenerativeAiHostedApplicationIam#network_mode}.</summary>
            [JsiiProperty(name: "networkMode", typeJson: "{\"primitive\":\"string\"}")]
            public string NetworkMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application_iam#custom_subnet_id GenerativeAiHostedApplicationIam#custom_subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomSubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application_iam#nsg_ids GenerativeAiHostedApplicationIam#nsg_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NsgIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
