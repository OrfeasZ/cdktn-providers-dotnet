using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplication
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiHostedApplicationInboundAuthConfig), fullyQualifiedName: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfig")]
    public interface IGenerativeAiHostedApplicationInboundAuthConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_hosted_application#inbound_auth_config_type GenerativeAiHostedApplication#inbound_auth_config_type}.</summary>
        [JsiiProperty(name: "inboundAuthConfigType", typeJson: "{\"primitive\":\"string\"}")]
        string InboundAuthConfigType
        {
            get;
        }

        /// <summary>idcs_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_hosted_application#idcs_config GenerativeAiHostedApplication#idcs_config}
        /// </remarks>
        [JsiiProperty(name: "idcsConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfigIdcsConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationInboundAuthConfigIdcsConfig? IdcsConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiHostedApplicationInboundAuthConfig), fullyQualifiedName: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationInboundAuthConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_hosted_application#inbound_auth_config_type GenerativeAiHostedApplication#inbound_auth_config_type}.</summary>
            [JsiiProperty(name: "inboundAuthConfigType", typeJson: "{\"primitive\":\"string\"}")]
            public string InboundAuthConfigType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>idcs_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_hosted_application#idcs_config GenerativeAiHostedApplication#idcs_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idcsConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfigIdcsConfig\"}", isOptional: true)]
            public oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationInboundAuthConfigIdcsConfig? IdcsConfig
            {
                get => GetInstanceProperty<oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationInboundAuthConfigIdcsConfig?>();
            }
        }
    }
}
