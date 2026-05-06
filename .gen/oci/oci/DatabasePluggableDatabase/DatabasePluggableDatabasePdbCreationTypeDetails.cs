using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabasePluggableDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databasePluggableDatabase.DatabasePluggableDatabasePdbCreationTypeDetails")]
    public class DatabasePluggableDatabasePdbCreationTypeDetails : oci.DatabasePluggableDatabase.IDatabasePluggableDatabasePdbCreationTypeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#creation_type DatabasePluggableDatabase#creation_type}.</summary>
        [JsiiProperty(name: "creationType", typeJson: "{\"primitive\":\"string\"}")]
        public string CreationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#source_pluggable_database_id DatabasePluggableDatabase#source_pluggable_database_id}.</summary>
        [JsiiProperty(name: "sourcePluggableDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public string SourcePluggableDatabaseId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#dblink_username DatabasePluggableDatabase#dblink_username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dblinkUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DblinkUsername
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#dblink_user_password DatabasePluggableDatabase#dblink_user_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dblinkUserPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DblinkUserPassword
        {
            get;
            set;
        }

        private object? _isThinClone;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#is_thin_clone DatabasePluggableDatabase#is_thin_clone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isThinClone", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsThinClone
        {
            get => _isThinClone;
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
                _isThinClone = value;
            }
        }

        /// <summary>refreshable_clone_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#refreshable_clone_details DatabasePluggableDatabase#refreshable_clone_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "refreshableCloneDetails", typeJson: "{\"fqn\":\"oci.databasePluggableDatabase.DatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails\"}", isOptional: true)]
        public oci.DatabasePluggableDatabase.IDatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails? RefreshableCloneDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#source_container_database_admin_password DatabasePluggableDatabase#source_container_database_admin_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceContainerDatabaseAdminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceContainerDatabaseAdminPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#source_pluggable_database_snapshot_id DatabasePluggableDatabase#source_pluggable_database_snapshot_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourcePluggableDatabaseSnapshotId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourcePluggableDatabaseSnapshotId
        {
            get;
            set;
        }
    }
}
