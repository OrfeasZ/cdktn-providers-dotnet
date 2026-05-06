using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVirtualCircuit
{
    [JsiiInterface(nativeType: typeof(ICoreVirtualCircuitPublicPrefixes), fullyQualifiedName: "oci.coreVirtualCircuit.CoreVirtualCircuitPublicPrefixes")]
    public interface ICoreVirtualCircuitPublicPrefixes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#cidr_block CoreVirtualCircuit#cidr_block}.</summary>
        [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        string CidrBlock
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreVirtualCircuitPublicPrefixes), fullyQualifiedName: "oci.coreVirtualCircuit.CoreVirtualCircuitPublicPrefixes")]
        internal sealed class _Proxy : DeputyBase, oci.CoreVirtualCircuit.ICoreVirtualCircuitPublicPrefixes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#cidr_block CoreVirtualCircuit#cidr_block}.</summary>
            [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}")]
            public string CidrBlock
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
