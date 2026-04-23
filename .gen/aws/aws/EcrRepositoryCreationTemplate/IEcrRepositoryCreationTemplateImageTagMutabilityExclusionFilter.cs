using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcrRepositoryCreationTemplate
{
    [JsiiInterface(nativeType: typeof(IEcrRepositoryCreationTemplateImageTagMutabilityExclusionFilter), fullyQualifiedName: "aws.ecrRepositoryCreationTemplate.EcrRepositoryCreationTemplateImageTagMutabilityExclusionFilter")]
    public interface IEcrRepositoryCreationTemplateImageTagMutabilityExclusionFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecr_repository_creation_template#filter EcrRepositoryCreationTemplate#filter}.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}")]
        string Filter
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecr_repository_creation_template#filter_type EcrRepositoryCreationTemplate#filter_type}.</summary>
        [JsiiProperty(name: "filterType", typeJson: "{\"primitive\":\"string\"}")]
        string FilterType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcrRepositoryCreationTemplateImageTagMutabilityExclusionFilter), fullyQualifiedName: "aws.ecrRepositoryCreationTemplate.EcrRepositoryCreationTemplateImageTagMutabilityExclusionFilter")]
        internal sealed class _Proxy : DeputyBase, aws.EcrRepositoryCreationTemplate.IEcrRepositoryCreationTemplateImageTagMutabilityExclusionFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecr_repository_creation_template#filter EcrRepositoryCreationTemplate#filter}.</summary>
            [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}")]
            public string Filter
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecr_repository_creation_template#filter_type EcrRepositoryCreationTemplate#filter_type}.</summary>
            [JsiiProperty(name: "filterType", typeJson: "{\"primitive\":\"string\"}")]
            public string FilterType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
