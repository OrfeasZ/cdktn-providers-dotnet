using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceSwitchSnapChannelManagementConfig), fullyQualifiedName: "oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementConfig")]
    public interface IOsManagementHubManagedInstanceSwitchSnapChannelManagementConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#managed_instance_id OsManagementHubManagedInstanceSwitchSnapChannelManagement#managed_instance_id}.</summary>
        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        string ManagedInstanceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#id OsManagementHubManagedInstanceSwitchSnapChannelManagement#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#snap_details OsManagementHubManagedInstanceSwitchSnapChannelManagement#snap_details}
        /// </remarks>
        [JsiiProperty(name: "snapDetails", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementSnapDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementSnapDetails? SnapDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#timeouts OsManagementHubManagedInstanceSwitchSnapChannelManagement#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>work_request_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#work_request_details OsManagementHubManagedInstanceSwitchSnapChannelManagement#work_request_details}
        /// </remarks>
        [JsiiProperty(name: "workRequestDetails", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementWorkRequestDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementWorkRequestDetails? WorkRequestDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceSwitchSnapChannelManagementConfig), fullyQualifiedName: "oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementConfig")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#managed_instance_id OsManagementHubManagedInstanceSwitchSnapChannelManagement#managed_instance_id}.</summary>
            [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ManagedInstanceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#id OsManagementHubManagedInstanceSwitchSnapChannelManagement#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#snap_details OsManagementHubManagedInstanceSwitchSnapChannelManagement#snap_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "snapDetails", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementSnapDetails\"}", isOptional: true)]
            public oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementSnapDetails? SnapDetails
            {
                get => GetInstanceProperty<oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementSnapDetails?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#timeouts OsManagementHubManagedInstanceSwitchSnapChannelManagement#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementTimeouts\"}", isOptional: true)]
            public oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementTimeouts?>();
            }

            /// <summary>work_request_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#work_request_details OsManagementHubManagedInstanceSwitchSnapChannelManagement#work_request_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workRequestDetails", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementWorkRequestDetails\"}", isOptional: true)]
            public oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementWorkRequestDetails? WorkRequestDetails
            {
                get => GetInstanceProperty<oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementWorkRequestDetails?>();
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
