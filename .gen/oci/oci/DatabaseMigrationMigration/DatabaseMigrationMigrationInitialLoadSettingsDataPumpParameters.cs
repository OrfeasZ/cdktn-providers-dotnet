using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    [JsiiByValue(fqn: "oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsDataPumpParameters")]
    public class DatabaseMigrationMigrationInitialLoadSettingsDataPumpParameters : oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsDataPumpParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#estimate DatabaseMigrationMigration#estimate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "estimate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Estimate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#exclude_parameters DatabaseMigrationMigration#exclude_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludeParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludeParameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#export_parallelism_degree DatabaseMigrationMigration#export_parallelism_degree}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exportParallelismDegree", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExportParallelismDegree
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#import_parallelism_degree DatabaseMigrationMigration#import_parallelism_degree}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "importParallelismDegree", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ImportParallelismDegree
        {
            get;
            set;
        }

        private object? _isCluster;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#is_cluster DatabaseMigrationMigration#is_cluster}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isCluster", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsCluster
        {
            get => _isCluster;
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
                _isCluster = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#table_exists_action DatabaseMigrationMigration#table_exists_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tableExistsAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TableExistsAction
        {
            get;
            set;
        }
    }
}
