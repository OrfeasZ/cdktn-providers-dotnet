using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiInterface(nativeType: typeof(IDisasterRecoveryDrProtectionGroupMembersResourceModifierMappings), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersResourceModifierMappings")]
    public interface IDisasterRecoveryDrProtectionGroupMembersResourceModifierMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/disaster_recovery_dr_protection_group#config_map DisasterRecoveryDrProtectionGroup#config_map}.</summary>
        [JsiiProperty(name: "configMap", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConfigMap
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/disaster_recovery_dr_protection_group#namespace DisasterRecoveryDrProtectionGroup#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDisasterRecoveryDrProtectionGroupMembersResourceModifierMappings), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersResourceModifierMappings")]
        internal sealed class _Proxy : DeputyBase, oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersResourceModifierMappings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/disaster_recovery_dr_protection_group#config_map DisasterRecoveryDrProtectionGroup#config_map}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configMap", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConfigMap
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/disaster_recovery_dr_protection_group#namespace DisasterRecoveryDrProtectionGroup#namespace}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
