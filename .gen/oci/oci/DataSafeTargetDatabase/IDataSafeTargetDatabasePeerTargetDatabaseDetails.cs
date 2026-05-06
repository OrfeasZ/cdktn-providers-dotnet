using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeTargetDatabase
{
    [JsiiInterface(nativeType: typeof(IDataSafeTargetDatabasePeerTargetDatabaseDetails), fullyQualifiedName: "oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetails")]
    public interface IDataSafeTargetDatabasePeerTargetDatabaseDetails
    {
        /// <summary>database_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#database_details DataSafeTargetDatabase#database_details}
        /// </remarks>
        [JsiiProperty(name: "databaseDetails", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsDatabaseDetails\"}")]
        oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetailsDatabaseDetails DatabaseDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#dataguard_association_id DataSafeTargetDatabase#dataguard_association_id}.</summary>
        [JsiiProperty(name: "dataguardAssociationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataguardAssociationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#description DataSafeTargetDatabase#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#display_name DataSafeTargetDatabase#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>tls_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#tls_config DataSafeTargetDatabase#tls_config}
        /// </remarks>
        [JsiiProperty(name: "tlsConfig", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsTlsConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetailsTlsConfig? TlsConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeTargetDatabasePeerTargetDatabaseDetails), fullyQualifiedName: "oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>database_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#database_details DataSafeTargetDatabase#database_details}
            /// </remarks>
            [JsiiProperty(name: "databaseDetails", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsDatabaseDetails\"}")]
            public oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetailsDatabaseDetails DatabaseDetails
            {
                get => GetInstanceProperty<oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetailsDatabaseDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#dataguard_association_id DataSafeTargetDatabase#dataguard_association_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataguardAssociationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataguardAssociationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#description DataSafeTargetDatabase#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#display_name DataSafeTargetDatabase#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tls_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#tls_config DataSafeTargetDatabase#tls_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tlsConfig", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsTlsConfig\"}", isOptional: true)]
            public oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetailsTlsConfig? TlsConfig
            {
                get => GetInstanceProperty<oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetailsTlsConfig?>();
            }
        }
    }
}
