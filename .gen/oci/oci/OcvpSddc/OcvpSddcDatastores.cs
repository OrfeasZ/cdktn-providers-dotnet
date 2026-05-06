using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpSddc
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.ocvpSddc.OcvpSddcDatastores")]
    public class OcvpSddcDatastores : oci.OcvpSddc.IOcvpSddcDatastores
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#block_volume_ids OcvpSddc#block_volume_ids}.</summary>
        [JsiiProperty(name: "blockVolumeIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] BlockVolumeIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#datastore_type OcvpSddc#datastore_type}.</summary>
        [JsiiProperty(name: "datastoreType", typeJson: "{\"primitive\":\"string\"}")]
        public string DatastoreType
        {
            get;
            set;
        }
    }
}
