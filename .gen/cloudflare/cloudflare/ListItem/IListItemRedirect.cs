using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ListItem
{
    [JsiiInterface(nativeType: typeof(IListItemRedirect), fullyQualifiedName: "cloudflare.listItem.ListItemRedirect")]
    public interface IListItemRedirect
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list_item#source_url ListItem#source_url}.</summary>
        [JsiiProperty(name: "sourceUrl", typeJson: "{\"primitive\":\"string\"}")]
        string SourceUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list_item#target_url ListItem#target_url}.</summary>
        [JsiiProperty(name: "targetUrl", typeJson: "{\"primitive\":\"string\"}")]
        string TargetUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list_item#include_subdomains ListItem#include_subdomains}.</summary>
        [JsiiProperty(name: "includeSubdomains", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeSubdomains
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list_item#preserve_path_suffix ListItem#preserve_path_suffix}.</summary>
        [JsiiProperty(name: "preservePathSuffix", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PreservePathSuffix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list_item#preserve_query_string ListItem#preserve_query_string}.</summary>
        [JsiiProperty(name: "preserveQueryString", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PreserveQueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Available values: 301, 302, 307, 308.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list_item#status_code ListItem#status_code}
        /// </remarks>
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StatusCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list_item#subpath_matching ListItem#subpath_matching}.</summary>
        [JsiiProperty(name: "subpathMatching", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SubpathMatching
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IListItemRedirect), fullyQualifiedName: "cloudflare.listItem.ListItemRedirect")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ListItem.IListItemRedirect
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list_item#source_url ListItem#source_url}.</summary>
            [JsiiProperty(name: "sourceUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list_item#target_url ListItem#target_url}.</summary>
            [JsiiProperty(name: "targetUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list_item#include_subdomains ListItem#include_subdomains}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeSubdomains", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeSubdomains
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list_item#preserve_path_suffix ListItem#preserve_path_suffix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preservePathSuffix", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PreservePathSuffix
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list_item#preserve_query_string ListItem#preserve_query_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preserveQueryString", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PreserveQueryString
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Available values: 301, 302, 307, 308.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list_item#status_code ListItem#status_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StatusCode
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/list_item#subpath_matching ListItem#subpath_matching}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subpathMatching", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SubpathMatching
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
