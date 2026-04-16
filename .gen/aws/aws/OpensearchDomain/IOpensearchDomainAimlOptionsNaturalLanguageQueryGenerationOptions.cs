using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiInterface(nativeType: typeof(IOpensearchDomainAimlOptionsNaturalLanguageQueryGenerationOptions), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainAimlOptionsNaturalLanguageQueryGenerationOptions")]
    public interface IOpensearchDomainAimlOptionsNaturalLanguageQueryGenerationOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearch_domain#desired_state OpensearchDomain#desired_state}.</summary>
        [JsiiProperty(name: "desiredState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DesiredState
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDomainAimlOptionsNaturalLanguageQueryGenerationOptions), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainAimlOptionsNaturalLanguageQueryGenerationOptions")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchDomain.IOpensearchDomainAimlOptionsNaturalLanguageQueryGenerationOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearch_domain#desired_state OpensearchDomain#desired_state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "desiredState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DesiredState
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
