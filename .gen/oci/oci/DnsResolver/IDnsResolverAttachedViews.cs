using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DnsResolver
{
    [JsiiInterface(nativeType: typeof(IDnsResolverAttachedViews), fullyQualifiedName: "oci.dnsResolver.DnsResolverAttachedViews")]
    public interface IDnsResolverAttachedViews
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_resolver#view_id DnsResolver#view_id}.</summary>
        [JsiiProperty(name: "viewId", typeJson: "{\"primitive\":\"string\"}")]
        string ViewId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDnsResolverAttachedViews), fullyQualifiedName: "oci.dnsResolver.DnsResolverAttachedViews")]
        internal sealed class _Proxy : DeputyBase, oci.DnsResolver.IDnsResolverAttachedViews
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_resolver#view_id DnsResolver#view_id}.</summary>
            [JsiiProperty(name: "viewId", typeJson: "{\"primitive\":\"string\"}")]
            public string ViewId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
