using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceInstallSnapsManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceInstallSnapsManagementConfig), fullyQualifiedName: "oci.osManagementHubManagedInstanceInstallSnapsManagement.OsManagementHubManagedInstanceInstallSnapsManagementConfig")]
    public interface IOsManagementHubManagedInstanceInstallSnapsManagementConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#managed_instance_id OsManagementHubManagedInstanceInstallSnapsManagement#managed_instance_id}.</summary>
        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        string ManagedInstanceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#id OsManagementHubManagedInstanceInstallSnapsManagement#id}.</summary>
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

        /// <summary>snap_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#snap_details OsManagementHubManagedInstanceInstallSnapsManagement#snap_details}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OsManagementHubManagedInstanceInstallSnapsManagement.IOsManagementHubManagedInstanceInstallSnapsManagementSnapDetails" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "snapDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubManagedInstanceInstallSnapsManagement.OsManagementHubManagedInstanceInstallSnapsManagementSnapDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SnapDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#timeouts OsManagementHubManagedInstanceInstallSnapsManagement#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceInstallSnapsManagement.OsManagementHubManagedInstanceInstallSnapsManagementTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OsManagementHubManagedInstanceInstallSnapsManagement.IOsManagementHubManagedInstanceInstallSnapsManagementTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>work_request_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#work_request_details OsManagementHubManagedInstanceInstallSnapsManagement#work_request_details}
        /// </remarks>
        [JsiiProperty(name: "workRequestDetails", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceInstallSnapsManagement.OsManagementHubManagedInstanceInstallSnapsManagementWorkRequestDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OsManagementHubManagedInstanceInstallSnapsManagement.IOsManagementHubManagedInstanceInstallSnapsManagementWorkRequestDetails? WorkRequestDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceInstallSnapsManagementConfig), fullyQualifiedName: "oci.osManagementHubManagedInstanceInstallSnapsManagement.OsManagementHubManagedInstanceInstallSnapsManagementConfig")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceInstallSnapsManagement.IOsManagementHubManagedInstanceInstallSnapsManagementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#managed_instance_id OsManagementHubManagedInstanceInstallSnapsManagement#managed_instance_id}.</summary>
            [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ManagedInstanceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#id OsManagementHubManagedInstanceInstallSnapsManagement#id}.</summary>
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

            /// <summary>snap_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#snap_details OsManagementHubManagedInstanceInstallSnapsManagement#snap_details}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OsManagementHubManagedInstanceInstallSnapsManagement.IOsManagementHubManagedInstanceInstallSnapsManagementSnapDetails" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "snapDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubManagedInstanceInstallSnapsManagement.OsManagementHubManagedInstanceInstallSnapsManagementSnapDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SnapDetails
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#timeouts OsManagementHubManagedInstanceInstallSnapsManagement#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceInstallSnapsManagement.OsManagementHubManagedInstanceInstallSnapsManagementTimeouts\"}", isOptional: true)]
            public oci.OsManagementHubManagedInstanceInstallSnapsManagement.IOsManagementHubManagedInstanceInstallSnapsManagementTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.OsManagementHubManagedInstanceInstallSnapsManagement.IOsManagementHubManagedInstanceInstallSnapsManagementTimeouts?>();
            }

            /// <summary>work_request_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#work_request_details OsManagementHubManagedInstanceInstallSnapsManagement#work_request_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workRequestDetails", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceInstallSnapsManagement.OsManagementHubManagedInstanceInstallSnapsManagementWorkRequestDetails\"}", isOptional: true)]
            public oci.OsManagementHubManagedInstanceInstallSnapsManagement.IOsManagementHubManagedInstanceInstallSnapsManagementWorkRequestDetails? WorkRequestDetails
            {
                get => GetInstanceProperty<oci.OsManagementHubManagedInstanceInstallSnapsManagement.IOsManagementHubManagedInstanceInstallSnapsManagementWorkRequestDetails?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
