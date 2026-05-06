using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementConfig), fullyQualifiedName: "oci.osManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementConfig")]
    public interface IOsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_detach_software_sources_management#managed_instance_group_id OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement#managed_instance_group_id}.</summary>
        [JsiiProperty(name: "managedInstanceGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string ManagedInstanceGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_detach_software_sources_management#software_sources OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement#software_sources}.</summary>
        [JsiiProperty(name: "softwareSources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SoftwareSources
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_detach_software_sources_management#id OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_detach_software_sources_management#timeouts OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement.IOsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>work_request_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_detach_software_sources_management#work_request_details OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement#work_request_details}
        /// </remarks>
        [JsiiProperty(name: "workRequestDetails", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementWorkRequestDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement.IOsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementWorkRequestDetails? WorkRequestDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementConfig), fullyQualifiedName: "oci.osManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementConfig")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement.IOsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_detach_software_sources_management#managed_instance_group_id OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement#managed_instance_group_id}.</summary>
            [JsiiProperty(name: "managedInstanceGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string ManagedInstanceGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_detach_software_sources_management#software_sources OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement#software_sources}.</summary>
            [JsiiProperty(name: "softwareSources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SoftwareSources
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_detach_software_sources_management#id OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_detach_software_sources_management#timeouts OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementTimeouts\"}", isOptional: true)]
            public oci.OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement.IOsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement.IOsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementTimeouts?>();
            }

            /// <summary>work_request_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_detach_software_sources_management#work_request_details OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement#work_request_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workRequestDetails", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementWorkRequestDetails\"}", isOptional: true)]
            public oci.OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement.IOsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementWorkRequestDetails? WorkRequestDetails
            {
                get => GetInstanceProperty<oci.OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement.IOsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementWorkRequestDetails?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
