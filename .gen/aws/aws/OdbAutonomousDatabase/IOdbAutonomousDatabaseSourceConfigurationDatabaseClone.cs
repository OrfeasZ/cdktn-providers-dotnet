using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IOdbAutonomousDatabaseSourceConfigurationDatabaseClone), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationDatabaseClone")]
    public interface IOdbAutonomousDatabaseSourceConfigurationDatabaseClone
    {
        /// <summary>Type of clone to create.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#clone_type OdbAutonomousDatabase#clone_type}
        /// </remarks>
        [JsiiProperty(name: "cloneType", typeJson: "{\"primitive\":\"string\"}")]
        string CloneType
        {
            get;
        }

        /// <summary>ID of the source Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#source_autonomous_database_id OdbAutonomousDatabase#source_autonomous_database_id}
        /// </remarks>
        [JsiiProperty(name: "sourceAutonomousDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceAutonomousDatabaseId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOdbAutonomousDatabaseSourceConfigurationDatabaseClone), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationDatabaseClone")]
        internal sealed class _Proxy : DeputyBase, aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationDatabaseClone
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Type of clone to create.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#clone_type OdbAutonomousDatabase#clone_type}
            /// </remarks>
            [JsiiProperty(name: "cloneType", typeJson: "{\"primitive\":\"string\"}")]
            public string CloneType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ID of the source Autonomous Database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#source_autonomous_database_id OdbAutonomousDatabase#source_autonomous_database_id}
            /// </remarks>
            [JsiiProperty(name: "sourceAutonomousDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceAutonomousDatabaseId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
