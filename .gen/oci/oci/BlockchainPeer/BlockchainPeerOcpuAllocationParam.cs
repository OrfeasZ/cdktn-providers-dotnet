using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BlockchainPeer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.blockchainPeer.BlockchainPeerOcpuAllocationParam")]
    public class BlockchainPeerOcpuAllocationParam : oci.BlockchainPeer.IBlockchainPeerOcpuAllocationParam
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_peer#ocpu_allocation_number BlockchainPeer#ocpu_allocation_number}.</summary>
        [JsiiProperty(name: "ocpuAllocationNumber", typeJson: "{\"primitive\":\"number\"}")]
        public double OcpuAllocationNumber
        {
            get;
            set;
        }
    }
}
