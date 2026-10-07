using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationCloneToRefreshable")]
    public class OdbAutonomousDatabaseSourceConfigurationCloneToRefreshable : aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCloneToRefreshable
    {
        /// <summary>ID of the source Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#source_autonomous_database_id OdbAutonomousDatabase#source_autonomous_database_id}
        /// </remarks>
        [JsiiProperty(name: "sourceAutonomousDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceAutonomousDatabaseId
        {
            get;
            set;
        }

        /// <summary>Frequency at which the refreshable clone is automatically refreshed, in seconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#auto_refresh_frequency_in_seconds OdbAutonomousDatabase#auto_refresh_frequency_in_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoRefreshFrequencyInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutoRefreshFrequencyInSeconds
        {
            get;
            set;
        }

        /// <summary>Time lag between the refreshable clone and its source, in seconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#auto_refresh_point_lag_in_seconds OdbAutonomousDatabase#auto_refresh_point_lag_in_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoRefreshPointLagInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutoRefreshPointLagInSeconds
        {
            get;
            set;
        }

        /// <summary>Type of clone to create.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#clone_type OdbAutonomousDatabase#clone_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloneType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CloneType
        {
            get;
            set;
        }

        /// <summary>Open mode of the refreshable clone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#open_mode OdbAutonomousDatabase#open_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OpenMode
        {
            get;
            set;
        }

        /// <summary>Refresh mode of the clone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#refreshable_mode OdbAutonomousDatabase#refreshable_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "refreshableMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RefreshableMode
        {
            get;
            set;
        }

        /// <summary>Date and time when automatic refresh starts.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#time_of_auto_refresh_start OdbAutonomousDatabase#time_of_auto_refresh_start}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeOfAutoRefreshStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeOfAutoRefreshStart
        {
            get;
            set;
        }
    }
}
