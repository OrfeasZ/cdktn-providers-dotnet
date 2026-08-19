using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryAutomaticDrConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.disasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfigurationMembers")]
    public class DisasterRecoveryAutomaticDrConfigurationMembers : oci.DisasterRecoveryAutomaticDrConfiguration.IDisasterRecoveryAutomaticDrConfigurationMembers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/disaster_recovery_automatic_dr_configuration#member_id DisasterRecoveryAutomaticDrConfiguration#member_id}.</summary>
        [JsiiProperty(name: "memberId", typeJson: "{\"primitive\":\"string\"}")]
        public string MemberId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/disaster_recovery_automatic_dr_configuration#member_type DisasterRecoveryAutomaticDrConfiguration#member_type}.</summary>
        [JsiiProperty(name: "memberType", typeJson: "{\"primitive\":\"string\"}")]
        public string MemberType
        {
            get;
            set;
        }

        private object? _isAutoFailoverEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/disaster_recovery_automatic_dr_configuration#is_auto_failover_enabled DisasterRecoveryAutomaticDrConfiguration#is_auto_failover_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isAutoFailoverEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsAutoFailoverEnabled
        {
            get => _isAutoFailoverEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isAutoFailoverEnabled = value;
            }
        }

        private object? _isAutoSwitchoverEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/disaster_recovery_automatic_dr_configuration#is_auto_switchover_enabled DisasterRecoveryAutomaticDrConfiguration#is_auto_switchover_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isAutoSwitchoverEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsAutoSwitchoverEnabled
        {
            get => _isAutoSwitchoverEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isAutoSwitchoverEnabled = value;
            }
        }
    }
}
