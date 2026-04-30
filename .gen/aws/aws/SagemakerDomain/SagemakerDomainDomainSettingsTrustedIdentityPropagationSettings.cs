using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainDomainSettingsTrustedIdentityPropagationSettings")]
    public class SagemakerDomainDomainSettingsTrustedIdentityPropagationSettings : aws.SagemakerDomain.ISagemakerDomainDomainSettingsTrustedIdentityPropagationSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_domain#status SagemakerDomain#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public string Status
        {
            get;
            set;
        }
    }
}
