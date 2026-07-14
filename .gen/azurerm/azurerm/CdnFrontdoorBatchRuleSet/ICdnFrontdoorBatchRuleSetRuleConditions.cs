using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorBatchRuleSet
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorBatchRuleSetRuleConditions), fullyQualifiedName: "azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditions")]
    public interface ICdnFrontdoorBatchRuleSetRuleConditions
    {
        /// <summary>client_port block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#client_port CdnFrontdoorBatchRuleSet#client_port}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsClientPort" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "clientPort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsClientPort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#device_type CdnFrontdoorBatchRuleSet#device_type}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsDeviceType" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "deviceType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsDeviceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#host_name CdnFrontdoorBatchRuleSet#host_name}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsHostName" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "hostName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsHostName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#http_version CdnFrontdoorBatchRuleSet#http_version}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsHttpVersion" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "httpVersion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsHttpVersion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#post_argument CdnFrontdoorBatchRuleSet#post_argument}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsPostArgument" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "postArgument", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsPostArgument\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#query_string CdnFrontdoorBatchRuleSet#query_string}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsQueryString" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#remote_address CdnFrontdoorBatchRuleSet#remote_address}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRemoteAddress" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "remoteAddress", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRemoteAddress\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#request_body CdnFrontdoorBatchRuleSet#request_body}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestBody" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requestBody", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#request_cookies CdnFrontdoorBatchRuleSet#request_cookies}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestCookies" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requestCookies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestCookies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#request_file_extension CdnFrontdoorBatchRuleSet#request_file_extension}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestFileExtension" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requestFileExtension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestFileExtension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#request_filename CdnFrontdoorBatchRuleSet#request_filename}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestFilename" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requestFilename", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestFilename\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#request_header CdnFrontdoorBatchRuleSet#request_header}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestHeader" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requestHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#request_method CdnFrontdoorBatchRuleSet#request_method}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestMethod" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requestMethod", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestMethod\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#request_path CdnFrontdoorBatchRuleSet#request_path}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestPath" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requestPath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#request_scheme CdnFrontdoorBatchRuleSet#request_scheme}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestScheme" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requestScheme", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestScheme\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#request_url CdnFrontdoorBatchRuleSet#request_url}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestUrl" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requestUrl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#server_port CdnFrontdoorBatchRuleSet#server_port}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsServerPort" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "serverPort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsServerPort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#socket_address CdnFrontdoorBatchRuleSet#socket_address}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsSocketAddress" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "socketAddress", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsSocketAddress\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#ssl_protocol CdnFrontdoorBatchRuleSet#ssl_protocol}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsSslProtocol" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "sslProtocol", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsSslProtocol\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SslProtocol
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorBatchRuleSetRuleConditions), fullyQualifiedName: "azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditions")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>client_port block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#client_port CdnFrontdoorBatchRuleSet#client_port}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsClientPort" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientPort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsClientPort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ClientPort
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>device_type block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#device_type CdnFrontdoorBatchRuleSet#device_type}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsDeviceType" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deviceType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsDeviceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DeviceType
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>host_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#host_name CdnFrontdoorBatchRuleSet#host_name}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsHostName" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsHostName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HostName
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>http_version block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#http_version CdnFrontdoorBatchRuleSet#http_version}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsHttpVersion" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpVersion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsHttpVersion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HttpVersion
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>post_argument block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#post_argument CdnFrontdoorBatchRuleSet#post_argument}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsPostArgument" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "postArgument", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsPostArgument\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PostArgument
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>query_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#query_string CdnFrontdoorBatchRuleSet#query_string}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsQueryString" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? QueryString
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>remote_address block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#remote_address CdnFrontdoorBatchRuleSet#remote_address}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRemoteAddress" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "remoteAddress", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRemoteAddress\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RemoteAddress
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_body block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#request_body CdnFrontdoorBatchRuleSet#request_body}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestBody" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestBody", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestBody
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_cookies block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#request_cookies CdnFrontdoorBatchRuleSet#request_cookies}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestCookies" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestCookies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestCookies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestCookies
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_file_extension block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#request_file_extension CdnFrontdoorBatchRuleSet#request_file_extension}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestFileExtension" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestFileExtension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestFileExtension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestFileExtension
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_filename block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#request_filename CdnFrontdoorBatchRuleSet#request_filename}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestFilename" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestFilename", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestFilename\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestFilename
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#request_header CdnFrontdoorBatchRuleSet#request_header}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestHeader" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestHeader
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_method block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#request_method CdnFrontdoorBatchRuleSet#request_method}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestMethod" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestMethod", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestMethod\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestMethod
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#request_path CdnFrontdoorBatchRuleSet#request_path}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestPath" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestPath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestPath
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_scheme block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#request_scheme CdnFrontdoorBatchRuleSet#request_scheme}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestScheme" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestScheme", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestScheme\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestScheme
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_url block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#request_url CdnFrontdoorBatchRuleSet#request_url}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestUrl" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestUrl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestUrl
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>server_port block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#server_port CdnFrontdoorBatchRuleSet#server_port}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsServerPort" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serverPort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsServerPort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ServerPort
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>socket_address block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#socket_address CdnFrontdoorBatchRuleSet#socket_address}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsSocketAddress" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "socketAddress", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsSocketAddress\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SocketAddress
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ssl_protocol block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cdn_frontdoor_batch_rule_set#ssl_protocol CdnFrontdoorBatchRuleSet#ssl_protocol}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsSslProtocol" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sslProtocol", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsSslProtocol\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SslProtocol
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
