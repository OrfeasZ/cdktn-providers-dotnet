using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.bdsBdsInstance.BdsBdsInstanceCloudSqlDetails")]
    public class BdsBdsInstanceCloudSqlDetails : oci.BdsBdsInstance.IBdsBdsInstanceCloudSqlDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#shape BdsBdsInstance#shape}.</summary>
        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public string Shape
        {
            get;
            set;
        }
    }
}
