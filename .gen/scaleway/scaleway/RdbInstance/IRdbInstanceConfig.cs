using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.RdbInstance
{
    [JsiiInterface(nativeType: typeof(IRdbInstanceConfig), fullyQualifiedName: "scaleway.rdbInstance.RdbInstanceConfig")]
    public interface IRdbInstanceConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The type of database instance you want to create.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#node_type RdbInstance#node_type}
        /// </remarks>
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        string NodeType
        {
            get;
        }

        /// <summary>Boolean to store logical backups in the same region as the database instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#backup_same_region RdbInstance#backup_same_region}
        /// </remarks>
        [JsiiProperty(name: "backupSameRegion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BackupSameRegion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Backup schedule frequency in hours.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#backup_schedule_frequency RdbInstance#backup_schedule_frequency}
        /// </remarks>
        [JsiiProperty(name: "backupScheduleFrequency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackupScheduleFrequency
        {
            get
            {
                return null;
            }
        }

        /// <summary>Backup schedule retention in days.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#backup_schedule_retention RdbInstance#backup_schedule_retention}
        /// </remarks>
        [JsiiProperty(name: "backupScheduleRetention", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackupScheduleRetention
        {
            get
            {
                return null;
            }
        }

        /// <summary>Disable automated backup for the database instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#disable_backup RdbInstance#disable_backup}
        /// </remarks>
        [JsiiProperty(name: "disableBackup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableBackup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enable or disable encryption at rest for the database instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#encryption_at_rest RdbInstance#encryption_at_rest}
        /// </remarks>
        [JsiiProperty(name: "encryptionAtRest", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EncryptionAtRest
        {
            get
            {
                return null;
            }
        }

        /// <summary>Database's engine version name (e.g., 'PostgreSQL-16', 'MySQL-8'). Changing this value triggers a blue/green upgrade using MajorUpgradeWorkflow with automatic endpoint migration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#engine RdbInstance#engine}
        /// </remarks>
        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Engine
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#id RdbInstance#id}.</summary>
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

        /// <summary>Map of engine settings to be set at database initialisation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#init_settings RdbInstance#init_settings}
        /// </remarks>
        [JsiiProperty(name: "initSettings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? InitSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enable or disable high availability for the database instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#is_ha_cluster RdbInstance#is_ha_cluster}
        /// </remarks>
        [JsiiProperty(name: "isHaCluster", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsHaCluster
        {
            get
            {
                return null;
            }
        }

        /// <summary>load_balancer block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#load_balancer RdbInstance#load_balancer}
        /// </remarks>
        [JsiiProperty(name: "loadBalancer", typeJson: "{\"fqn\":\"scaleway.rdbInstance.RdbInstanceLoadBalancer\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.RdbInstance.IRdbInstanceLoadBalancer? LoadBalancer
        {
            get
            {
                return null;
            }
        }

        /// <summary>logs_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#logs_policy RdbInstance#logs_policy}
        /// </remarks>
        [JsiiProperty(name: "logsPolicy", typeJson: "{\"fqn\":\"scaleway.rdbInstance.RdbInstanceLogsPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.RdbInstance.IRdbInstanceLogsPolicy? LogsPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the database instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#name RdbInstance#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Password for the first user of the database instance. Only one of `password` or `password_wo` should be specified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#password RdbInstance#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Password
        {
            get
            {
                return null;
            }
        }

        /// <summary>Password for the first user of the database instance in [write-only](https://registry.terraform.io/providers/scaleway/scaleway/latest/docs/guides/using-write-only-arguments) mode. Only one of `password` or `password_wo` should be specified. `password_wo` will not be set in the Terraform state. To update the `password_wo`, you must also update the `password_wo_version`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#password_wo RdbInstance#password_wo}
        /// </remarks>
        [JsiiProperty(name: "passwordWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PasswordWo
        {
            get
            {
                return null;
            }
        }

        /// <summary>The version of the [write-only](https://registry.terraform.io/providers/scaleway/scaleway/latest/docs/guides/using-write-only-arguments) password. To update the `password_wo`, you must also update the `password_wo_version`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#password_wo_version RdbInstance#password_wo_version}
        /// </remarks>
        [JsiiProperty(name: "passwordWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PasswordWoVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>private_ip block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#private_ip RdbInstance#private_ip}
        /// </remarks>
        [JsiiProperty(name: "privateIp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.rdbInstance.RdbInstancePrivateIp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrivateIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>private_network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#private_network RdbInstance#private_network}
        /// </remarks>
        [JsiiProperty(name: "privateNetwork", typeJson: "{\"fqn\":\"scaleway.rdbInstance.RdbInstancePrivateNetwork\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.RdbInstance.IRdbInstancePrivateNetwork? PrivateNetwork
        {
            get
            {
                return null;
            }
        }

        /// <summary>The project_id you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#project_id RdbInstance#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The region you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#region RdbInstance#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>Map of engine settings to be set on a running instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#settings RdbInstance#settings}
        /// </remarks>
        [JsiiProperty(name: "settings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Settings
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of an existing snapshot to create a new instance from.</summary>
        /// <remarks>
        /// This allows restoring a database instance to the state captured in the specified snapshot. Conflicts with the <c>engine</c> attribute.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#snapshot_id RdbInstance#snapshot_id}
        /// </remarks>
        [JsiiProperty(name: "snapshotId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SnapshotId
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of tags ["tag1", "tag2", ...] attached to a database instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#tags RdbInstance#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#timeouts RdbInstance#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.rdbInstance.RdbInstanceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.RdbInstance.IRdbInstanceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Identifier for the first user of the database instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#user_name RdbInstance#user_name}
        /// </remarks>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Volume size (in GB) when volume_type is not lssd.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#volume_size_in_gb RdbInstance#volume_size_in_gb}
        /// </remarks>
        [JsiiProperty(name: "volumeSizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VolumeSizeInGb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Type of volume where data are stored.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#volume_type RdbInstance#volume_type}
        /// </remarks>
        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRdbInstanceConfig), fullyQualifiedName: "scaleway.rdbInstance.RdbInstanceConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.RdbInstance.IRdbInstanceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The type of database instance you want to create.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#node_type RdbInstance#node_type}
            /// </remarks>
            [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Boolean to store logical backups in the same region as the database instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#backup_same_region RdbInstance#backup_same_region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backupSameRegion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? BackupSameRegion
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Backup schedule frequency in hours.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#backup_schedule_frequency RdbInstance#backup_schedule_frequency}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backupScheduleFrequency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackupScheduleFrequency
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Backup schedule retention in days.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#backup_schedule_retention RdbInstance#backup_schedule_retention}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backupScheduleRetention", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackupScheduleRetention
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Disable automated backup for the database instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#disable_backup RdbInstance#disable_backup}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableBackup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableBackup
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Enable or disable encryption at rest for the database instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#encryption_at_rest RdbInstance#encryption_at_rest}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionAtRest", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EncryptionAtRest
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Database's engine version name (e.g., 'PostgreSQL-16', 'MySQL-8'). Changing this value triggers a blue/green upgrade using MajorUpgradeWorkflow with automatic endpoint migration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#engine RdbInstance#engine}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Engine
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#id RdbInstance#id}.</summary>
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

            /// <summary>Map of engine settings to be set at database initialisation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#init_settings RdbInstance#init_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "initSettings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? InitSettings
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Enable or disable high availability for the database instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#is_ha_cluster RdbInstance#is_ha_cluster}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isHaCluster", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsHaCluster
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>load_balancer block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#load_balancer RdbInstance#load_balancer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancer", typeJson: "{\"fqn\":\"scaleway.rdbInstance.RdbInstanceLoadBalancer\"}", isOptional: true)]
            public scaleway.RdbInstance.IRdbInstanceLoadBalancer? LoadBalancer
            {
                get => GetInstanceProperty<scaleway.RdbInstance.IRdbInstanceLoadBalancer?>();
            }

            /// <summary>logs_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#logs_policy RdbInstance#logs_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logsPolicy", typeJson: "{\"fqn\":\"scaleway.rdbInstance.RdbInstanceLogsPolicy\"}", isOptional: true)]
            public scaleway.RdbInstance.IRdbInstanceLogsPolicy? LogsPolicy
            {
                get => GetInstanceProperty<scaleway.RdbInstance.IRdbInstanceLogsPolicy?>();
            }

            /// <summary>Name of the database instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#name RdbInstance#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Password for the first user of the database instance. Only one of `password` or `password_wo` should be specified.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#password RdbInstance#password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Password
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Password for the first user of the database instance in [write-only](https://registry.terraform.io/providers/scaleway/scaleway/latest/docs/guides/using-write-only-arguments) mode. Only one of `password` or `password_wo` should be specified. `password_wo` will not be set in the Terraform state. To update the `password_wo`, you must also update the `password_wo_version`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#password_wo RdbInstance#password_wo}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passwordWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PasswordWo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The version of the [write-only](https://registry.terraform.io/providers/scaleway/scaleway/latest/docs/guides/using-write-only-arguments) password. To update the `password_wo`, you must also update the `password_wo_version`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#password_wo_version RdbInstance#password_wo_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passwordWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PasswordWoVersion
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>private_ip block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#private_ip RdbInstance#private_ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateIp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.rdbInstance.RdbInstancePrivateIp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PrivateIp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>private_network block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#private_network RdbInstance#private_network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateNetwork", typeJson: "{\"fqn\":\"scaleway.rdbInstance.RdbInstancePrivateNetwork\"}", isOptional: true)]
            public scaleway.RdbInstance.IRdbInstancePrivateNetwork? PrivateNetwork
            {
                get => GetInstanceProperty<scaleway.RdbInstance.IRdbInstancePrivateNetwork?>();
            }

            /// <summary>The project_id you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#project_id RdbInstance#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The region you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#region RdbInstance#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Map of engine settings to be set on a running instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#settings RdbInstance#settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "settings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Settings
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>ID of an existing snapshot to create a new instance from.</summary>
            /// <remarks>
            /// This allows restoring a database instance to the state captured in the specified snapshot. Conflicts with the <c>engine</c> attribute.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#snapshot_id RdbInstance#snapshot_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "snapshotId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SnapshotId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>List of tags ["tag1", "tag2", ...] attached to a database instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#tags RdbInstance#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#timeouts RdbInstance#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.rdbInstance.RdbInstanceTimeouts\"}", isOptional: true)]
            public scaleway.RdbInstance.IRdbInstanceTimeouts? Timeouts
            {
                get => GetInstanceProperty<scaleway.RdbInstance.IRdbInstanceTimeouts?>();
            }

            /// <summary>Identifier for the first user of the database instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#user_name RdbInstance#user_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Volume size (in GB) when volume_type is not lssd.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#volume_size_in_gb RdbInstance#volume_size_in_gb}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumeSizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VolumeSizeInGb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Type of volume where data are stored.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#volume_type RdbInstance#volume_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeType
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
