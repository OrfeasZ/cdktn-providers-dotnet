using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementCloudDbSystemCloudDatabaseManagementsManagementConfig), fullyQualifiedName: "oci.databaseManagementCloudDbSystemCloudDatabaseManagementsManagement.DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagementConfig")]
    public interface IDatabaseManagementCloudDbSystemCloudDatabaseManagementsManagementConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#cloud_db_system_id DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#cloud_db_system_id}.</summary>
        [JsiiProperty(name: "cloudDbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        string CloudDbSystemId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#enable_cloud_database_management DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#enable_cloud_database_management}.</summary>
        [JsiiProperty(name: "enableCloudDatabaseManagement", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object EnableCloudDatabaseManagement
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#id DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#is_enabled DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#is_enabled}.</summary>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#metadata DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#metadata}.</summary>
        [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#timeouts DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseManagementCloudDbSystemCloudDatabaseManagementsManagement.DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagementTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement.IDatabaseManagementCloudDbSystemCloudDatabaseManagementsManagementTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementCloudDbSystemCloudDatabaseManagementsManagementConfig), fullyQualifiedName: "oci.databaseManagementCloudDbSystemCloudDatabaseManagementsManagement.DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagementConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement.IDatabaseManagementCloudDbSystemCloudDatabaseManagementsManagementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#cloud_db_system_id DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#cloud_db_system_id}.</summary>
            [JsiiProperty(name: "cloudDbSystemId", typeJson: "{\"primitive\":\"string\"}")]
            public string CloudDbSystemId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#enable_cloud_database_management DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#enable_cloud_database_management}.</summary>
            [JsiiProperty(name: "enableCloudDatabaseManagement", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object EnableCloudDatabaseManagement
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#id DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#is_enabled DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#is_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#metadata DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#metadata}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Metadata
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#timeouts DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseManagementCloudDbSystemCloudDatabaseManagementsManagement.DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagementTimeouts\"}", isOptional: true)]
            public oci.DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement.IDatabaseManagementCloudDbSystemCloudDatabaseManagementsManagementTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement.IDatabaseManagementCloudDbSystemCloudDatabaseManagementsManagementTimeouts?>();
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
