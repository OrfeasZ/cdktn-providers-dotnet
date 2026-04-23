using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListenerRule
{
    [JsiiInterface(nativeType: typeof(IDataAwsLbListenerRuleConfig), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConfig")]
    public interface IDataAwsLbListenerRuleConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#action DataAwsLbListenerRule#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#arn DataAwsLbListenerRule#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Arn
        {
            get
            {
                return null;
            }
        }

        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#condition DataAwsLbListenerRule#condition}
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Condition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#listener_arn DataAwsLbListenerRule#listener_arn}.</summary>
        [JsiiProperty(name: "listenerArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ListenerArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#priority DataAwsLbListenerRule#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#region DataAwsLbListenerRule#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>transform block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#transform DataAwsLbListenerRule#transform}
        /// </remarks>
        [JsiiProperty(name: "transform", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransform\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Transform
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsLbListenerRuleConfig), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConfig")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#action DataAwsLbListenerRule#action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Action
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#arn DataAwsLbListenerRule#arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Arn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#condition DataAwsLbListenerRule#condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "condition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Condition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#listener_arn DataAwsLbListenerRule#listener_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "listenerArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ListenerArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#priority DataAwsLbListenerRule#priority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#region DataAwsLbListenerRule#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>transform block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#transform DataAwsLbListenerRule#transform}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transform", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransform\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Transform
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
