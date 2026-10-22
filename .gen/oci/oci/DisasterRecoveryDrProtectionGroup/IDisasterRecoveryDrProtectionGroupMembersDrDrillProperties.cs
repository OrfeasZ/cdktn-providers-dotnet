using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiInterface(nativeType: typeof(IDisasterRecoveryDrProtectionGroupMembersDrDrillProperties), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersDrDrillProperties")]
    public interface IDisasterRecoveryDrProtectionGroupMembersDrDrillProperties
    {
        /// <summary>vnic_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/disaster_recovery_dr_protection_group#vnic_mappings DisasterRecoveryDrProtectionGroup#vnic_mappings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersDrDrillPropertiesVnicMappings" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "vnicMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersDrDrillPropertiesVnicMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VnicMappings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDisasterRecoveryDrProtectionGroupMembersDrDrillProperties), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersDrDrillProperties")]
        internal sealed class _Proxy : DeputyBase, oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersDrDrillProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>vnic_mappings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/disaster_recovery_dr_protection_group#vnic_mappings DisasterRecoveryDrProtectionGroup#vnic_mappings}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersDrDrillPropertiesVnicMappings" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vnicMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersDrDrillPropertiesVnicMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VnicMappings
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
