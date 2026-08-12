using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabase
{
    [JsiiByValue(fqn: "oci.databaseDatabase.DatabaseDatabaseDatabaseManagedSoftwareUpdateDetails")]
    public class DatabaseDatabaseDatabaseManagedSoftwareUpdateDetails : oci.DatabaseDatabase.IDatabaseDatabaseDatabaseManagedSoftwareUpdateDetails
    {
        private object? _isEnrolled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_database#is_enrolled DatabaseDatabase#is_enrolled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isEnrolled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsEnrolled
        {
            get => _isEnrolled;
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
                _isEnrolled = value;
            }
        }

        private object? _maintenanceDetails;

        /// <summary>maintenance_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_database#maintenance_details DatabaseDatabase#maintenance_details}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseDatabase.IDatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MaintenanceDetails
        {
            get => _maintenanceDetails;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatabaseDatabase.IDatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseDatabase.IDatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _maintenanceDetails = value;
            }
        }

        private object? _preferenceDetails;

        /// <summary>preference_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_database#preference_details DatabaseDatabase#preference_details}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseDatabase.IDatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetails" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preferenceDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PreferenceDetails
        {
            get => _preferenceDetails;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatabaseDatabase.IDatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseDatabase.IDatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _preferenceDetails = value;
            }
        }
    }
}
