using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiInterface(nativeType: typeof(IOpensearchDomainAimlOptionsS3VectorsEngine), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainAimlOptionsS3VectorsEngine")]
    public interface IOpensearchDomainAimlOptionsS3VectorsEngine
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/opensearch_domain#enabled OpensearchDomain#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDomainAimlOptionsS3VectorsEngine), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainAimlOptionsS3VectorsEngine")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchDomain.IOpensearchDomainAimlOptionsS3VectorsEngine
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/opensearch_domain#enabled OpensearchDomain#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
