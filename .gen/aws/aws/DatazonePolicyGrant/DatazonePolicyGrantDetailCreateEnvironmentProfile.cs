using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazonePolicyGrant
{
    [JsiiByValue(fqn: "aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateEnvironmentProfile")]
    public class DatazonePolicyGrantDetailCreateEnvironmentProfile : aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironmentProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#domain_unit_id DatazonePolicyGrant#domain_unit_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domainUnitId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DomainUnitId
        {
            get;
            set;
        }
    }
}
