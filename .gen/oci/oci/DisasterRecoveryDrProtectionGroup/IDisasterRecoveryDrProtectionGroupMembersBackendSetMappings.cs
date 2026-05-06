using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiInterface(nativeType: typeof(IDisasterRecoveryDrProtectionGroupMembersBackendSetMappings), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBackendSetMappings")]
    public interface IDisasterRecoveryDrProtectionGroupMembersBackendSetMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_backend_set_name DisasterRecoveryDrProtectionGroup#destination_backend_set_name}.</summary>
        [JsiiProperty(name: "destinationBackendSetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationBackendSetName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#is_backend_set_for_non_movable DisasterRecoveryDrProtectionGroup#is_backend_set_for_non_movable}.</summary>
        [JsiiProperty(name: "isBackendSetForNonMovable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsBackendSetForNonMovable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#source_backend_set_name DisasterRecoveryDrProtectionGroup#source_backend_set_name}.</summary>
        [JsiiProperty(name: "sourceBackendSetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceBackendSetName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDisasterRecoveryDrProtectionGroupMembersBackendSetMappings), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBackendSetMappings")]
        internal sealed class _Proxy : DeputyBase, oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBackendSetMappings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_backend_set_name DisasterRecoveryDrProtectionGroup#destination_backend_set_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationBackendSetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationBackendSetName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#is_backend_set_for_non_movable DisasterRecoveryDrProtectionGroup#is_backend_set_for_non_movable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isBackendSetForNonMovable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsBackendSetForNonMovable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#source_backend_set_name DisasterRecoveryDrProtectionGroup#source_backend_set_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceBackendSetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceBackendSetName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
