using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListenerRule
{
    [JsiiInterface(nativeType: typeof(IDataAwsLbListenerRuleCondition), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleCondition")]
    public interface IDataAwsLbListenerRuleCondition
    {
        /// <summary>host_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#host_header DataAwsLbListenerRule#host_header}
        /// </remarks>
        [JsiiProperty(name: "hostHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionHostHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HostHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#http_header DataAwsLbListenerRule#http_header}
        /// </remarks>
        [JsiiProperty(name: "httpHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionHttpHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HttpHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_request_method block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#http_request_method DataAwsLbListenerRule#http_request_method}
        /// </remarks>
        [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionHttpRequestMethod\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HttpRequestMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>path_pattern block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#path_pattern DataAwsLbListenerRule#path_pattern}
        /// </remarks>
        [JsiiProperty(name: "pathPattern", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionPathPattern\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PathPattern
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#query_string DataAwsLbListenerRule#query_string}
        /// </remarks>
        [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_ip block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#source_ip DataAwsLbListenerRule#source_ip}
        /// </remarks>
        [JsiiProperty(name: "sourceIp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionSourceIp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SourceIp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsLbListenerRuleCondition), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleCondition")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>host_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#host_header DataAwsLbListenerRule#host_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionHostHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HostHeader
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>http_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#http_header DataAwsLbListenerRule#http_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionHttpHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HttpHeader
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>http_request_method block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#http_request_method DataAwsLbListenerRule#http_request_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionHttpRequestMethod\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HttpRequestMethod
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>path_pattern block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#path_pattern DataAwsLbListenerRule#path_pattern}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pathPattern", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionPathPattern\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PathPattern
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>query_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#query_string DataAwsLbListenerRule#query_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? QueryString
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>source_ip block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#source_ip DataAwsLbListenerRule#source_ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceIp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionSourceIp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SourceIp
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
