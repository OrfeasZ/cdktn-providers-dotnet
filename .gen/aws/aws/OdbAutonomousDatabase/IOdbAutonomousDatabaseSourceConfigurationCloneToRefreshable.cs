using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IOdbAutonomousDatabaseSourceConfigurationCloneToRefreshable), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationCloneToRefreshable")]
    public interface IOdbAutonomousDatabaseSourceConfigurationCloneToRefreshable
    {
        /// <summary>ID of the source Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#source_autonomous_database_id OdbAutonomousDatabase#source_autonomous_database_id}
        /// </remarks>
        [JsiiProperty(name: "sourceAutonomousDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceAutonomousDatabaseId
        {
            get;
        }

        /// <summary>Frequency at which the refreshable clone is automatically refreshed, in seconds.</summary>
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

        /// <summary>Time lag between the refreshable clone and its source, in seconds.</summary>
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

        /// <summary>Type of clone to create.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#clone_type OdbAutonomousDatabase#clone_type}
        /// </remarks>
        [JsiiProperty(name: "cloneType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloneType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Open mode of the refreshable clone.</summary>
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

        /// <summary>Refresh mode of the clone.</summary>
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

        /// <summary>Date and time when automatic refresh starts.</summary>
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

        [JsiiTypeProxy(nativeType: typeof(IOdbAutonomousDatabaseSourceConfigurationCloneToRefreshable), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationCloneToRefreshable")]
        internal sealed class _Proxy : DeputyBase, aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCloneToRefreshable
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
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

            /// <summary>Frequency at which the refreshable clone is automatically refreshed, in seconds.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#auto_refresh_frequency_in_seconds OdbAutonomousDatabase#auto_refresh_frequency_in_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoRefreshFrequencyInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AutoRefreshFrequencyInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Time lag between the refreshable clone and its source, in seconds.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#auto_refresh_point_lag_in_seconds OdbAutonomousDatabase#auto_refresh_point_lag_in_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoRefreshPointLagInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AutoRefreshPointLagInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Type of clone to create.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#clone_type OdbAutonomousDatabase#clone_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloneType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloneType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Open mode of the refreshable clone.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#open_mode OdbAutonomousDatabase#open_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OpenMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Refresh mode of the clone.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#refreshable_mode OdbAutonomousDatabase#refreshable_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "refreshableMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RefreshableMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Date and time when automatic refresh starts.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#time_of_auto_refresh_start OdbAutonomousDatabase#time_of_auto_refresh_start}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeOfAutoRefreshStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeOfAutoRefreshStart
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
