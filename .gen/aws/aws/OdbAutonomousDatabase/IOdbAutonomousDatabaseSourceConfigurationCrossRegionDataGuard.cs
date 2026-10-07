using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IOdbAutonomousDatabaseSourceConfigurationCrossRegionDataGuard), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationCrossRegionDataGuard")]
    public interface IOdbAutonomousDatabaseSourceConfigurationCrossRegionDataGuard
    {
        /// <summary>ARN of the source Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#source_autonomous_database_arn OdbAutonomousDatabase#source_autonomous_database_arn}
        /// </remarks>
        [JsiiProperty(name: "sourceAutonomousDatabaseArn", typeJson: "{\"primitive\":\"string\"}")]
        string SourceAutonomousDatabaseArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOdbAutonomousDatabaseSourceConfigurationCrossRegionDataGuard), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationCrossRegionDataGuard")]
        internal sealed class _Proxy : DeputyBase, aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCrossRegionDataGuard
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ARN of the source Autonomous Database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#source_autonomous_database_arn OdbAutonomousDatabase#source_autonomous_database_arn}
            /// </remarks>
            [JsiiProperty(name: "sourceAutonomousDatabaseArn", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceAutonomousDatabaseArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
