using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BlockchainOsn
{
    [JsiiInterface(nativeType: typeof(IBlockchainOsnOcpuAllocationParam), fullyQualifiedName: "oci.blockchainOsn.BlockchainOsnOcpuAllocationParam")]
    public interface IBlockchainOsnOcpuAllocationParam
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_osn#ocpu_allocation_number BlockchainOsn#ocpu_allocation_number}.</summary>
        [JsiiProperty(name: "ocpuAllocationNumber", typeJson: "{\"primitive\":\"number\"}")]
        double OcpuAllocationNumber
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBlockchainOsnOcpuAllocationParam), fullyQualifiedName: "oci.blockchainOsn.BlockchainOsnOcpuAllocationParam")]
        internal sealed class _Proxy : DeputyBase, oci.BlockchainOsn.IBlockchainOsnOcpuAllocationParam
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_osn#ocpu_allocation_number BlockchainOsn#ocpu_allocation_number}.</summary>
            [JsiiProperty(name: "ocpuAllocationNumber", typeJson: "{\"primitive\":\"number\"}")]
            public double OcpuAllocationNumber
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
