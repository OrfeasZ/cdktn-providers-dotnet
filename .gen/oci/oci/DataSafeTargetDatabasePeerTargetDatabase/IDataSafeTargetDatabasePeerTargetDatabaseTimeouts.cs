using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeTargetDatabasePeerTargetDatabase
{
    [JsiiInterface(nativeType: typeof(IDataSafeTargetDatabasePeerTargetDatabaseTimeouts), fullyQualifiedName: "oci.dataSafeTargetDatabasePeerTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseTimeouts")]
    public interface IDataSafeTargetDatabasePeerTargetDatabaseTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#create DataSafeTargetDatabasePeerTargetDatabase#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#delete DataSafeTargetDatabasePeerTargetDatabase#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#update DataSafeTargetDatabasePeerTargetDatabase#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeTargetDatabasePeerTargetDatabaseTimeouts), fullyQualifiedName: "oci.dataSafeTargetDatabasePeerTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeTargetDatabasePeerTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#create DataSafeTargetDatabasePeerTargetDatabase#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#delete DataSafeTargetDatabasePeerTargetDatabase#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#update DataSafeTargetDatabasePeerTargetDatabase#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
