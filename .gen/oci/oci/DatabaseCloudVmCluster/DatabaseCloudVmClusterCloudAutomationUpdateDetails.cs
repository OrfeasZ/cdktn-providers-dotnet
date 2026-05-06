using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudVmCluster
{
    [JsiiByValue(fqn: "oci.databaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetails")]
    public class DatabaseCloudVmClusterCloudAutomationUpdateDetails : oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterCloudAutomationUpdateDetails
    {
        /// <summary>apply_update_time_preference block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster#apply_update_time_preference DatabaseCloudVmCluster#apply_update_time_preference}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applyUpdateTimePreference", typeJson: "{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference\"}", isOptional: true)]
        public oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference? ApplyUpdateTimePreference
        {
            get;
            set;
        }

        /// <summary>freeze_period block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster#freeze_period DatabaseCloudVmCluster#freeze_period}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "freezePeriod", typeJson: "{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsFreezePeriod\"}", isOptional: true)]
        public oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterCloudAutomationUpdateDetailsFreezePeriod? FreezePeriod
        {
            get;
            set;
        }

        private object? _isEarlyAdoptionEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster#is_early_adoption_enabled DatabaseCloudVmCluster#is_early_adoption_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isEarlyAdoptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsEarlyAdoptionEnabled
        {
            get => _isEarlyAdoptionEnabled;
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
                _isEarlyAdoptionEnabled = value;
            }
        }

        private object? _isFreezePeriodEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster#is_freeze_period_enabled DatabaseCloudVmCluster#is_freeze_period_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isFreezePeriodEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsFreezePeriodEnabled
        {
            get => _isFreezePeriodEnabled;
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
                _isFreezePeriodEnabled = value;
            }
        }
    }
}
