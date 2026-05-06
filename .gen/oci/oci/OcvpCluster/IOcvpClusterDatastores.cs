using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpCluster
{
    [JsiiInterface(nativeType: typeof(IOcvpClusterDatastores), fullyQualifiedName: "oci.ocvpCluster.OcvpClusterDatastores")]
    public interface IOcvpClusterDatastores
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_cluster#block_volume_ids OcvpCluster#block_volume_ids}.</summary>
        [JsiiProperty(name: "blockVolumeIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] BlockVolumeIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_cluster#datastore_type OcvpCluster#datastore_type}.</summary>
        [JsiiProperty(name: "datastoreType", typeJson: "{\"primitive\":\"string\"}")]
        string DatastoreType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOcvpClusterDatastores), fullyQualifiedName: "oci.ocvpCluster.OcvpClusterDatastores")]
        internal sealed class _Proxy : DeputyBase, oci.OcvpCluster.IOcvpClusterDatastores
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_cluster#block_volume_ids OcvpCluster#block_volume_ids}.</summary>
            [JsiiProperty(name: "blockVolumeIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] BlockVolumeIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_cluster#datastore_type OcvpCluster#datastore_type}.</summary>
            [JsiiProperty(name: "datastoreType", typeJson: "{\"primitive\":\"string\"}")]
            public string DatastoreType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
