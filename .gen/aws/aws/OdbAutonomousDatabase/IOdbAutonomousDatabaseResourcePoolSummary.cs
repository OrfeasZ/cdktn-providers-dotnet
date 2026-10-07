using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IOdbAutonomousDatabaseResourcePoolSummary), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseResourcePoolSummary")]
    public interface IOdbAutonomousDatabaseResourcePoolSummary
    {
        /// <summary>Whether the resource pool is disabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_disabled OdbAutonomousDatabase#is_disabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsDisabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Number of Autonomous Databases the resource pool can contain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#pool_size OdbAutonomousDatabase#pool_size}
        /// </remarks>
        [JsiiProperty(name: "poolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PoolSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Total storage size of the resource pool, in TB.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#pool_storage_size_in_tbs OdbAutonomousDatabase#pool_storage_size_in_tbs}
        /// </remarks>
        [JsiiProperty(name: "poolStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PoolStorageSizeInTbs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOdbAutonomousDatabaseResourcePoolSummary), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseResourcePoolSummary")]
        internal sealed class _Proxy : DeputyBase, aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseResourcePoolSummary
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether the resource pool is disabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_disabled OdbAutonomousDatabase#is_disabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsDisabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Number of Autonomous Databases the resource pool can contain.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#pool_size OdbAutonomousDatabase#pool_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "poolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PoolSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Total storage size of the resource pool, in TB.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#pool_storage_size_in_tbs OdbAutonomousDatabase#pool_storage_size_in_tbs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "poolStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PoolStorageSizeInTbs
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
