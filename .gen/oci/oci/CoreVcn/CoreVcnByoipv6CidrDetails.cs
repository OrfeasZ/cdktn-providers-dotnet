using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVcn
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreVcn.CoreVcnByoipv6CidrDetails")]
    public class CoreVcnByoipv6CidrDetails : oci.CoreVcn.ICoreVcnByoipv6CidrDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_vcn#byoipv6range_id CoreVcn#byoipv6range_id}.</summary>
        [JsiiProperty(name: "byoipv6RangeId", typeJson: "{\"primitive\":\"string\"}")]
        public string Byoipv6RangeId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_vcn#ipv6cidr_block CoreVcn#ipv6cidr_block}.</summary>
        [JsiiProperty(name: "ipv6CidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public string Ipv6CidrBlock
        {
            get;
            set;
        }
    }
}
