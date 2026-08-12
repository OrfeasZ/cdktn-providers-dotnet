using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.difStack.DifStackObjectstorage")]
    public class DifStackObjectstorage : oci.DifStack.IDifStackObjectstorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/dif_stack#instance_id DifStack#instance_id}.</summary>
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/dif_stack#object_versioning DifStack#object_versioning}.</summary>
        [JsiiProperty(name: "objectVersioning", typeJson: "{\"primitive\":\"string\"}")]
        public string ObjectVersioning
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/dif_stack#storage_tier DifStack#storage_tier}.</summary>
        [JsiiProperty(name: "storageTier", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageTier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/dif_stack#auto_tiering DifStack#auto_tiering}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoTiering", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutoTiering
        {
            get;
            set;
        }
    }
}
