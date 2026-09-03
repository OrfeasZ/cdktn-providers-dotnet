using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudExadataInfrastructureManagedexadataManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementCloudExadataInfrastructureManagedexadataManagementConfig), fullyQualifiedName: "oci.databaseManagementCloudExadataInfrastructureManagedexadataManagement.DatabaseManagementCloudExadataInfrastructureManagedexadataManagementConfig")]
    public interface IDatabaseManagementCloudExadataInfrastructureManagedexadataManagementConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_management_cloud_exadata_infrastructure_managedexadata_management#cloud_exadata_infrastructure_id DatabaseManagementCloudExadataInfrastructureManagedexadataManagement#cloud_exadata_infrastructure_id}.</summary>
        [JsiiProperty(name: "cloudExadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        string CloudExadataInfrastructureId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_management_cloud_exadata_infrastructure_managedexadata_management#enable_managedexadata DatabaseManagementCloudExadataInfrastructureManagedexadataManagement#enable_managedexadata}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enableManagedexadata", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object EnableManagedexadata
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_management_cloud_exadata_infrastructure_managedexadata_management#id DatabaseManagementCloudExadataInfrastructureManagedexadataManagement#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_management_cloud_exadata_infrastructure_managedexadata_management#license_model DatabaseManagementCloudExadataInfrastructureManagedexadataManagement#license_model}.</summary>
        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LicenseModel
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_management_cloud_exadata_infrastructure_managedexadata_management#timeouts DatabaseManagementCloudExadataInfrastructureManagedexadataManagement#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseManagementCloudExadataInfrastructureManagedexadataManagement.DatabaseManagementCloudExadataInfrastructureManagedexadataManagementTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseManagementCloudExadataInfrastructureManagedexadataManagement.IDatabaseManagementCloudExadataInfrastructureManagedexadataManagementTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementCloudExadataInfrastructureManagedexadataManagementConfig), fullyQualifiedName: "oci.databaseManagementCloudExadataInfrastructureManagedexadataManagement.DatabaseManagementCloudExadataInfrastructureManagedexadataManagementConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementCloudExadataInfrastructureManagedexadataManagement.IDatabaseManagementCloudExadataInfrastructureManagedexadataManagementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_management_cloud_exadata_infrastructure_managedexadata_management#cloud_exadata_infrastructure_id DatabaseManagementCloudExadataInfrastructureManagedexadataManagement#cloud_exadata_infrastructure_id}.</summary>
            [JsiiProperty(name: "cloudExadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}")]
            public string CloudExadataInfrastructureId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_management_cloud_exadata_infrastructure_managedexadata_management#enable_managedexadata DatabaseManagementCloudExadataInfrastructureManagedexadataManagement#enable_managedexadata}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enableManagedexadata", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object EnableManagedexadata
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_management_cloud_exadata_infrastructure_managedexadata_management#id DatabaseManagementCloudExadataInfrastructureManagedexadataManagement#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_management_cloud_exadata_infrastructure_managedexadata_management#license_model DatabaseManagementCloudExadataInfrastructureManagedexadataManagement#license_model}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LicenseModel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_management_cloud_exadata_infrastructure_managedexadata_management#timeouts DatabaseManagementCloudExadataInfrastructureManagedexadataManagement#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseManagementCloudExadataInfrastructureManagedexadataManagement.DatabaseManagementCloudExadataInfrastructureManagedexadataManagementTimeouts\"}", isOptional: true)]
            public oci.DatabaseManagementCloudExadataInfrastructureManagedexadataManagement.IDatabaseManagementCloudExadataInfrastructureManagedexadataManagementTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseManagementCloudExadataInfrastructureManagedexadataManagement.IDatabaseManagementCloudExadataInfrastructureManagedexadataManagementTimeouts?>();
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
