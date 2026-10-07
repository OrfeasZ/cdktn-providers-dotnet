using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IOdbAutonomousDatabaseSourceConfigurationRestoreFromBackup), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationRestoreFromBackup")]
    public interface IOdbAutonomousDatabaseSourceConfigurationRestoreFromBackup
    {
        /// <summary>ID of the Autonomous Database backup.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#autonomous_database_backup_id OdbAutonomousDatabase#autonomous_database_backup_id}
        /// </remarks>
        [JsiiProperty(name: "autonomousDatabaseBackupId", typeJson: "{\"primitive\":\"string\"}")]
        string AutonomousDatabaseBackupId
        {
            get;
        }

        /// <summary>Type of clone to create from the backup.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#clone_type OdbAutonomousDatabase#clone_type}
        /// </remarks>
        [JsiiProperty(name: "cloneType", typeJson: "{\"primitive\":\"string\"}")]
        string CloneType
        {
            get;
        }

        /// <summary>Tablespace IDs to clone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#clone_table_space_list OdbAutonomousDatabase#clone_table_space_list}
        /// </remarks>
        [JsiiProperty(name: "cloneTableSpaceList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? CloneTableSpaceList
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOdbAutonomousDatabaseSourceConfigurationRestoreFromBackup), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationRestoreFromBackup")]
        internal sealed class _Proxy : DeputyBase, aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationRestoreFromBackup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the Autonomous Database backup.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#autonomous_database_backup_id OdbAutonomousDatabase#autonomous_database_backup_id}
            /// </remarks>
            [JsiiProperty(name: "autonomousDatabaseBackupId", typeJson: "{\"primitive\":\"string\"}")]
            public string AutonomousDatabaseBackupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Type of clone to create from the backup.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#clone_type OdbAutonomousDatabase#clone_type}
            /// </remarks>
            [JsiiProperty(name: "cloneType", typeJson: "{\"primitive\":\"string\"}")]
            public string CloneType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Tablespace IDs to clone.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#clone_table_space_list OdbAutonomousDatabase#clone_table_space_list}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloneTableSpaceList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? CloneTableSpaceList
            {
                get => GetInstanceProperty<double[]?>();
            }
        }
    }
}
