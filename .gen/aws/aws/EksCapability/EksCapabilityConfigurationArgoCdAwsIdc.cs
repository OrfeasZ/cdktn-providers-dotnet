using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCapability
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.eksCapability.EksCapabilityConfigurationArgoCdAwsIdc")]
    public class EksCapabilityConfigurationArgoCdAwsIdc : aws.EksCapability.IEksCapabilityConfigurationArgoCdAwsIdc
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_capability#idc_instance_arn EksCapability#idc_instance_arn}.</summary>
        [JsiiProperty(name: "idcInstanceArn", typeJson: "{\"primitive\":\"string\"}")]
        public string IdcInstanceArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_capability#idc_region EksCapability#idc_region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "idcRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdcRegion
        {
            get;
            set;
        }
    }
}
