using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabaseDatabaseManagedSoftwareUpdateDetails), fullyQualifiedName: "oci.databaseDatabase.DatabaseDatabaseManagedSoftwareUpdateDetails")]
    public interface IDatabaseDatabaseManagedSoftwareUpdateDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_database#is_enrolled DatabaseDatabase#is_enrolled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isEnrolled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEnrolled
        {
            get
            {
                return null;
            }
        }

        /// <summary>maintenance_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_database#maintenance_details DatabaseDatabase#maintenance_details}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseDatabase.IDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "maintenanceDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MaintenanceDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>preference_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_database#preference_details DatabaseDatabase#preference_details}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseDatabase.IDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetails" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "preferenceDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PreferenceDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseDatabaseManagedSoftwareUpdateDetails), fullyQualifiedName: "oci.databaseDatabase.DatabaseDatabaseManagedSoftwareUpdateDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseDatabase.IDatabaseDatabaseManagedSoftwareUpdateDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_database#is_enrolled DatabaseDatabase#is_enrolled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isEnrolled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEnrolled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>maintenance_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_database#maintenance_details DatabaseDatabase#maintenance_details}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseDatabase.IDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MaintenanceDetails
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>preference_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_database#preference_details DatabaseDatabase#preference_details}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseDatabase.IDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetails" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preferenceDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PreferenceDetails
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
