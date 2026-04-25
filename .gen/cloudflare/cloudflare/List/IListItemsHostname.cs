using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.List
{
    [JsiiInterface(nativeType: typeof(IListItemsHostname), fullyQualifiedName: "cloudflare.list.ListItemsHostname")]
    public interface IListItemsHostname
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#url_hostname List#url_hostname}.</summary>
        [JsiiProperty(name: "urlHostname", typeJson: "{\"primitive\":\"string\"}")]
        string UrlHostname
        {
            get;
        }

        /// <summary>Only applies to wildcard hostnames (e.g., *.example.com). When true (default), only subdomains are blocked. When false, both the root domain and subdomains are blocked.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#exclude_exact_hostname List#exclude_exact_hostname}
        /// </remarks>
        [JsiiProperty(name: "excludeExactHostname", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExcludeExactHostname
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IListItemsHostname), fullyQualifiedName: "cloudflare.list.ListItemsHostname")]
        internal sealed class _Proxy : DeputyBase, cloudflare.List.IListItemsHostname
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#url_hostname List#url_hostname}.</summary>
            [JsiiProperty(name: "urlHostname", typeJson: "{\"primitive\":\"string\"}")]
            public string UrlHostname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Only applies to wildcard hostnames (e.g., *.example.com). When true (default), only subdomains are blocked. When false, both the root domain and subdomains are blocked.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#exclude_exact_hostname List#exclude_exact_hostname}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "excludeExactHostname", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExcludeExactHostname
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
