using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ListItem
{
    [JsiiInterface(nativeType: typeof(IListItemHostname), fullyQualifiedName: "cloudflare.listItem.ListItemHostname")]
    public interface IListItemHostname
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/list_item#url_hostname ListItem#url_hostname}.</summary>
        [JsiiProperty(name: "urlHostname", typeJson: "{\"primitive\":\"string\"}")]
        string UrlHostname
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IListItemHostname), fullyQualifiedName: "cloudflare.listItem.ListItemHostname")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ListItem.IListItemHostname
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/list_item#url_hostname ListItem#url_hostname}.</summary>
            [JsiiProperty(name: "urlHostname", typeJson: "{\"primitive\":\"string\"}")]
            public string UrlHostname
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
