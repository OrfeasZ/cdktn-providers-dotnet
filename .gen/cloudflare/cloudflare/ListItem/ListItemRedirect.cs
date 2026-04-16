using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ListItem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.listItem.ListItemRedirect")]
    public class ListItemRedirect : cloudflare.ListItem.IListItemRedirect
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/list_item#source_url ListItem#source_url}.</summary>
        [JsiiProperty(name: "sourceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/list_item#target_url ListItem#target_url}.</summary>
        [JsiiProperty(name: "targetUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetUrl
        {
            get;
            set;
        }

        private object? _includeSubdomains;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/list_item#include_subdomains ListItem#include_subdomains}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeSubdomains", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeSubdomains
        {
            get => _includeSubdomains;
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
                _includeSubdomains = value;
            }
        }

        private object? _preservePathSuffix;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/list_item#preserve_path_suffix ListItem#preserve_path_suffix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preservePathSuffix", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? PreservePathSuffix
        {
            get => _preservePathSuffix;
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
                _preservePathSuffix = value;
            }
        }

        private object? _preserveQueryString;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/list_item#preserve_query_string ListItem#preserve_query_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preserveQueryString", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? PreserveQueryString
        {
            get => _preserveQueryString;
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
                _preserveQueryString = value;
            }
        }

        /// <summary>Available values: 301, 302, 307, 308.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/list_item#status_code ListItem#status_code}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StatusCode
        {
            get;
            set;
        }

        private object? _subpathMatching;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/list_item#subpath_matching ListItem#subpath_matching}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subpathMatching", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SubpathMatching
        {
            get => _subpathMatching;
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
                _subpathMatching = value;
            }
        }
    }
}
