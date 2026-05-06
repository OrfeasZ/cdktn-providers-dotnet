using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousContainerDatabaseDataguardAssociation
{
    [JsiiInterface(nativeType: typeof(IDatabaseAutonomousContainerDatabaseDataguardAssociationPeerAutonomousContainerDatabaseBackupConfigBackupDestinationDetails), fullyQualifiedName: "oci.databaseAutonomousContainerDatabaseDataguardAssociation.DatabaseAutonomousContainerDatabaseDataguardAssociationPeerAutonomousContainerDatabaseBackupConfigBackupDestinationDetails")]
    public interface IDatabaseAutonomousContainerDatabaseDataguardAssociationPeerAutonomousContainerDatabaseBackupConfigBackupDestinationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#type DatabaseAutonomousContainerDatabaseDataguardAssociation#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#backup_retention_policy_on_terminate DatabaseAutonomousContainerDatabaseDataguardAssociation#backup_retention_policy_on_terminate}.</summary>
        [JsiiProperty(name: "backupRetentionPolicyOnTerminate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackupRetentionPolicyOnTerminate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#dbrs_policy_id DatabaseAutonomousContainerDatabaseDataguardAssociation#dbrs_policy_id}.</summary>
        [JsiiProperty(name: "dbrsPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbrsPolicyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#id DatabaseAutonomousContainerDatabaseDataguardAssociation#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#internet_proxy DatabaseAutonomousContainerDatabaseDataguardAssociation#internet_proxy}.</summary>
        [JsiiProperty(name: "internetProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InternetProxy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#is_remote DatabaseAutonomousContainerDatabaseDataguardAssociation#is_remote}.</summary>
        [JsiiProperty(name: "isRemote", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsRemote
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#is_retention_lock_enabled DatabaseAutonomousContainerDatabaseDataguardAssociation#is_retention_lock_enabled}.</summary>
        [JsiiProperty(name: "isRetentionLockEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsRetentionLockEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#remote_region DatabaseAutonomousContainerDatabaseDataguardAssociation#remote_region}.</summary>
        [JsiiProperty(name: "remoteRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RemoteRegion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#vpc_password DatabaseAutonomousContainerDatabaseDataguardAssociation#vpc_password}.</summary>
        [JsiiProperty(name: "vpcPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpcPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#vpc_user DatabaseAutonomousContainerDatabaseDataguardAssociation#vpc_user}.</summary>
        [JsiiProperty(name: "vpcUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpcUser
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseAutonomousContainerDatabaseDataguardAssociationPeerAutonomousContainerDatabaseBackupConfigBackupDestinationDetails), fullyQualifiedName: "oci.databaseAutonomousContainerDatabaseDataguardAssociation.DatabaseAutonomousContainerDatabaseDataguardAssociationPeerAutonomousContainerDatabaseBackupConfigBackupDestinationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseAutonomousContainerDatabaseDataguardAssociation.IDatabaseAutonomousContainerDatabaseDataguardAssociationPeerAutonomousContainerDatabaseBackupConfigBackupDestinationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#type DatabaseAutonomousContainerDatabaseDataguardAssociation#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#backup_retention_policy_on_terminate DatabaseAutonomousContainerDatabaseDataguardAssociation#backup_retention_policy_on_terminate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupRetentionPolicyOnTerminate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackupRetentionPolicyOnTerminate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#dbrs_policy_id DatabaseAutonomousContainerDatabaseDataguardAssociation#dbrs_policy_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dbrsPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbrsPolicyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#id DatabaseAutonomousContainerDatabaseDataguardAssociation#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#internet_proxy DatabaseAutonomousContainerDatabaseDataguardAssociation#internet_proxy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "internetProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InternetProxy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#is_remote DatabaseAutonomousContainerDatabaseDataguardAssociation#is_remote}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isRemote", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsRemote
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#is_retention_lock_enabled DatabaseAutonomousContainerDatabaseDataguardAssociation#is_retention_lock_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isRetentionLockEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsRetentionLockEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#remote_region DatabaseAutonomousContainerDatabaseDataguardAssociation#remote_region}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "remoteRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RemoteRegion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#vpc_password DatabaseAutonomousContainerDatabaseDataguardAssociation#vpc_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpcPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#vpc_user DatabaseAutonomousContainerDatabaseDataguardAssociation#vpc_user}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpcUser
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
