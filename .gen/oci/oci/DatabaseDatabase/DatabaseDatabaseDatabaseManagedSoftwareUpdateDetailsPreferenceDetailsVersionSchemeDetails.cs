using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabase
{
    [JsiiByValue(fqn: "oci.databaseDatabase.DatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetailsVersionSchemeDetails")]
    public class DatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetailsVersionSchemeDetails : oci.DatabaseDatabase.IDatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetailsVersionSchemeDetails
    {
        private object? _isOlderVersionAcknowledged;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/database_database#is_older_version_acknowledged DatabaseDatabase#is_older_version_acknowledged}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/database_database#major_version DatabaseDatabase#major_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "majorVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MajorVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/database_database#source DatabaseDatabase#source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/database_database#version_preference DatabaseDatabase#version_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "versionPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VersionPreference
        {
            get;
            set;
        }
    }
}
