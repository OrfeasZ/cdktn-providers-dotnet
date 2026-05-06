using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BlockchainPeer
{
    [JsiiInterface(nativeType: typeof(IBlockchainPeerOcpuAllocationParam), fullyQualifiedName: "oci.blockchainPeer.BlockchainPeerOcpuAllocationParam")]
    public interface IBlockchainPeerOcpuAllocationParam
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_peer#ocpu_allocation_number BlockchainPeer#ocpu_allocation_number}.</summary>
        [JsiiProperty(name: "ocpuAllocationNumber", typeJson: "{\"primitive\":\"number\"}")]
        double OcpuAllocationNumber
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBlockchainPeerOcpuAllocationParam), fullyQualifiedName: "oci.blockchainPeer.BlockchainPeerOcpuAllocationParam")]
        internal sealed class _Proxy : DeputyBase, oci.BlockchainPeer.IBlockchainPeerOcpuAllocationParam
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_peer#ocpu_allocation_number BlockchainPeer#ocpu_allocation_number}.</summary>
            [JsiiProperty(name: "ocpuAllocationNumber", typeJson: "{\"primitive\":\"number\"}")]
            public double OcpuAllocationNumber
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
