using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabaseAutonomousDatabaseDbToolsDetails), fullyQualifiedName: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseDbToolsDetails")]
    public interface IDatabaseAutonomousDatabaseDbToolsDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database#name DatabaseAutonomousDatabase#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database#compute_count DatabaseAutonomousDatabase#compute_count}.</summary>
        [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ComputeCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database#is_enabled DatabaseAutonomousDatabase#is_enabled}.</summary>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database#max_idle_time_in_minutes DatabaseAutonomousDatabase#max_idle_time_in_minutes}.</summary>
        [JsiiProperty(name: "maxIdleTimeInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxIdleTimeInMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseAutonomousDatabaseDbToolsDetails), fullyQualifiedName: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseDbToolsDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseDbToolsDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database#name DatabaseAutonomousDatabase#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database#compute_count DatabaseAutonomousDatabase#compute_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ComputeCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database#is_enabled DatabaseAutonomousDatabase#is_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database#max_idle_time_in_minutes DatabaseAutonomousDatabase#max_idle_time_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxIdleTimeInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxIdleTimeInMinutes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
