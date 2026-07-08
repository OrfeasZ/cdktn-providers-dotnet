using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubScheduledJob
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubScheduledJobOperations), fullyQualifiedName: "oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperations")]
    public interface IOsManagementHubScheduledJobOperations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_scheduled_job#operation_type OsManagementHubScheduledJob#operation_type}.</summary>
        [JsiiProperty(name: "operationType", typeJson: "{\"primitive\":\"string\"}")]
        string OperationType
        {
            get;
        }

        /// <summary>install_snap_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_scheduled_job#install_snap_details OsManagementHubScheduledJob#install_snap_details}
        /// </remarks>
        [JsiiProperty(name: "installSnapDetails", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsInstallSnapDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsInstallSnapDetails? InstallSnapDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>manage_module_streams_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_scheduled_job#manage_module_streams_details OsManagementHubScheduledJob#manage_module_streams_details}
        /// </remarks>
        [JsiiProperty(name: "manageModuleStreamsDetails", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetails? ManageModuleStreamsDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_scheduled_job#package_names OsManagementHubScheduledJob#package_names}.</summary>
        [JsiiProperty(name: "packageNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PackageNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_scheduled_job#reboot_timeout_in_mins OsManagementHubScheduledJob#reboot_timeout_in_mins}.</summary>
        [JsiiProperty(name: "rebootTimeoutInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RebootTimeoutInMins
        {
            get
            {
                return null;
            }
        }

        /// <summary>remove_snap_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_scheduled_job#remove_snap_details OsManagementHubScheduledJob#remove_snap_details}
        /// </remarks>
        [JsiiProperty(name: "removeSnapDetails", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsRemoveSnapDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsRemoveSnapDetails? RemoveSnapDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_scheduled_job#software_source_ids OsManagementHubScheduledJob#software_source_ids}.</summary>
        [JsiiProperty(name: "softwareSourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SoftwareSourceIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>switch_module_streams_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_scheduled_job#switch_module_streams_details OsManagementHubScheduledJob#switch_module_streams_details}
        /// </remarks>
        [JsiiProperty(name: "switchModuleStreamsDetails", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsSwitchModuleStreamsDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsSwitchModuleStreamsDetails? SwitchModuleStreamsDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>switch_snap_channel_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_scheduled_job#switch_snap_channel_details OsManagementHubScheduledJob#switch_snap_channel_details}
        /// </remarks>
        [JsiiProperty(name: "switchSnapChannelDetails", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsSwitchSnapChannelDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsSwitchSnapChannelDetails? SwitchSnapChannelDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_scheduled_job#windows_update_names OsManagementHubScheduledJob#windows_update_names}.</summary>
        [JsiiProperty(name: "windowsUpdateNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? WindowsUpdateNames
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubScheduledJobOperations), fullyQualifiedName: "oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperations")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_scheduled_job#operation_type OsManagementHubScheduledJob#operation_type}.</summary>
            [JsiiProperty(name: "operationType", typeJson: "{\"primitive\":\"string\"}")]
            public string OperationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>install_snap_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_scheduled_job#install_snap_details OsManagementHubScheduledJob#install_snap_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "installSnapDetails", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsInstallSnapDetails\"}", isOptional: true)]
            public oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsInstallSnapDetails? InstallSnapDetails
            {
                get => GetInstanceProperty<oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsInstallSnapDetails?>();
            }

            /// <summary>manage_module_streams_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_scheduled_job#manage_module_streams_details OsManagementHubScheduledJob#manage_module_streams_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "manageModuleStreamsDetails", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetails\"}", isOptional: true)]
            public oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetails? ManageModuleStreamsDetails
            {
                get => GetInstanceProperty<oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_scheduled_job#package_names OsManagementHubScheduledJob#package_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "packageNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PackageNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_scheduled_job#reboot_timeout_in_mins OsManagementHubScheduledJob#reboot_timeout_in_mins}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rebootTimeoutInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RebootTimeoutInMins
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>remove_snap_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_scheduled_job#remove_snap_details OsManagementHubScheduledJob#remove_snap_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "removeSnapDetails", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsRemoveSnapDetails\"}", isOptional: true)]
            public oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsRemoveSnapDetails? RemoveSnapDetails
            {
                get => GetInstanceProperty<oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsRemoveSnapDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_scheduled_job#software_source_ids OsManagementHubScheduledJob#software_source_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "softwareSourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SoftwareSourceIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>switch_module_streams_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_scheduled_job#switch_module_streams_details OsManagementHubScheduledJob#switch_module_streams_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "switchModuleStreamsDetails", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsSwitchModuleStreamsDetails\"}", isOptional: true)]
            public oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsSwitchModuleStreamsDetails? SwitchModuleStreamsDetails
            {
                get => GetInstanceProperty<oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsSwitchModuleStreamsDetails?>();
            }

            /// <summary>switch_snap_channel_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_scheduled_job#switch_snap_channel_details OsManagementHubScheduledJob#switch_snap_channel_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "switchSnapChannelDetails", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsSwitchSnapChannelDetails\"}", isOptional: true)]
            public oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsSwitchSnapChannelDetails? SwitchSnapChannelDetails
            {
                get => GetInstanceProperty<oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsSwitchSnapChannelDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_scheduled_job#windows_update_names OsManagementHubScheduledJob#windows_update_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "windowsUpdateNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? WindowsUpdateNames
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
