using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcrRepository
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecrRepository.EcrRepositoryImageTagMutabilityExclusionFilter")]
    public class EcrRepositoryImageTagMutabilityExclusionFilter : aws.EcrRepository.IEcrRepositoryImageTagMutabilityExclusionFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecr_repository#filter EcrRepository#filter}.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}")]
        public string Filter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecr_repository#filter_type EcrRepository#filter_type}.</summary>
        [JsiiProperty(name: "filterType", typeJson: "{\"primitive\":\"string\"}")]
        public string FilterType
        {
            get;
            set;
        }
    }
}
