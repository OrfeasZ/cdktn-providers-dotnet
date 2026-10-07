using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IOdbAutonomousDatabaseDbToolsDetails), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseDbToolsDetails")]
    public interface IOdbAutonomousDatabaseDbToolsDetails
    {
        /// <summary>Compute capacity allocated to the database tool.</summary>
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

        /// <summary>Whether the database tool is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_enabled OdbAutonomousDatabase#is_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum idle time before the database tool is shut down, in minutes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#max_idle_time_in_minutes OdbAutonomousDatabase#max_idle_time_in_minutes}
        /// </remarks>
        [JsiiProperty(name: "maxIdleTimeInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxIdleTimeInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the database tool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#name OdbAutonomousDatabase#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOdbAutonomousDatabaseDbToolsDetails), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseDbToolsDetails")]
        internal sealed class _Proxy : DeputyBase, aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseDbToolsDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Compute capacity allocated to the database tool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#compute_count OdbAutonomousDatabase#compute_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ComputeCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Whether the database tool is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_enabled OdbAutonomousDatabase#is_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Maximum idle time before the database tool is shut down, in minutes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#max_idle_time_in_minutes OdbAutonomousDatabase#max_idle_time_in_minutes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxIdleTimeInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxIdleTimeInMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Name of the database tool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#name OdbAutonomousDatabase#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
