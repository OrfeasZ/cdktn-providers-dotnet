using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcrRepositoryCreationTemplate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecrRepositoryCreationTemplate.EcrRepositoryCreationTemplateImageTagMutabilityExclusionFilter")]
    public class EcrRepositoryCreationTemplateImageTagMutabilityExclusionFilter : aws.EcrRepositoryCreationTemplate.IEcrRepositoryCreationTemplateImageTagMutabilityExclusionFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecr_repository_creation_template#filter EcrRepositoryCreationTemplate#filter}.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}")]
        public string Filter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecr_repository_creation_template#filter_type EcrRepositoryCreationTemplate#filter_type}.</summary>
        [JsiiProperty(name: "filterType", typeJson: "{\"primitive\":\"string\"}")]
        public string FilterType
        {
            get;
            set;
        }
    }
}
