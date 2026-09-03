using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazonePolicyGrant
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalGroup")]
    public class DatazonePolicyGrantPrincipalGroup : aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#group_identifier DatazonePolicyGrant#group_identifier}.</summary>
        [JsiiProperty(name: "groupIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string GroupIdentifier
        {
            get;
            set;
        }
    }
}
