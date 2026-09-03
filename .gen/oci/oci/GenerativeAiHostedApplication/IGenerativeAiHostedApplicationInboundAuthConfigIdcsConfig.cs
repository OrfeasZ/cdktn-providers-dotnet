using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplication
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiHostedApplicationInboundAuthConfigIdcsConfig), fullyQualifiedName: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfigIdcsConfig")]
    public interface IGenerativeAiHostedApplicationInboundAuthConfigIdcsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application#domain_url GenerativeAiHostedApplication#domain_url}.</summary>
        [JsiiProperty(name: "domainUrl", typeJson: "{\"primitive\":\"string\"}")]
        string DomainUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application#scope GenerativeAiHostedApplication#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        string Scope
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application#audience GenerativeAiHostedApplication#audience}.</summary>
        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Audience
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiHostedApplicationInboundAuthConfigIdcsConfig), fullyQualifiedName: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfigIdcsConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationInboundAuthConfigIdcsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application#domain_url GenerativeAiHostedApplication#domain_url}.</summary>
            [JsiiProperty(name: "domainUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application#scope GenerativeAiHostedApplication#scope}.</summary>
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
            public string Scope
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application#audience GenerativeAiHostedApplication#audience}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Audience
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
