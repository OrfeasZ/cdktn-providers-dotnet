using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiByValue(fqn: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersDrDrillProperties")]
    public class DisasterRecoveryDrProtectionGroupMembersDrDrillProperties : oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersDrDrillProperties
    {
        private object? _vnicMappings;

        /// <summary>vnic_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/disaster_recovery_dr_protection_group#vnic_mappings DisasterRecoveryDrProtectionGroup#vnic_mappings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersDrDrillPropertiesVnicMappings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vnicMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersDrDrillPropertiesVnicMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VnicMappings
        {
            get => _vnicMappings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersDrDrillPropertiesVnicMappings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersDrDrillPropertiesVnicMappings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vnicMappings = value;
            }
        }
    }
}
