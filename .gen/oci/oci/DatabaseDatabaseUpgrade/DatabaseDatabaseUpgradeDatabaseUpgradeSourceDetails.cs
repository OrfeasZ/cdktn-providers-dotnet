using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabaseUpgrade
{
    [JsiiByValue(fqn: "oci.databaseDatabaseUpgrade.DatabaseDatabaseUpgradeDatabaseUpgradeSourceDetails")]
    public class DatabaseDatabaseUpgradeDatabaseUpgradeSourceDetails : oci.DatabaseDatabaseUpgrade.IDatabaseDatabaseUpgradeDatabaseUpgradeSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/database_database_upgrade#database_software_image_id DatabaseDatabaseUpgrade#database_software_image_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseSoftwareImageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseSoftwareImageId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/database_database_upgrade#db_version DatabaseDatabaseUpgrade#db_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbVersion
        {
            get;
            set;
        }

        private object? _isOlderVersionAcknowledged;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/database_database_upgrade#is_older_version_acknowledged DatabaseDatabaseUpgrade#is_older_version_acknowledged}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isOlderVersionAcknowledged", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsOlderVersionAcknowledged
        {
            get => _isOlderVersionAcknowledged;
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
                _isOlderVersionAcknowledged = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/database_database_upgrade#options DatabaseDatabaseUpgrade#options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "options", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Options
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/database_database_upgrade#source DatabaseDatabaseUpgrade#source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Source
        {
            get;
            set;
        }
    }
}
