using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsAccountRecoverySetting
{
    [JsiiByValue(fqn: "oci.identityDomainsAccountRecoverySetting.IdentityDomainsAccountRecoverySettingTimeouts")]
    public class IdentityDomainsAccountRecoverySettingTimeouts : oci.IdentityDomainsAccountRecoverySetting.IIdentityDomainsAccountRecoverySettingTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_account_recovery_setting#create IdentityDomainsAccountRecoverySetting#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_account_recovery_setting#delete IdentityDomainsAccountRecoverySetting#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_account_recovery_setting#update IdentityDomainsAccountRecoverySetting#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
