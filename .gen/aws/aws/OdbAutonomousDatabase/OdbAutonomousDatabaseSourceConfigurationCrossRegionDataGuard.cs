using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationCrossRegionDataGuard")]
    public class OdbAutonomousDatabaseSourceConfigurationCrossRegionDataGuard : aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCrossRegionDataGuard
    {
        /// <summary>ARN of the source Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#source_autonomous_database_arn OdbAutonomousDatabase#source_autonomous_database_arn}
        /// </remarks>
        [JsiiProperty(name: "sourceAutonomousDatabaseArn", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceAutonomousDatabaseArn
        {
            get;
            set;
        }
    }
}
