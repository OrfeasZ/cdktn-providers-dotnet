using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcrRepository
{
    [JsiiInterface(nativeType: typeof(IEcrRepositoryImageTagMutabilityExclusionFilter), fullyQualifiedName: "aws.ecrRepository.EcrRepositoryImageTagMutabilityExclusionFilter")]
    public interface IEcrRepositoryImageTagMutabilityExclusionFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecr_repository#filter EcrRepository#filter}.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}")]
        string Filter
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecr_repository#filter_type EcrRepository#filter_type}.</summary>
        [JsiiProperty(name: "filterType", typeJson: "{\"primitive\":\"string\"}")]
        string FilterType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcrRepositoryImageTagMutabilityExclusionFilter), fullyQualifiedName: "aws.ecrRepository.EcrRepositoryImageTagMutabilityExclusionFilter")]
        internal sealed class _Proxy : DeputyBase, aws.EcrRepository.IEcrRepositoryImageTagMutabilityExclusionFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecr_repository#filter EcrRepository#filter}.</summary>
            [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}")]
            public string Filter
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecr_repository#filter_type EcrRepository#filter_type}.</summary>
            [JsiiProperty(name: "filterType", typeJson: "{\"primitive\":\"string\"}")]
            public string FilterType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
