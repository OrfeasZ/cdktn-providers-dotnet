using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentitySetting
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsIdentitySettingPosixUid), fullyQualifiedName: "oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingPosixUid")]
    public interface IIdentityDomainsIdentitySettingPosixUid
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_setting#manual_assignment_ends_at IdentityDomainsIdentitySetting#manual_assignment_ends_at}.</summary>
        [JsiiProperty(name: "manualAssignmentEndsAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ManualAssignmentEndsAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_setting#manual_assignment_starts_from IdentityDomainsIdentitySetting#manual_assignment_starts_from}.</summary>
        [JsiiProperty(name: "manualAssignmentStartsFrom", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ManualAssignmentStartsFrom
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsIdentitySettingPosixUid), fullyQualifiedName: "oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingPosixUid")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingPosixUid
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_setting#manual_assignment_ends_at IdentityDomainsIdentitySetting#manual_assignment_ends_at}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "manualAssignmentEndsAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ManualAssignmentEndsAt
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_setting#manual_assignment_starts_from IdentityDomainsIdentitySetting#manual_assignment_starts_from}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "manualAssignmentStartsFrom", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ManualAssignmentStartsFrom
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
