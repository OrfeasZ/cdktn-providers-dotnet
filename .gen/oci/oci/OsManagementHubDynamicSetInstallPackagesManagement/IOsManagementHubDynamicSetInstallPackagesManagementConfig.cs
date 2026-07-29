using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubDynamicSetInstallPackagesManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubDynamicSetInstallPackagesManagementConfig), fullyQualifiedName: "oci.osManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagementConfig")]
    public interface IOsManagementHubDynamicSetInstallPackagesManagementConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#dynamic_set_id OsManagementHubDynamicSetInstallPackagesManagement#dynamic_set_id}.</summary>
        [JsiiProperty(name: "dynamicSetId", typeJson: "{\"primitive\":\"string\"}")]
        string DynamicSetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#package_names OsManagementHubDynamicSetInstallPackagesManagement#package_names}.</summary>
        [JsiiProperty(name: "packageNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] PackageNames
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#id OsManagementHubDynamicSetInstallPackagesManagement#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#managed_instances OsManagementHubDynamicSetInstallPackagesManagement#managed_instances}.</summary>
        [JsiiProperty(name: "managedInstances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ManagedInstances
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#timeouts OsManagementHubDynamicSetInstallPackagesManagement#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.osManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagementTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OsManagementHubDynamicSetInstallPackagesManagement.IOsManagementHubDynamicSetInstallPackagesManagementTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>work_request_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#work_request_details OsManagementHubDynamicSetInstallPackagesManagement#work_request_details}
        /// </remarks>
        [JsiiProperty(name: "workRequestDetails", typeJson: "{\"fqn\":\"oci.osManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagementWorkRequestDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OsManagementHubDynamicSetInstallPackagesManagement.IOsManagementHubDynamicSetInstallPackagesManagementWorkRequestDetails? WorkRequestDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubDynamicSetInstallPackagesManagementConfig), fullyQualifiedName: "oci.osManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagementConfig")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubDynamicSetInstallPackagesManagement.IOsManagementHubDynamicSetInstallPackagesManagementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#dynamic_set_id OsManagementHubDynamicSetInstallPackagesManagement#dynamic_set_id}.</summary>
            [JsiiProperty(name: "dynamicSetId", typeJson: "{\"primitive\":\"string\"}")]
            public string DynamicSetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#package_names OsManagementHubDynamicSetInstallPackagesManagement#package_names}.</summary>
            [JsiiProperty(name: "packageNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] PackageNames
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#id OsManagementHubDynamicSetInstallPackagesManagement#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#managed_instances OsManagementHubDynamicSetInstallPackagesManagement#managed_instances}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedInstances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ManagedInstances
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#timeouts OsManagementHubDynamicSetInstallPackagesManagement#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.osManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagementTimeouts\"}", isOptional: true)]
            public oci.OsManagementHubDynamicSetInstallPackagesManagement.IOsManagementHubDynamicSetInstallPackagesManagementTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.OsManagementHubDynamicSetInstallPackagesManagement.IOsManagementHubDynamicSetInstallPackagesManagementTimeouts?>();
            }

            /// <summary>work_request_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#work_request_details OsManagementHubDynamicSetInstallPackagesManagement#work_request_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workRequestDetails", typeJson: "{\"fqn\":\"oci.osManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagementWorkRequestDetails\"}", isOptional: true)]
            public oci.OsManagementHubDynamicSetInstallPackagesManagement.IOsManagementHubDynamicSetInstallPackagesManagementWorkRequestDetails? WorkRequestDetails
            {
                get => GetInstanceProperty<oci.OsManagementHubDynamicSetInstallPackagesManagement.IOsManagementHubDynamicSetInstallPackagesManagementWorkRequestDetails?>();
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
