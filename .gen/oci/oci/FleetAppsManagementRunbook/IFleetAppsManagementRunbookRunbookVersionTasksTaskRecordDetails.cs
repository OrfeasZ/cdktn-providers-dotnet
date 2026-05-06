using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbook
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetails), fullyQualifiedName: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetails")]
    public interface IFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#scope FleetAppsManagementRunbook#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        string Scope
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#description FleetAppsManagementRunbook#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>execution_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#execution_details FleetAppsManagementRunbook#execution_details}
        /// </remarks>
        [JsiiProperty(name: "executionDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsExecutionDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsExecutionDetails? ExecutionDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#is_apply_subject_task FleetAppsManagementRunbook#is_apply_subject_task}.</summary>
        [JsiiProperty(name: "isApplySubjectTask", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsApplySubjectTask
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#is_copy_to_library_enabled FleetAppsManagementRunbook#is_copy_to_library_enabled}.</summary>
        [JsiiProperty(name: "isCopyToLibraryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsCopyToLibraryEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#is_discovery_output_task FleetAppsManagementRunbook#is_discovery_output_task}.</summary>
        [JsiiProperty(name: "isDiscoveryOutputTask", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsDiscoveryOutputTask
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#name FleetAppsManagementRunbook#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#os_type FleetAppsManagementRunbook#os_type}.</summary>
        [JsiiProperty(name: "osType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OsType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#platform FleetAppsManagementRunbook#platform}.</summary>
        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Platform
        {
            get
            {
                return null;
            }
        }

        /// <summary>properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#properties FleetAppsManagementRunbook#properties}
        /// </remarks>
        [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsProperties? Properties
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#task_record_id FleetAppsManagementRunbook#task_record_id}.</summary>
        [JsiiProperty(name: "taskRecordId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TaskRecordId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetails), fullyQualifiedName: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetails")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#scope FleetAppsManagementRunbook#scope}.</summary>
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
            public string Scope
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#description FleetAppsManagementRunbook#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>execution_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#execution_details FleetAppsManagementRunbook#execution_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "executionDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsExecutionDetails\"}", isOptional: true)]
            public oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsExecutionDetails? ExecutionDetails
            {
                get => GetInstanceProperty<oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsExecutionDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#is_apply_subject_task FleetAppsManagementRunbook#is_apply_subject_task}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isApplySubjectTask", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsApplySubjectTask
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#is_copy_to_library_enabled FleetAppsManagementRunbook#is_copy_to_library_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isCopyToLibraryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsCopyToLibraryEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#is_discovery_output_task FleetAppsManagementRunbook#is_discovery_output_task}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isDiscoveryOutputTask", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsDiscoveryOutputTask
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#name FleetAppsManagementRunbook#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#os_type FleetAppsManagementRunbook#os_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "osType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OsType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#platform FleetAppsManagementRunbook#platform}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Platform
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#properties FleetAppsManagementRunbook#properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsProperties\"}", isOptional: true)]
            public oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsProperties? Properties
            {
                get => GetInstanceProperty<oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsProperties?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#task_record_id FleetAppsManagementRunbook#task_record_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "taskRecordId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaskRecordId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
