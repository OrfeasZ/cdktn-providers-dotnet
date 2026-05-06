using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVirtualCircuit
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreVirtualCircuit.CoreVirtualCircuitPublicPrefixes")]
    public class CoreVirtualCircuitPublicPrefixes : oci.CoreVirtualCircuit.ICoreVirtualCircuitPublicPrefixes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#cidr_block CoreVirtualCircuit#cidr_block}.</summary>
        [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public string CidrBlock
        {
            get;
            set;
        }
    }
}
