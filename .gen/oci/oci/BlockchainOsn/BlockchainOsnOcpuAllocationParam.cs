using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BlockchainOsn
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.blockchainOsn.BlockchainOsnOcpuAllocationParam")]
    public class BlockchainOsnOcpuAllocationParam : oci.BlockchainOsn.IBlockchainOsnOcpuAllocationParam
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_osn#ocpu_allocation_number BlockchainOsn#ocpu_allocation_number}.</summary>
        [JsiiProperty(name: "ocpuAllocationNumber", typeJson: "{\"primitive\":\"number\"}")]
        public double OcpuAllocationNumber
        {
            get;
            set;
        }
    }
}
