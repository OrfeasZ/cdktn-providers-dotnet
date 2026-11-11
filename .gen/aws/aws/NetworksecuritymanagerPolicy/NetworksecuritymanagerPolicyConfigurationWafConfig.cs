using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworksecuritymanagerPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networksecuritymanagerPolicy.NetworksecuritymanagerPolicyConfigurationWafConfig")]
    public class NetworksecuritymanagerPolicyConfigurationWafConfig : aws.NetworksecuritymanagerPolicy.INetworksecuritymanagerPolicyConfigurationWafConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/networksecuritymanager_policy#conflict_resolution NetworksecuritymanagerPolicy#conflict_resolution}.</summary>
        [JsiiProperty(name: "conflictResolution", typeJson: "{\"primitive\":\"string\"}")]
        public string ConflictResolution
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/networksecuritymanager_policy#existing_customer_web_acl_resolution NetworksecuritymanagerPolicy#existing_customer_web_acl_resolution}.</summary>
        [JsiiProperty(name: "existingCustomerWebAclResolution", typeJson: "{\"primitive\":\"string\"}")]
        public string ExistingCustomerWebAclResolution
        {
            get;
            set;
        }
    }
}
