using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementTaskRecord
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetails")]
    public class FleetAppsManagementTaskRecordDetails : oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetails
    {
        /// <summary>execution_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#execution_details FleetAppsManagementTaskRecord#execution_details}
        /// </remarks>
        [JsiiProperty(name: "executionDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetails\"}")]
        public oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsExecutionDetails ExecutionDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#scope FleetAppsManagementTaskRecord#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        public string Scope
        {
            get;
            set;
        }

        private object? _isApplySubjectTask;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#is_apply_subject_task FleetAppsManagementTaskRecord#is_apply_subject_task}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isApplySubjectTask", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsApplySubjectTask
        {
            get => _isApplySubjectTask;
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
                _isApplySubjectTask = value;
            }
        }

        private object? _isDiscoveryOutputTask;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#is_discovery_output_task FleetAppsManagementTaskRecord#is_discovery_output_task}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isDiscoveryOutputTask", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsDiscoveryOutputTask
        {
            get => _isDiscoveryOutputTask;
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
                _isDiscoveryOutputTask = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#operation FleetAppsManagementTaskRecord#operation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Operation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#os_type FleetAppsManagementTaskRecord#os_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "osType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OsType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#platform FleetAppsManagementTaskRecord#platform}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Platform
        {
            get;
            set;
        }

        /// <summary>properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#properties FleetAppsManagementTaskRecord#properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsProperties\"}", isOptional: true)]
        public oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsProperties? Properties
        {
            get;
            set;
        }
    }
}
