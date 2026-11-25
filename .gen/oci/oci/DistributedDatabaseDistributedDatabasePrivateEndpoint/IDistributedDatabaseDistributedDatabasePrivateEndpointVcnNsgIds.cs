using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabasePrivateEndpoint
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedDatabasePrivateEndpointVcnNsgIds), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabasePrivateEndpoint.DistributedDatabaseDistributedDatabasePrivateEndpointVcnNsgIds")]
    public interface IDistributedDatabaseDistributedDatabasePrivateEndpointVcnNsgIds
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database_private_endpoint#nsg_ids DistributedDatabaseDistributedDatabasePrivateEndpoint#nsg_ids}.</summary>
        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] NsgIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database_private_endpoint#vcn_id DistributedDatabaseDistributedDatabasePrivateEndpoint#vcn_id}.</summary>
        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
        string VcnId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedDatabasePrivateEndpointVcnNsgIds), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabasePrivateEndpoint.DistributedDatabaseDistributedDatabasePrivateEndpointVcnNsgIds")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedDatabasePrivateEndpoint.IDistributedDatabaseDistributedDatabasePrivateEndpointVcnNsgIds
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database_private_endpoint#nsg_ids DistributedDatabaseDistributedDatabasePrivateEndpoint#nsg_ids}.</summary>
            [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] NsgIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database_private_endpoint#vcn_id DistributedDatabaseDistributedDatabasePrivateEndpoint#vcn_id}.</summary>
            [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
            public string VcnId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
