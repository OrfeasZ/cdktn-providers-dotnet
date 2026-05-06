using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceNodeBackupConfiguration
{
    [JsiiInterface(nativeType: typeof(IBdsBdsInstanceNodeBackupConfigurationConfig), fullyQualifiedName: "oci.bdsBdsInstanceNodeBackupConfiguration.BdsBdsInstanceNodeBackupConfigurationConfig")]
    public interface IBdsBdsInstanceNodeBackupConfigurationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#bds_instance_id BdsBdsInstanceNodeBackupConfiguration#bds_instance_id}.</summary>
        [JsiiProperty(name: "bdsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        string BdsInstanceId
        {
            get;
        }

        /// <summary>level_type_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#level_type_details BdsBdsInstanceNodeBackupConfiguration#level_type_details}
        /// </remarks>
        [JsiiProperty(name: "levelTypeDetails", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceNodeBackupConfiguration.BdsBdsInstanceNodeBackupConfigurationLevelTypeDetails\"}")]
        oci.BdsBdsInstanceNodeBackupConfiguration.IBdsBdsInstanceNodeBackupConfigurationLevelTypeDetails LevelTypeDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#schedule BdsBdsInstanceNodeBackupConfiguration#schedule}.</summary>
        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
        string Schedule
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#backup_type BdsBdsInstanceNodeBackupConfiguration#backup_type}.</summary>
        [JsiiProperty(name: "backupType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackupType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#display_name BdsBdsInstanceNodeBackupConfiguration#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#id BdsBdsInstanceNodeBackupConfiguration#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#number_of_backups_to_retain BdsBdsInstanceNodeBackupConfiguration#number_of_backups_to_retain}.</summary>
        [JsiiProperty(name: "numberOfBackupsToRetain", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NumberOfBackupsToRetain
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#timeouts BdsBdsInstanceNodeBackupConfiguration#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceNodeBackupConfiguration.BdsBdsInstanceNodeBackupConfigurationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.BdsBdsInstanceNodeBackupConfiguration.IBdsBdsInstanceNodeBackupConfigurationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#timezone BdsBdsInstanceNodeBackupConfiguration#timezone}.</summary>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Timezone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsInstanceNodeBackupConfigurationConfig), fullyQualifiedName: "oci.bdsBdsInstanceNodeBackupConfiguration.BdsBdsInstanceNodeBackupConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsInstanceNodeBackupConfiguration.IBdsBdsInstanceNodeBackupConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#bds_instance_id BdsBdsInstanceNodeBackupConfiguration#bds_instance_id}.</summary>
            [JsiiProperty(name: "bdsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string BdsInstanceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>level_type_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#level_type_details BdsBdsInstanceNodeBackupConfiguration#level_type_details}
            /// </remarks>
            [JsiiProperty(name: "levelTypeDetails", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceNodeBackupConfiguration.BdsBdsInstanceNodeBackupConfigurationLevelTypeDetails\"}")]
            public oci.BdsBdsInstanceNodeBackupConfiguration.IBdsBdsInstanceNodeBackupConfigurationLevelTypeDetails LevelTypeDetails
            {
                get => GetInstanceProperty<oci.BdsBdsInstanceNodeBackupConfiguration.IBdsBdsInstanceNodeBackupConfigurationLevelTypeDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#schedule BdsBdsInstanceNodeBackupConfiguration#schedule}.</summary>
            [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
            public string Schedule
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#backup_type BdsBdsInstanceNodeBackupConfiguration#backup_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackupType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#display_name BdsBdsInstanceNodeBackupConfiguration#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#id BdsBdsInstanceNodeBackupConfiguration#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#number_of_backups_to_retain BdsBdsInstanceNodeBackupConfiguration#number_of_backups_to_retain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "numberOfBackupsToRetain", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NumberOfBackupsToRetain
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#timeouts BdsBdsInstanceNodeBackupConfiguration#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceNodeBackupConfiguration.BdsBdsInstanceNodeBackupConfigurationTimeouts\"}", isOptional: true)]
            public oci.BdsBdsInstanceNodeBackupConfiguration.IBdsBdsInstanceNodeBackupConfigurationTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.BdsBdsInstanceNodeBackupConfiguration.IBdsBdsInstanceNodeBackupConfigurationTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#timezone BdsBdsInstanceNodeBackupConfiguration#timezone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Timezone
            {
                get => GetInstanceProperty<string?>();
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
