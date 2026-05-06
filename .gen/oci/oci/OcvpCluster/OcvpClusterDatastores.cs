using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.ocvpCluster.OcvpClusterDatastores")]
    public class OcvpClusterDatastores : oci.OcvpCluster.IOcvpClusterDatastores
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_cluster#block_volume_ids OcvpCluster#block_volume_ids}.</summary>
        [JsiiProperty(name: "blockVolumeIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] BlockVolumeIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_cluster#datastore_type OcvpCluster#datastore_type}.</summary>
        [JsiiProperty(name: "datastoreType", typeJson: "{\"primitive\":\"string\"}")]
        public string DatastoreType
        {
            get;
            set;
        }
    }
}
