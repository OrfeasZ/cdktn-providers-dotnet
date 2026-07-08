using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryAutomaticDrConfiguration
{
    [JsiiInterface(nativeType: typeof(IDisasterRecoveryAutomaticDrConfigurationMembers), fullyQualifiedName: "oci.disasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfigurationMembers")]
    public interface IDisasterRecoveryAutomaticDrConfigurationMembers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/disaster_recovery_automatic_dr_configuration#member_id DisasterRecoveryAutomaticDrConfiguration#member_id}.</summary>
        [JsiiProperty(name: "memberId", typeJson: "{\"primitive\":\"string\"}")]
        string MemberId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/disaster_recovery_automatic_dr_configuration#member_type DisasterRecoveryAutomaticDrConfiguration#member_type}.</summary>
        [JsiiProperty(name: "memberType", typeJson: "{\"primitive\":\"string\"}")]
        string MemberType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/disaster_recovery_automatic_dr_configuration#is_auto_failover_enabled DisasterRecoveryAutomaticDrConfiguration#is_auto_failover_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isAutoFailoverEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAutoFailoverEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/disaster_recovery_automatic_dr_configuration#is_auto_switchover_enabled DisasterRecoveryAutomaticDrConfiguration#is_auto_switchover_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isAutoSwitchoverEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAutoSwitchoverEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDisasterRecoveryAutomaticDrConfigurationMembers), fullyQualifiedName: "oci.disasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfigurationMembers")]
        internal sealed class _Proxy : DeputyBase, oci.DisasterRecoveryAutomaticDrConfiguration.IDisasterRecoveryAutomaticDrConfigurationMembers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/disaster_recovery_automatic_dr_configuration#member_id DisasterRecoveryAutomaticDrConfiguration#member_id}.</summary>
            [JsiiProperty(name: "memberId", typeJson: "{\"primitive\":\"string\"}")]
            public string MemberId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/disaster_recovery_automatic_dr_configuration#member_type DisasterRecoveryAutomaticDrConfiguration#member_type}.</summary>
            [JsiiProperty(name: "memberType", typeJson: "{\"primitive\":\"string\"}")]
            public string MemberType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/disaster_recovery_automatic_dr_configuration#is_auto_failover_enabled DisasterRecoveryAutomaticDrConfiguration#is_auto_failover_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isAutoFailoverEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAutoFailoverEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/disaster_recovery_automatic_dr_configuration#is_auto_switchover_enabled DisasterRecoveryAutomaticDrConfiguration#is_auto_switchover_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isAutoSwitchoverEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAutoSwitchoverEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
