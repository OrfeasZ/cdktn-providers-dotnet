using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabaseAutonomousDatabaseResourcePoolSummary), fullyQualifiedName: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseResourcePoolSummary")]
    public interface IDatabaseAutonomousDatabaseResourcePoolSummary
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_autonomous_database#available_storage_capacity_in_tbs DatabaseAutonomousDatabase#available_storage_capacity_in_tbs}.</summary>
        [JsiiProperty(name: "availableStorageCapacityInTbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AvailableStorageCapacityInTbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_autonomous_database#is_disabled DatabaseAutonomousDatabase#is_disabled}.</summary>
        /// <remarks>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_autonomous_database#pool_size DatabaseAutonomousDatabase#pool_size}.</summary>
        [JsiiProperty(name: "poolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PoolSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_autonomous_database#pool_storage_size_in_tbs DatabaseAutonomousDatabase#pool_storage_size_in_tbs}.</summary>
        [JsiiProperty(name: "poolStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PoolStorageSizeInTbs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseAutonomousDatabaseResourcePoolSummary), fullyQualifiedName: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseResourcePoolSummary")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseResourcePoolSummary
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_autonomous_database#available_storage_capacity_in_tbs DatabaseAutonomousDatabase#available_storage_capacity_in_tbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availableStorageCapacityInTbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AvailableStorageCapacityInTbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_autonomous_database#is_disabled DatabaseAutonomousDatabase#is_disabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsDisabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_autonomous_database#pool_size DatabaseAutonomousDatabase#pool_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "poolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PoolSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_autonomous_database#pool_storage_size_in_tbs DatabaseAutonomousDatabase#pool_storage_size_in_tbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "poolStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PoolStorageSizeInTbs
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
