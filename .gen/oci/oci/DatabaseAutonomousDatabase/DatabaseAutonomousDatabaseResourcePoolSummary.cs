using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabase
{
    [JsiiByValue(fqn: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseResourcePoolSummary")]
    public class DatabaseAutonomousDatabaseResourcePoolSummary : oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseResourcePoolSummary
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_autonomous_database#available_storage_capacity_in_tbs DatabaseAutonomousDatabase#available_storage_capacity_in_tbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availableStorageCapacityInTbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AvailableStorageCapacityInTbs
        {
            get;
            set;
        }

        private object? _isDisabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_autonomous_database#is_disabled DatabaseAutonomousDatabase#is_disabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsDisabled
        {
            get => _isDisabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isDisabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_autonomous_database#pool_size DatabaseAutonomousDatabase#pool_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "poolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PoolSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_autonomous_database#pool_storage_size_in_tbs DatabaseAutonomousDatabase#pool_storage_size_in_tbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "poolStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PoolStorageSizeInTbs
        {
            get;
            set;
        }
    }
}
