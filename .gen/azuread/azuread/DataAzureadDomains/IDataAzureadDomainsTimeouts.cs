using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadDomains
{
    [JsiiInterface(nativeType: typeof(IDataAzureadDomainsTimeouts), fullyQualifiedName: "azuread.dataAzureadDomains.DataAzureadDomainsTimeouts")]
    public interface IDataAzureadDomainsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/domains#read DataAzureadDomains#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzureadDomainsTimeouts), fullyQualifiedName: "azuread.dataAzureadDomains.DataAzureadDomainsTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuread.DataAzureadDomains.IDataAzureadDomainsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/domains#read DataAzureadDomains#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
