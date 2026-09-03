using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OracleAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IOracleAutonomousDatabaseConfig), fullyQualifiedName: "azurerm.oracleAutonomousDatabase.OracleAutonomousDatabaseConfig")]
    public interface IOracleAutonomousDatabaseConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#admin_password OracleAutonomousDatabase#admin_password}.</summary>
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        string AdminPassword
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#auto_scaling_enabled OracleAutonomousDatabase#auto_scaling_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "autoScalingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object AutoScalingEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#auto_scaling_for_storage_enabled OracleAutonomousDatabase#auto_scaling_for_storage_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "autoScalingForStorageEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object AutoScalingForStorageEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#backup_retention_period_in_days OracleAutonomousDatabase#backup_retention_period_in_days}.</summary>
        [JsiiProperty(name: "backupRetentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
        double BackupRetentionPeriodInDays
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#character_set OracleAutonomousDatabase#character_set}.</summary>
        [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}")]
        string CharacterSet
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#compute_count OracleAutonomousDatabase#compute_count}.</summary>
        [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}")]
        double ComputeCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#compute_model OracleAutonomousDatabase#compute_model}.</summary>
        [JsiiProperty(name: "computeModel", typeJson: "{\"primitive\":\"string\"}")]
        string ComputeModel
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#data_storage_size_in_tbs OracleAutonomousDatabase#data_storage_size_in_tbs}.</summary>
        [JsiiProperty(name: "dataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        double DataStorageSizeInTbs
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#db_version OracleAutonomousDatabase#db_version}.</summary>
        [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}")]
        string DbVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#db_workload OracleAutonomousDatabase#db_workload}.</summary>
        [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}")]
        string DbWorkload
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#display_name OracleAutonomousDatabase#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#license_model OracleAutonomousDatabase#license_model}.</summary>
        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}")]
        string LicenseModel
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#location OracleAutonomousDatabase#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#mtls_connection_required OracleAutonomousDatabase#mtls_connection_required}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "mtlsConnectionRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object MtlsConnectionRequired
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#name OracleAutonomousDatabase#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#national_character_set OracleAutonomousDatabase#national_character_set}.</summary>
        [JsiiProperty(name: "nationalCharacterSet", typeJson: "{\"primitive\":\"string\"}")]
        string NationalCharacterSet
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#resource_group_name OracleAutonomousDatabase#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#allowed_ips OracleAutonomousDatabase#allowed_ips}.</summary>
        [JsiiProperty(name: "allowedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedIps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#customer_contacts OracleAutonomousDatabase#customer_contacts}.</summary>
        [JsiiProperty(name: "customerContacts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CustomerContacts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#id OracleAutonomousDatabase#id}.</summary>
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

        /// <summary>long_term_backup_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#long_term_backup_schedule OracleAutonomousDatabase#long_term_backup_schedule}
        /// </remarks>
        [JsiiProperty(name: "longTermBackupSchedule", typeJson: "{\"fqn\":\"azurerm.oracleAutonomousDatabase.OracleAutonomousDatabaseLongTermBackupSchedule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.OracleAutonomousDatabase.IOracleAutonomousDatabaseLongTermBackupSchedule? LongTermBackupSchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#subnet_id OracleAutonomousDatabase#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#tags OracleAutonomousDatabase#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#timeouts OracleAutonomousDatabase#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.oracleAutonomousDatabase.OracleAutonomousDatabaseTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.OracleAutonomousDatabase.IOracleAutonomousDatabaseTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#virtual_network_id OracleAutonomousDatabase#virtual_network_id}.</summary>
        [JsiiProperty(name: "virtualNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VirtualNetworkId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOracleAutonomousDatabaseConfig), fullyQualifiedName: "azurerm.oracleAutonomousDatabase.OracleAutonomousDatabaseConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.OracleAutonomousDatabase.IOracleAutonomousDatabaseConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#admin_password OracleAutonomousDatabase#admin_password}.</summary>
            [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
            public string AdminPassword
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#auto_scaling_enabled OracleAutonomousDatabase#auto_scaling_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "autoScalingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object AutoScalingEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#auto_scaling_for_storage_enabled OracleAutonomousDatabase#auto_scaling_for_storage_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "autoScalingForStorageEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object AutoScalingForStorageEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#backup_retention_period_in_days OracleAutonomousDatabase#backup_retention_period_in_days}.</summary>
            [JsiiProperty(name: "backupRetentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
            public double BackupRetentionPeriodInDays
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#character_set OracleAutonomousDatabase#character_set}.</summary>
            [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}")]
            public string CharacterSet
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#compute_count OracleAutonomousDatabase#compute_count}.</summary>
            [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}")]
            public double ComputeCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#compute_model OracleAutonomousDatabase#compute_model}.</summary>
            [JsiiProperty(name: "computeModel", typeJson: "{\"primitive\":\"string\"}")]
            public string ComputeModel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#data_storage_size_in_tbs OracleAutonomousDatabase#data_storage_size_in_tbs}.</summary>
            [JsiiProperty(name: "dataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
            public double DataStorageSizeInTbs
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#db_version OracleAutonomousDatabase#db_version}.</summary>
            [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string DbVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#db_workload OracleAutonomousDatabase#db_workload}.</summary>
            [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}")]
            public string DbWorkload
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#display_name OracleAutonomousDatabase#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#license_model OracleAutonomousDatabase#license_model}.</summary>
            [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}")]
            public string LicenseModel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#location OracleAutonomousDatabase#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#mtls_connection_required OracleAutonomousDatabase#mtls_connection_required}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "mtlsConnectionRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object MtlsConnectionRequired
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#name OracleAutonomousDatabase#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#national_character_set OracleAutonomousDatabase#national_character_set}.</summary>
            [JsiiProperty(name: "nationalCharacterSet", typeJson: "{\"primitive\":\"string\"}")]
            public string NationalCharacterSet
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#resource_group_name OracleAutonomousDatabase#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#allowed_ips OracleAutonomousDatabase#allowed_ips}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedIps
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#customer_contacts OracleAutonomousDatabase#customer_contacts}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customerContacts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CustomerContacts
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#id OracleAutonomousDatabase#id}.</summary>
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

            /// <summary>long_term_backup_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#long_term_backup_schedule OracleAutonomousDatabase#long_term_backup_schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "longTermBackupSchedule", typeJson: "{\"fqn\":\"azurerm.oracleAutonomousDatabase.OracleAutonomousDatabaseLongTermBackupSchedule\"}", isOptional: true)]
            public azurerm.OracleAutonomousDatabase.IOracleAutonomousDatabaseLongTermBackupSchedule? LongTermBackupSchedule
            {
                get => GetInstanceProperty<azurerm.OracleAutonomousDatabase.IOracleAutonomousDatabaseLongTermBackupSchedule?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#subnet_id OracleAutonomousDatabase#subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#tags OracleAutonomousDatabase#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#timeouts OracleAutonomousDatabase#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.oracleAutonomousDatabase.OracleAutonomousDatabaseTimeouts\"}", isOptional: true)]
            public azurerm.OracleAutonomousDatabase.IOracleAutonomousDatabaseTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.OracleAutonomousDatabase.IOracleAutonomousDatabaseTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/oracle_autonomous_database#virtual_network_id OracleAutonomousDatabase#virtual_network_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "virtualNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VirtualNetworkId
            {
                get => GetInstanceProperty<string?>();
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
