using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabasePrivateEndpoint
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedDatabasePrivateEndpointPatchOperations), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabasePrivateEndpoint.DistributedDatabaseDistributedDatabasePrivateEndpointPatchOperations")]
    public interface IDistributedDatabaseDistributedDatabasePrivateEndpointPatchOperations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database_private_endpoint#operation DistributedDatabaseDistributedDatabasePrivateEndpoint#operation}.</summary>
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        string Operation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database_private_endpoint#selection DistributedDatabaseDistributedDatabasePrivateEndpoint#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        string Selection
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database_private_endpoint#value DistributedDatabaseDistributedDatabasePrivateEndpoint#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedDatabasePrivateEndpointPatchOperations), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabasePrivateEndpoint.DistributedDatabaseDistributedDatabasePrivateEndpointPatchOperations")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedDatabasePrivateEndpoint.IDistributedDatabaseDistributedDatabasePrivateEndpointPatchOperations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database_private_endpoint#operation DistributedDatabaseDistributedDatabasePrivateEndpoint#operation}.</summary>
            [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
            public string Operation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database_private_endpoint#selection DistributedDatabaseDistributedDatabasePrivateEndpoint#selection}.</summary>
            [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
            public string Selection
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database_private_endpoint#value DistributedDatabaseDistributedDatabasePrivateEndpoint#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
