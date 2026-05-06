using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceNodeBackup
{
    [JsiiInterface(nativeType: typeof(IBdsBdsInstanceNodeBackupConfig), fullyQualifiedName: "oci.bdsBdsInstanceNodeBackup.BdsBdsInstanceNodeBackupConfig")]
    public interface IBdsBdsInstanceNodeBackupConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup#backup_type BdsBdsInstanceNodeBackup#backup_type}.</summary>
        [JsiiProperty(name: "backupType", typeJson: "{\"primitive\":\"string\"}")]
        string BackupType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup#bds_instance_id BdsBdsInstanceNodeBackup#bds_instance_id}.</summary>
        [JsiiProperty(name: "bdsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        string BdsInstanceId
        {
            get;
        }

        /// <summary>level_type_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup#level_type_details BdsBdsInstanceNodeBackup#level_type_details}
        /// </remarks>
        [JsiiProperty(name: "levelTypeDetails", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceNodeBackup.BdsBdsInstanceNodeBackupLevelTypeDetails\"}")]
        oci.BdsBdsInstanceNodeBackup.IBdsBdsInstanceNodeBackupLevelTypeDetails LevelTypeDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup#backup_config_id BdsBdsInstanceNodeBackup#backup_config_id}.</summary>
        [JsiiProperty(name: "backupConfigId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackupConfigId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup#display_name BdsBdsInstanceNodeBackup#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup#id BdsBdsInstanceNodeBackup#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup#node_instance_id BdsBdsInstanceNodeBackup#node_instance_id}.</summary>
        [JsiiProperty(name: "nodeInstanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NodeInstanceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup#timeouts BdsBdsInstanceNodeBackup#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceNodeBackup.BdsBdsInstanceNodeBackupTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.BdsBdsInstanceNodeBackup.IBdsBdsInstanceNodeBackupTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsInstanceNodeBackupConfig), fullyQualifiedName: "oci.bdsBdsInstanceNodeBackup.BdsBdsInstanceNodeBackupConfig")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsInstanceNodeBackup.IBdsBdsInstanceNodeBackupConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup#backup_type BdsBdsInstanceNodeBackup#backup_type}.</summary>
            [JsiiProperty(name: "backupType", typeJson: "{\"primitive\":\"string\"}")]
            public string BackupType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup#bds_instance_id BdsBdsInstanceNodeBackup#bds_instance_id}.</summary>
            [JsiiProperty(name: "bdsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string BdsInstanceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>level_type_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup#level_type_details BdsBdsInstanceNodeBackup#level_type_details}
            /// </remarks>
            [JsiiProperty(name: "levelTypeDetails", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceNodeBackup.BdsBdsInstanceNodeBackupLevelTypeDetails\"}")]
            public oci.BdsBdsInstanceNodeBackup.IBdsBdsInstanceNodeBackupLevelTypeDetails LevelTypeDetails
            {
                get => GetInstanceProperty<oci.BdsBdsInstanceNodeBackup.IBdsBdsInstanceNodeBackupLevelTypeDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup#backup_config_id BdsBdsInstanceNodeBackup#backup_config_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupConfigId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackupConfigId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup#display_name BdsBdsInstanceNodeBackup#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup#id BdsBdsInstanceNodeBackup#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup#node_instance_id BdsBdsInstanceNodeBackup#node_instance_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeInstanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodeInstanceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup#timeouts BdsBdsInstanceNodeBackup#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceNodeBackup.BdsBdsInstanceNodeBackupTimeouts\"}", isOptional: true)]
            public oci.BdsBdsInstanceNodeBackup.IBdsBdsInstanceNodeBackupTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.BdsBdsInstanceNodeBackup.IBdsBdsInstanceNodeBackupTimeouts?>();
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
