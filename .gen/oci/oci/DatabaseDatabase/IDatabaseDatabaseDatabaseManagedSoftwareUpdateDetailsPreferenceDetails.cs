using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetails), fullyQualifiedName: "oci.databaseDatabase.DatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetails")]
    public interface IDatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_database#days_of_week DatabaseDatabase#days_of_week}.</summary>
        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DaysOfWeek
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_database#hour_of_day DatabaseDatabase#hour_of_day}.</summary>
        [JsiiProperty(name: "hourOfDay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HourOfDay
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_database#update_mode DatabaseDatabase#update_mode}.</summary>
        [JsiiProperty(name: "updateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpdateMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>version_scheme_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_database#version_scheme_details DatabaseDatabase#version_scheme_details}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseDatabase.IDatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetailsVersionSchemeDetails" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "versionSchemeDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetailsVersionSchemeDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VersionSchemeDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetails), fullyQualifiedName: "oci.databaseDatabase.DatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseDatabase.IDatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_database#days_of_week DatabaseDatabase#days_of_week}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "daysOfWeek", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DaysOfWeek
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_database#hour_of_day DatabaseDatabase#hour_of_day}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hourOfDay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HourOfDay
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_database#update_mode DatabaseDatabase#update_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "updateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpdateMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>version_scheme_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_database#version_scheme_details DatabaseDatabase#version_scheme_details}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseDatabase.IDatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetailsVersionSchemeDetails" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "versionSchemeDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetailsVersionSchemeDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VersionSchemeDetails
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
