using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ListItem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.listItem.ListItemHostname")]
    public class ListItemHostname : cloudflare.ListItem.IListItemHostname
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/list_item#url_hostname ListItem#url_hostname}.</summary>
        [JsiiProperty(name: "urlHostname", typeJson: "{\"primitive\":\"string\"}")]
        public string UrlHostname
        {
            get;
            set;
        }
    }
}
