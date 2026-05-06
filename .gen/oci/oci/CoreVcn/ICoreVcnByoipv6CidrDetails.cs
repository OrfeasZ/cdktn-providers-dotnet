using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVcn
{
    [JsiiInterface(nativeType: typeof(ICoreVcnByoipv6CidrDetails), fullyQualifiedName: "oci.coreVcn.CoreVcnByoipv6CidrDetails")]
    public interface ICoreVcnByoipv6CidrDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_vcn#byoipv6range_id CoreVcn#byoipv6range_id}.</summary>
        [JsiiProperty(name: "byoipv6RangeId", typeJson: "{\"primitive\":\"string\"}")]
        string Byoipv6RangeId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_vcn#ipv6cidr_block CoreVcn#ipv6cidr_block}.</summary>
        [JsiiProperty(name: "ipv6CidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        string Ipv6CidrBlock
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreVcnByoipv6CidrDetails), fullyQualifiedName: "oci.coreVcn.CoreVcnByoipv6CidrDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CoreVcn.ICoreVcnByoipv6CidrDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_vcn#byoipv6range_id CoreVcn#byoipv6range_id}.</summary>
            [JsiiProperty(name: "byoipv6RangeId", typeJson: "{\"primitive\":\"string\"}")]
            public string Byoipv6RangeId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_vcn#ipv6cidr_block CoreVcn#ipv6cidr_block}.</summary>
            [JsiiProperty(name: "ipv6CidrBlock", typeJson: "{\"primitive\":\"string\"}")]
            public string Ipv6CidrBlock
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
