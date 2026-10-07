using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    [JsiiByValue(fqn: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseResourcePoolSummary")]
    public class OdbAutonomousDatabaseResourcePoolSummary : aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseResourcePoolSummary
    {
        private object? _isDisabled;

        /// <summary>Whether the resource pool is disabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_disabled OdbAutonomousDatabase#is_disabled}
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

        /// <summary>Number of Autonomous Databases the resource pool can contain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#pool_size OdbAutonomousDatabase#pool_size}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "poolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PoolSize
        {
            get;
            set;
        }

        /// <summary>Total storage size of the resource pool, in TB.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#pool_storage_size_in_tbs OdbAutonomousDatabase#pool_storage_size_in_tbs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "poolStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PoolStorageSizeInTbs
        {
            get;
            set;
        }
    }
}
