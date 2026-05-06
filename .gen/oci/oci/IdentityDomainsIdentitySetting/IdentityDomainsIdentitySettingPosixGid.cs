using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentitySetting
{
    [JsiiByValue(fqn: "oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingPosixGid")]
    public class IdentityDomainsIdentitySettingPosixGid : oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingPosixGid
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_setting#manual_assignment_ends_at IdentityDomainsIdentitySetting#manual_assignment_ends_at}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "manualAssignmentEndsAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ManualAssignmentEndsAt
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_setting#manual_assignment_starts_from IdentityDomainsIdentitySetting#manual_assignment_starts_from}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "manualAssignmentStartsFrom", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ManualAssignmentStartsFrom
        {
            get;
            set;
        }
    }
}
