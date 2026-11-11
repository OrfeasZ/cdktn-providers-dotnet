using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworksecuritymanagerPolicy
{
    [JsiiInterface(nativeType: typeof(INetworksecuritymanagerPolicyConfigurationWafConfig), fullyQualifiedName: "aws.networksecuritymanagerPolicy.NetworksecuritymanagerPolicyConfigurationWafConfig")]
    public interface INetworksecuritymanagerPolicyConfigurationWafConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/networksecuritymanager_policy#conflict_resolution NetworksecuritymanagerPolicy#conflict_resolution}.</summary>
        [JsiiProperty(name: "conflictResolution", typeJson: "{\"primitive\":\"string\"}")]
        string ConflictResolution
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/networksecuritymanager_policy#existing_customer_web_acl_resolution NetworksecuritymanagerPolicy#existing_customer_web_acl_resolution}.</summary>
        [JsiiProperty(name: "existingCustomerWebAclResolution", typeJson: "{\"primitive\":\"string\"}")]
        string ExistingCustomerWebAclResolution
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworksecuritymanagerPolicyConfigurationWafConfig), fullyQualifiedName: "aws.networksecuritymanagerPolicy.NetworksecuritymanagerPolicyConfigurationWafConfig")]
        internal sealed class _Proxy : DeputyBase, aws.NetworksecuritymanagerPolicy.INetworksecuritymanagerPolicyConfigurationWafConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/networksecuritymanager_policy#conflict_resolution NetworksecuritymanagerPolicy#conflict_resolution}.</summary>
            [JsiiProperty(name: "conflictResolution", typeJson: "{\"primitive\":\"string\"}")]
            public string ConflictResolution
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/networksecuritymanager_policy#existing_customer_web_acl_resolution NetworksecuritymanagerPolicy#existing_customer_web_acl_resolution}.</summary>
            [JsiiProperty(name: "existingCustomerWebAclResolution", typeJson: "{\"primitive\":\"string\"}")]
            public string ExistingCustomerWebAclResolution
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
