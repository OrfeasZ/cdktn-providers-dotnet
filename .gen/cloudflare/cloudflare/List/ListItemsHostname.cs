using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.List
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.list.ListItemsHostname")]
    public class ListItemsHostname : cloudflare.List.IListItemsHostname
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#url_hostname List#url_hostname}.</summary>
        [JsiiProperty(name: "urlHostname", typeJson: "{\"primitive\":\"string\"}")]
        public string UrlHostname
        {
            get;
            set;
        }

        private object? _excludeExactHostname;

        /// <summary>Only applies to wildcard hostnames (e.g., *.example.com). When true (default), only subdomains are blocked. When false, both the root domain and subdomains are blocked.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list#exclude_exact_hostname List#exclude_exact_hostname}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "excludeExactHostname", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ExcludeExactHostname
        {
            get => _excludeExactHostname;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _excludeExactHostname = value;
            }
        }
    }
}
