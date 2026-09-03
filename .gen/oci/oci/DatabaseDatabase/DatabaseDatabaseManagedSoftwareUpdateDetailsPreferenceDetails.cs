using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabase
{
    [JsiiByValue(fqn: "oci.databaseDatabase.DatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetails")]
    public class DatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetails : oci.DatabaseDatabase.IDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_database#days_of_week DatabaseDatabase#days_of_week}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DaysOfWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_database#hour_of_day DatabaseDatabase#hour_of_day}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hourOfDay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HourOfDay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_database#update_mode DatabaseDatabase#update_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "updateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpdateMode
        {
            get;
            set;
        }

        private object? _versionSchemeDetails;

        /// <summary>version_scheme_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_database#version_scheme_details DatabaseDatabase#version_scheme_details}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseDatabase.IDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetailsVersionSchemeDetails" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "versionSchemeDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetailsVersionSchemeDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VersionSchemeDetails
        {
            get => _versionSchemeDetails;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatabaseDatabase.IDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetailsVersionSchemeDetails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseDatabase.IDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetailsVersionSchemeDetails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _versionSchemeDetails = value;
            }
        }
    }
}
