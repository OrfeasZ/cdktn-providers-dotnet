using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDbSystem
{
    [JsiiInterface(nativeType: typeof(IDatabaseDbSystemDbSystemOptions), fullyQualifiedName: "oci.databaseDbSystem.DatabaseDbSystemDbSystemOptions")]
    public interface IDatabaseDbSystemDbSystemOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#storage_management DatabaseDbSystem#storage_management}.</summary>
        [JsiiProperty(name: "storageManagement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageManagement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseDbSystemDbSystemOptions), fullyQualifiedName: "oci.databaseDbSystem.DatabaseDbSystemDbSystemOptions")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseDbSystem.IDatabaseDbSystemDbSystemOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#storage_management DatabaseDbSystem#storage_management}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageManagement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageManagement
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
