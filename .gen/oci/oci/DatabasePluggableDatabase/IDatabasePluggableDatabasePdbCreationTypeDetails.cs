using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabasePluggableDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabasePluggableDatabasePdbCreationTypeDetails), fullyQualifiedName: "oci.databasePluggableDatabase.DatabasePluggableDatabasePdbCreationTypeDetails")]
    public interface IDatabasePluggableDatabasePdbCreationTypeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#creation_type DatabasePluggableDatabase#creation_type}.</summary>
        [JsiiProperty(name: "creationType", typeJson: "{\"primitive\":\"string\"}")]
        string CreationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#source_pluggable_database_id DatabasePluggableDatabase#source_pluggable_database_id}.</summary>
        [JsiiProperty(name: "sourcePluggableDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        string SourcePluggableDatabaseId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#dblink_username DatabasePluggableDatabase#dblink_username}.</summary>
        [JsiiProperty(name: "dblinkUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DblinkUsername
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#dblink_user_password DatabasePluggableDatabase#dblink_user_password}.</summary>
        [JsiiProperty(name: "dblinkUserPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DblinkUserPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#is_thin_clone DatabasePluggableDatabase#is_thin_clone}.</summary>
        [JsiiProperty(name: "isThinClone", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsThinClone
        {
            get
            {
                return null;
            }
        }

        /// <summary>refreshable_clone_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#refreshable_clone_details DatabasePluggableDatabase#refreshable_clone_details}
        /// </remarks>
        [JsiiProperty(name: "refreshableCloneDetails", typeJson: "{\"fqn\":\"oci.databasePluggableDatabase.DatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabasePluggableDatabase.IDatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails? RefreshableCloneDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#source_container_database_admin_password DatabasePluggableDatabase#source_container_database_admin_password}.</summary>
        [JsiiProperty(name: "sourceContainerDatabaseAdminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceContainerDatabaseAdminPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#source_pluggable_database_snapshot_id DatabasePluggableDatabase#source_pluggable_database_snapshot_id}.</summary>
        [JsiiProperty(name: "sourcePluggableDatabaseSnapshotId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourcePluggableDatabaseSnapshotId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabasePluggableDatabasePdbCreationTypeDetails), fullyQualifiedName: "oci.databasePluggableDatabase.DatabasePluggableDatabasePdbCreationTypeDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabasePluggableDatabase.IDatabasePluggableDatabasePdbCreationTypeDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#creation_type DatabasePluggableDatabase#creation_type}.</summary>
            [JsiiProperty(name: "creationType", typeJson: "{\"primitive\":\"string\"}")]
            public string CreationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#source_pluggable_database_id DatabasePluggableDatabase#source_pluggable_database_id}.</summary>
            [JsiiProperty(name: "sourcePluggableDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourcePluggableDatabaseId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#dblink_username DatabasePluggableDatabase#dblink_username}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dblinkUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DblinkUsername
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#dblink_user_password DatabasePluggableDatabase#dblink_user_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dblinkUserPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DblinkUserPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#is_thin_clone DatabasePluggableDatabase#is_thin_clone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isThinClone", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsThinClone
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>refreshable_clone_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#refreshable_clone_details DatabasePluggableDatabase#refreshable_clone_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "refreshableCloneDetails", typeJson: "{\"fqn\":\"oci.databasePluggableDatabase.DatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails\"}", isOptional: true)]
            public oci.DatabasePluggableDatabase.IDatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails? RefreshableCloneDetails
            {
                get => GetInstanceProperty<oci.DatabasePluggableDatabase.IDatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#source_container_database_admin_password DatabasePluggableDatabase#source_container_database_admin_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceContainerDatabaseAdminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceContainerDatabaseAdminPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#source_pluggable_database_snapshot_id DatabasePluggableDatabase#source_pluggable_database_snapshot_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourcePluggableDatabaseSnapshotId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourcePluggableDatabaseSnapshotId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
