using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.List
{
    [JsiiByValue(fqn: "cloudflare.list.ListItems")]
    public class ListItems : cloudflare.List.IListItems
    {
        /// <summary>A non-negative 32 bit integer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#asn List#asn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Asn
        {
            get;
            set;
        }

        /// <summary>An informative summary of the list item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#comment List#comment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Comment
        {
            get;
            set;
        }

        /// <summary>Valid characters for hostnames are ASCII(7) letters from a to z, the digits from 0 to 9, wildcards (*), and the hyphen (-).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#hostname List#hostname}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostname", typeJson: "{\"fqn\":\"cloudflare.list.ListItemsHostname\"}", isOptional: true)]
        public cloudflare.List.IListItemsHostname? Hostname
        {
            get;
            set;
        }

        /// <summary>An IPv4 address, an IPv4 CIDR, an IPv6 address, or an IPv6 CIDR.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#ip List#ip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ip
        {
            get;
            set;
        }

        /// <summary>The definition of the redirect.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#redirect List#redirect}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"cloudflare.list.ListItemsRedirect\"}", isOptional: true)]
        public cloudflare.List.IListItemsRedirect? Redirect
        {
            get;
            set;
        }
    }
}
