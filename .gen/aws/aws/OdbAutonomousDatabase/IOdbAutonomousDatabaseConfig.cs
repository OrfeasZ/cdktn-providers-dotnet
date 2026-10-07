using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IOdbAutonomousDatabaseConfig), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseConfig")]
    public interface IOdbAutonomousDatabaseConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Password for the ADMIN user.</summary>
        /// <remarks>
        /// This value is stored in Terraform state. Use admin_password_wo with Terraform 1.11 or later to avoid storing the password in state.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#admin_password OdbAutonomousDatabase#admin_password}
        /// </remarks>
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdminPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>admin_password_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#admin_password_source OdbAutonomousDatabase#admin_password_source}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseAdminPasswordSource" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "adminPasswordSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseAdminPasswordSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AdminPasswordSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Password for the ADMIN user. This write-only value is never stored in Terraform state.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#admin_password_wo OdbAutonomousDatabase#admin_password_wo}
        /// </remarks>
        [JsiiProperty(name: "adminPasswordWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdminPasswordWo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Arbitrary version used to trigger an ADMIN password update.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#admin_password_wo_version OdbAutonomousDatabase#admin_password_wo_version}
        /// </remarks>
        [JsiiProperty(name: "adminPasswordWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AdminPasswordWoVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>IP addresses allowed to access the Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#allowlisted_ips OdbAutonomousDatabase#allowlisted_ips}
        /// </remarks>
        [JsiiProperty(name: "allowlistedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowlistedIps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maintenance schedule type for the Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#autonomous_maintenance_schedule_type OdbAutonomousDatabase#autonomous_maintenance_schedule_type}
        /// </remarks>
        [JsiiProperty(name: "autonomousMaintenanceScheduleType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutonomousMaintenanceScheduleType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Frequency at which a refreshable clone is automatically refreshed, in seconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#auto_refresh_frequency_in_seconds OdbAutonomousDatabase#auto_refresh_frequency_in_seconds}
        /// </remarks>
        [JsiiProperty(name: "autoRefreshFrequencyInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AutoRefreshFrequencyInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Time lag between a refreshable clone and its source, in seconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#auto_refresh_point_lag_in_seconds OdbAutonomousDatabase#auto_refresh_point_lag_in_seconds}
        /// </remarks>
        [JsiiProperty(name: "autoRefreshPointLagInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AutoRefreshPointLagInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Retention period for automatic backups, in days.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#backup_retention_period_in_days OdbAutonomousDatabase#backup_retention_period_in_days}
        /// </remarks>
        [JsiiProperty(name: "backupRetentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackupRetentionPeriodInDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum compute capacity under the bring-your-own-license model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#byol_compute_count_limit OdbAutonomousDatabase#byol_compute_count_limit}
        /// </remarks>
        [JsiiProperty(name: "byolComputeCountLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ByolComputeCountLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Character set of the Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#character_set OdbAutonomousDatabase#character_set}
        /// </remarks>
        [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CharacterSet
        {
            get
            {
                return null;
            }
        }

        /// <summary>Compute capacity in ECPUs or OCPUs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#compute_count OdbAutonomousDatabase#compute_count}
        /// </remarks>
        [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ComputeCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Number of CPU cores allocated to the Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#cpu_core_count OdbAutonomousDatabase#cpu_core_count}
        /// </remarks>
        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CpuCoreCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>customer_contacts_to_send_to_oci block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#customer_contacts_to_send_to_oci OdbAutonomousDatabase#customer_contacts_to_send_to_oci}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseCustomerContactsToSendToOci" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "customerContactsToSendToOci", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseCustomerContactsToSendToOci\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomerContactsToSendToOci
        {
            get
            {
                return null;
            }
        }

        /// <summary>Oracle Database edition.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#database_edition OdbAutonomousDatabase#database_edition}
        /// </remarks>
        [JsiiProperty(name: "databaseEdition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseEdition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Data volume size in GB.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#data_storage_size_in_gbs OdbAutonomousDatabase#data_storage_size_in_gbs}
        /// </remarks>
        [JsiiProperty(name: "dataStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DataStorageSizeInGbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Data volume size in TB.</summary>
        /// <remarks>
        /// Configured values must be whole numbers; computed values may be fractional when storage is configured in GB.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#data_storage_size_in_tbs OdbAutonomousDatabase#data_storage_size_in_tbs}
        /// </remarks>
        [JsiiProperty(name: "dataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DataStorageSizeInTbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#db_name OdbAutonomousDatabase#db_name}
        /// </remarks>
        [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbName
        {
            get
            {
                return null;
            }
        }

        /// <summary>db_tools_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#db_tools_details OdbAutonomousDatabase#db_tools_details}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseDbToolsDetails" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "dbToolsDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseDbToolsDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DbToolsDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Oracle Database software version.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#db_version OdbAutonomousDatabase#db_version}
        /// </remarks>
        [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Intended database workload.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#db_workload OdbAutonomousDatabase#db_workload}
        /// </remarks>
        [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbWorkload
        {
            get
            {
                return null;
            }
        }

        /// <summary>User-friendly name for the Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#display_name OdbAutonomousDatabase#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Encryption key provider. Configurable values are ORACLE_MANAGED and AWS_KMS.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#encryption_key_provider OdbAutonomousDatabase#encryption_key_provider}
        /// </remarks>
        [JsiiProperty(name: "encryptionKeyProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionKeyProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether automatic compute scaling is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_auto_scaling_enabled OdbAutonomousDatabase#is_auto_scaling_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isAutoScalingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAutoScalingEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether automatic storage scaling is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_auto_scaling_for_storage_enabled OdbAutonomousDatabase#is_auto_scaling_for_storage_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isAutoScalingForStorageEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAutoScalingForStorageEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the backup retention period is locked.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_backup_retention_locked OdbAutonomousDatabase#is_backup_retention_locked}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isBackupRetentionLocked", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsBackupRetentionLocked
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether local Oracle Data Guard is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_local_data_guard_enabled OdbAutonomousDatabase#is_local_data_guard_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isLocalDataGuardEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsLocalDataGuardEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether mutual TLS authentication is required.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_mtls_connection_required OdbAutonomousDatabase#is_mtls_connection_required}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isMtlsConnectionRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsMtlsConnectionRequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the Autonomous Database is a refreshable clone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_refreshable_clone OdbAutonomousDatabase#is_refreshable_clone}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isRefreshableClone", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsRefreshableClone
        {
            get
            {
                return null;
            }
        }

        /// <summary>ARN of the AWS KMS key used to encrypt the Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#kms_key_id OdbAutonomousDatabase#kms_key_id}
        /// </remarks>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Oracle license model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#license_model OdbAutonomousDatabase#license_model}
        /// </remarks>
        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LicenseModel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum data-loss limit for automatic local Data Guard failover, in seconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#local_adg_auto_failover_max_data_loss_limit OdbAutonomousDatabase#local_adg_auto_failover_max_data_loss_limit}
        /// </remarks>
        [JsiiProperty(name: "localAdgAutoFailoverMaxDataLossLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LocalAdgAutoFailoverMaxDataLossLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>long_term_backup_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#long_term_backup_schedule OdbAutonomousDatabase#long_term_backup_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseLongTermBackupSchedule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "longTermBackupSchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseLongTermBackupSchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LongTermBackupSchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>National character set of the Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#ncharacter_set OdbAutonomousDatabase#ncharacter_set}
        /// </remarks>
        [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NcharacterSet
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the associated ODB network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#odb_network_id OdbAutonomousDatabase#odb_network_id}
        /// </remarks>
        [JsiiProperty(name: "odbNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OdbNetworkId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Open mode of the Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#open_mode OdbAutonomousDatabase#open_mode}
        /// </remarks>
        [JsiiProperty(name: "openMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OpenMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Permission level of the Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#permission_level OdbAutonomousDatabase#permission_level}
        /// </remarks>
        [JsiiProperty(name: "permissionLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PermissionLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Private endpoint IP address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#private_endpoint_ip OdbAutonomousDatabase#private_endpoint_ip}
        /// </remarks>
        [JsiiProperty(name: "privateEndpointIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateEndpointIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Private endpoint label.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#private_endpoint_label OdbAutonomousDatabase#private_endpoint_label}
        /// </remarks>
        [JsiiProperty(name: "privateEndpointLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateEndpointLabel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Refresh mode of a refreshable clone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#refreshable_mode OdbAutonomousDatabase#refreshable_mode}
        /// </remarks>
        [JsiiProperty(name: "refreshableMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RefreshableMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#region OdbAutonomousDatabase#region}
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

        /// <summary>ID of the resource-pool leader Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#resource_pool_leader_id OdbAutonomousDatabase#resource_pool_leader_id}
        /// </remarks>
        [JsiiProperty(name: "resourcePoolLeaderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourcePoolLeaderId
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_pool_summary block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#resource_pool_summary OdbAutonomousDatabase#resource_pool_summary}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseResourcePoolSummary" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "resourcePoolSummary", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseResourcePoolSummary\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourcePoolSummary
        {
            get
            {
                return null;
            }
        }

        /// <summary>scheduled_operations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#scheduled_operations OdbAutonomousDatabase#scheduled_operations}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseScheduledOperations" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "scheduledOperations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseScheduledOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ScheduledOperations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Source from which to create the Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#source OdbAutonomousDatabase#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Source
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#source_configuration OdbAutonomousDatabase#source_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "sourceConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SourceConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>IP addresses allowed to access the standby Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#standby_allowlisted_ips OdbAutonomousDatabase#standby_allowlisted_ips}
        /// </remarks>
        [JsiiProperty(name: "standbyAllowlistedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? StandbyAllowlistedIps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Source of the standby allowlisted IP addresses.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#standby_allowlisted_ips_source OdbAutonomousDatabase#standby_allowlisted_ips_source}
        /// </remarks>
        [JsiiProperty(name: "standbyAllowlistedIpsSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StandbyAllowlistedIpsSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#tags OdbAutonomousDatabase#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Date and time when automatic refresh begins.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#time_of_auto_refresh_start OdbAutonomousDatabase#time_of_auto_refresh_start}
        /// </remarks>
        [JsiiProperty(name: "timeOfAutoRefreshStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeOfAutoRefreshStart
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#timeouts OdbAutonomousDatabase#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>transportable_tablespace block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#transportable_tablespace OdbAutonomousDatabase#transportable_tablespace}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseTransportableTablespace" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "transportableTablespace", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseTransportableTablespace\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TransportableTablespace
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOdbAutonomousDatabaseConfig), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseConfig")]
        internal sealed class _Proxy : DeputyBase, aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Password for the ADMIN user.</summary>
            /// <remarks>
            /// This value is stored in Terraform state. Use admin_password_wo with Terraform 1.11 or later to avoid storing the password in state.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#admin_password OdbAutonomousDatabase#admin_password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdminPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>admin_password_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#admin_password_source OdbAutonomousDatabase#admin_password_source}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseAdminPasswordSource" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "adminPasswordSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseAdminPasswordSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AdminPasswordSource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Password for the ADMIN user. This write-only value is never stored in Terraform state.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#admin_password_wo OdbAutonomousDatabase#admin_password_wo}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "adminPasswordWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdminPasswordWo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Arbitrary version used to trigger an ADMIN password update.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#admin_password_wo_version OdbAutonomousDatabase#admin_password_wo_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "adminPasswordWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AdminPasswordWoVersion
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>IP addresses allowed to access the Autonomous Database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#allowlisted_ips OdbAutonomousDatabase#allowlisted_ips}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowlistedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowlistedIps
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Maintenance schedule type for the Autonomous Database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#autonomous_maintenance_schedule_type OdbAutonomousDatabase#autonomous_maintenance_schedule_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autonomousMaintenanceScheduleType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutonomousMaintenanceScheduleType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Frequency at which a refreshable clone is automatically refreshed, in seconds.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#auto_refresh_frequency_in_seconds OdbAutonomousDatabase#auto_refresh_frequency_in_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoRefreshFrequencyInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AutoRefreshFrequencyInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Time lag between a refreshable clone and its source, in seconds.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#auto_refresh_point_lag_in_seconds OdbAutonomousDatabase#auto_refresh_point_lag_in_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoRefreshPointLagInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AutoRefreshPointLagInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Retention period for automatic backups, in days.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#backup_retention_period_in_days OdbAutonomousDatabase#backup_retention_period_in_days}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backupRetentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackupRetentionPeriodInDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Maximum compute capacity under the bring-your-own-license model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#byol_compute_count_limit OdbAutonomousDatabase#byol_compute_count_limit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "byolComputeCountLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ByolComputeCountLimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Character set of the Autonomous Database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#character_set OdbAutonomousDatabase#character_set}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CharacterSet
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Compute capacity in ECPUs or OCPUs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#compute_count OdbAutonomousDatabase#compute_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ComputeCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Number of CPU cores allocated to the Autonomous Database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#cpu_core_count OdbAutonomousDatabase#cpu_core_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CpuCoreCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>customer_contacts_to_send_to_oci block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#customer_contacts_to_send_to_oci OdbAutonomousDatabase#customer_contacts_to_send_to_oci}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseCustomerContactsToSendToOci" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customerContactsToSendToOci", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseCustomerContactsToSendToOci\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomerContactsToSendToOci
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Oracle Database edition.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#database_edition OdbAutonomousDatabase#database_edition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "databaseEdition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseEdition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Data volume size in GB.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#data_storage_size_in_gbs OdbAutonomousDatabase#data_storage_size_in_gbs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DataStorageSizeInGbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Data volume size in TB.</summary>
            /// <remarks>
            /// Configured values must be whole numbers; computed values may be fractional when storage is configured in GB.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#data_storage_size_in_tbs OdbAutonomousDatabase#data_storage_size_in_tbs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DataStorageSizeInTbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Name of the Autonomous Database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#db_name OdbAutonomousDatabase#db_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>db_tools_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#db_tools_details OdbAutonomousDatabase#db_tools_details}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseDbToolsDetails" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dbToolsDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseDbToolsDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DbToolsDetails
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Oracle Database software version.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#db_version OdbAutonomousDatabase#db_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Intended database workload.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#db_workload OdbAutonomousDatabase#db_workload}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbWorkload
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>User-friendly name for the Autonomous Database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#display_name OdbAutonomousDatabase#display_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Encryption key provider. Configurable values are ORACLE_MANAGED and AWS_KMS.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#encryption_key_provider OdbAutonomousDatabase#encryption_key_provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionKeyProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionKeyProvider
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether automatic compute scaling is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_auto_scaling_enabled OdbAutonomousDatabase#is_auto_scaling_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isAutoScalingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAutoScalingEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether automatic storage scaling is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_auto_scaling_for_storage_enabled OdbAutonomousDatabase#is_auto_scaling_for_storage_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isAutoScalingForStorageEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAutoScalingForStorageEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether the backup retention period is locked.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_backup_retention_locked OdbAutonomousDatabase#is_backup_retention_locked}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isBackupRetentionLocked", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsBackupRetentionLocked
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether local Oracle Data Guard is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_local_data_guard_enabled OdbAutonomousDatabase#is_local_data_guard_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isLocalDataGuardEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsLocalDataGuardEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether mutual TLS authentication is required.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_mtls_connection_required OdbAutonomousDatabase#is_mtls_connection_required}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isMtlsConnectionRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsMtlsConnectionRequired
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether the Autonomous Database is a refreshable clone.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_refreshable_clone OdbAutonomousDatabase#is_refreshable_clone}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isRefreshableClone", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsRefreshableClone
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ARN of the AWS KMS key used to encrypt the Autonomous Database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#kms_key_id OdbAutonomousDatabase#kms_key_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Oracle license model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#license_model OdbAutonomousDatabase#license_model}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LicenseModel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Maximum data-loss limit for automatic local Data Guard failover, in seconds.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#local_adg_auto_failover_max_data_loss_limit OdbAutonomousDatabase#local_adg_auto_failover_max_data_loss_limit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "localAdgAutoFailoverMaxDataLossLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LocalAdgAutoFailoverMaxDataLossLimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>long_term_backup_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#long_term_backup_schedule OdbAutonomousDatabase#long_term_backup_schedule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseLongTermBackupSchedule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "longTermBackupSchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseLongTermBackupSchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LongTermBackupSchedule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>National character set of the Autonomous Database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#ncharacter_set OdbAutonomousDatabase#ncharacter_set}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NcharacterSet
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of the associated ODB network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#odb_network_id OdbAutonomousDatabase#odb_network_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "odbNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OdbNetworkId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Open mode of the Autonomous Database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#open_mode OdbAutonomousDatabase#open_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OpenMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Permission level of the Autonomous Database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#permission_level OdbAutonomousDatabase#permission_level}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "permissionLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PermissionLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Private endpoint IP address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#private_endpoint_ip OdbAutonomousDatabase#private_endpoint_ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateEndpointIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateEndpointIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Private endpoint label.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#private_endpoint_label OdbAutonomousDatabase#private_endpoint_label}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateEndpointLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateEndpointLabel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Refresh mode of a refreshable clone.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#refreshable_mode OdbAutonomousDatabase#refreshable_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "refreshableMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RefreshableMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#region OdbAutonomousDatabase#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of the resource-pool leader Autonomous Database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#resource_pool_leader_id OdbAutonomousDatabase#resource_pool_leader_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourcePoolLeaderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourcePoolLeaderId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>resource_pool_summary block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#resource_pool_summary OdbAutonomousDatabase#resource_pool_summary}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseResourcePoolSummary" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourcePoolSummary", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseResourcePoolSummary\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourcePoolSummary
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>scheduled_operations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#scheduled_operations OdbAutonomousDatabase#scheduled_operations}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseScheduledOperations" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scheduledOperations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseScheduledOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ScheduledOperations
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Source from which to create the Autonomous Database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#source OdbAutonomousDatabase#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Source
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>source_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#source_configuration OdbAutonomousDatabase#source_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SourceConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>IP addresses allowed to access the standby Autonomous Database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#standby_allowlisted_ips OdbAutonomousDatabase#standby_allowlisted_ips}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "standbyAllowlistedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? StandbyAllowlistedIps
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Source of the standby allowlisted IP addresses.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#standby_allowlisted_ips_source OdbAutonomousDatabase#standby_allowlisted_ips_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "standbyAllowlistedIpsSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StandbyAllowlistedIpsSource
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#tags OdbAutonomousDatabase#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Date and time when automatic refresh begins.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#time_of_auto_refresh_start OdbAutonomousDatabase#time_of_auto_refresh_start}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeOfAutoRefreshStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeOfAutoRefreshStart
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#timeouts OdbAutonomousDatabase#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseTimeouts\"}", isOptional: true)]
            public aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseTimeouts?>();
            }

            /// <summary>transportable_tablespace block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#transportable_tablespace OdbAutonomousDatabase#transportable_tablespace}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseTransportableTablespace" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transportableTablespace", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseTransportableTablespace\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TransportableTablespace
            {
                get => GetInstanceProperty<object?>();
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
