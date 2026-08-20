using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorRule
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorRuleConditions), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditions")]
    public interface ICdnFrontdoorRuleConditions
    {
        /// <summary>client_port block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#client_port CdnFrontdoorRule#client_port}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsClientPort" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "clientPort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsClientPort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ClientPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>device_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#device_type CdnFrontdoorRule#device_type}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsDeviceType" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "deviceType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsDeviceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeviceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>host_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#host_name CdnFrontdoorRule#host_name}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsHostName" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "hostName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsHostName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HostName
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_version block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#http_version CdnFrontdoorRule#http_version}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsHttpVersion" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "httpVersion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsHttpVersion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HttpVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>post_argument block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#post_argument CdnFrontdoorRule#post_argument}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsPostArgument" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "postArgument", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsPostArgument\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PostArgument
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#query_string CdnFrontdoorRule#query_string}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsQueryString" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>remote_address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#remote_address CdnFrontdoorRule#remote_address}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRemoteAddress" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "remoteAddress", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRemoteAddress\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RemoteAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>request_body block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#request_body CdnFrontdoorRule#request_body}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestBody" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requestBody", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestBody
        {
            get
            {
                return null;
            }
        }

        /// <summary>request_cookies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#request_cookies CdnFrontdoorRule#request_cookies}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestCookies" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requestCookies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestCookies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestCookies
        {
            get
            {
                return null;
            }
        }

        /// <summary>request_file_extension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#request_file_extension CdnFrontdoorRule#request_file_extension}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestFileExtension" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requestFileExtension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestFileExtension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestFileExtension
        {
            get
            {
                return null;
            }
        }

        /// <summary>request_filename block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#request_filename CdnFrontdoorRule#request_filename}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestFilename" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requestFilename", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestFilename\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestFilename
        {
            get
            {
                return null;
            }
        }

        /// <summary>request_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#request_header CdnFrontdoorRule#request_header}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestHeader" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requestHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>request_method block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#request_method CdnFrontdoorRule#request_method}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestMethod" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requestMethod", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestMethod\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>request_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#request_path CdnFrontdoorRule#request_path}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestPath" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requestPath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>request_scheme block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#request_scheme CdnFrontdoorRule#request_scheme}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestScheme" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requestScheme", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestScheme\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestScheme
        {
            get
            {
                return null;
            }
        }

        /// <summary>request_url block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#request_url CdnFrontdoorRule#request_url}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestUrl" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requestUrl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>server_port block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#server_port CdnFrontdoorRule#server_port}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsServerPort" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "serverPort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsServerPort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ServerPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>socket_address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#socket_address CdnFrontdoorRule#socket_address}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsSocketAddress" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "socketAddress", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsSocketAddress\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SocketAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>ssl_protocol block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#ssl_protocol CdnFrontdoorRule#ssl_protocol}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsSslProtocol" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "sslProtocol", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsSslProtocol\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SslProtocol
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorRuleConditions), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditions")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>client_port block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#client_port CdnFrontdoorRule#client_port}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsClientPort" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientPort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsClientPort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ClientPort
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>device_type block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#device_type CdnFrontdoorRule#device_type}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsDeviceType" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deviceType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsDeviceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DeviceType
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>host_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#host_name CdnFrontdoorRule#host_name}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsHostName" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsHostName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HostName
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>http_version block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#http_version CdnFrontdoorRule#http_version}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsHttpVersion" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpVersion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsHttpVersion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HttpVersion
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>post_argument block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#post_argument CdnFrontdoorRule#post_argument}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsPostArgument" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "postArgument", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsPostArgument\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PostArgument
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>query_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#query_string CdnFrontdoorRule#query_string}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsQueryString" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? QueryString
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>remote_address block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#remote_address CdnFrontdoorRule#remote_address}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRemoteAddress" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "remoteAddress", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRemoteAddress\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RemoteAddress
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_body block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#request_body CdnFrontdoorRule#request_body}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestBody" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestBody", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestBody
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_cookies block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#request_cookies CdnFrontdoorRule#request_cookies}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestCookies" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestCookies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestCookies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestCookies
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_file_extension block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#request_file_extension CdnFrontdoorRule#request_file_extension}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestFileExtension" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestFileExtension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestFileExtension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestFileExtension
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_filename block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#request_filename CdnFrontdoorRule#request_filename}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestFilename" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestFilename", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestFilename\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestFilename
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#request_header CdnFrontdoorRule#request_header}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestHeader" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestHeader
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_method block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#request_method CdnFrontdoorRule#request_method}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestMethod" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestMethod", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestMethod\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestMethod
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#request_path CdnFrontdoorRule#request_path}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestPath" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestPath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestPath
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_scheme block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#request_scheme CdnFrontdoorRule#request_scheme}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestScheme" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestScheme", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestScheme\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestScheme
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_url block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#request_url CdnFrontdoorRule#request_url}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestUrl" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestUrl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestUrl
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>server_port block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#server_port CdnFrontdoorRule#server_port}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsServerPort" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serverPort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsServerPort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ServerPort
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>socket_address block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#socket_address CdnFrontdoorRule#socket_address}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsSocketAddress" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "socketAddress", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsSocketAddress\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SocketAddress
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ssl_protocol block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/cdn_frontdoor_rule#ssl_protocol CdnFrontdoorRule#ssl_protocol}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsSslProtocol" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sslProtocol", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsSslProtocol\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SslProtocol
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
