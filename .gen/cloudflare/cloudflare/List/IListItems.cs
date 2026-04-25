using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.List
{
    [JsiiInterface(nativeType: typeof(IListItems), fullyQualifiedName: "cloudflare.list.ListItems")]
    public interface IListItems
    {
        /// <summary>A non-negative 32 bit integer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#asn List#asn}
        /// </remarks>
        [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Asn
        {
            get
            {
                return null;
            }
        }

        /// <summary>An informative summary of the list item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#comment List#comment}
        /// </remarks>
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Comment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Valid characters for hostnames are ASCII(7) letters from a to z, the digits from 0 to 9, wildcards (*), and the hyphen (-).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#hostname List#hostname}
        /// </remarks>
        [JsiiProperty(name: "hostname", typeJson: "{\"fqn\":\"cloudflare.list.ListItemsHostname\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.List.IListItemsHostname? Hostname
        {
            get
            {
                return null;
            }
        }

        /// <summary>An IPv4 address, an IPv4 CIDR, an IPv6 address, or an IPv6 CIDR.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#ip List#ip}
        /// </remarks>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ip
        {
            get
            {
                return null;
            }
        }

        /// <summary>The definition of the redirect.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#redirect List#redirect}
        /// </remarks>
        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"cloudflare.list.ListItemsRedirect\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.List.IListItemsRedirect? Redirect
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IListItems), fullyQualifiedName: "cloudflare.list.ListItems")]
        internal sealed class _Proxy : DeputyBase, cloudflare.List.IListItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A non-negative 32 bit integer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#asn List#asn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Asn
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>An informative summary of the list item.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#comment List#comment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Comment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Valid characters for hostnames are ASCII(7) letters from a to z, the digits from 0 to 9, wildcards (*), and the hyphen (-).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#hostname List#hostname}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostname", typeJson: "{\"fqn\":\"cloudflare.list.ListItemsHostname\"}", isOptional: true)]
            public cloudflare.List.IListItemsHostname? Hostname
            {
                get => GetInstanceProperty<cloudflare.List.IListItemsHostname?>();
            }

            /// <summary>An IPv4 address, an IPv4 CIDR, an IPv6 address, or an IPv6 CIDR.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#ip List#ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ip
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The definition of the redirect.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#redirect List#redirect}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"cloudflare.list.ListItemsRedirect\"}", isOptional: true)]
            public cloudflare.List.IListItemsRedirect? Redirect
            {
                get => GetInstanceProperty<cloudflare.List.IListItemsRedirect?>();
            }
        }
    }
}
