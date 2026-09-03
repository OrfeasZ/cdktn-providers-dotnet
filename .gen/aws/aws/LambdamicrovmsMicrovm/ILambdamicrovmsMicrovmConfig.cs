using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdamicrovmsMicrovm
{
    [JsiiInterface(nativeType: typeof(ILambdamicrovmsMicrovmConfig), fullyQualifiedName: "aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmConfig")]
    public interface ILambdamicrovmsMicrovmConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#image_arn LambdamicrovmsMicrovm#image_arn}.</summary>
        [JsiiProperty(name: "imageArn", typeJson: "{\"primitive\":\"string\"}")]
        string ImageArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#egress_network_connectors LambdamicrovmsMicrovm#egress_network_connectors}.</summary>
        [JsiiProperty(name: "egressNetworkConnectors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EgressNetworkConnectors
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#execution_role_arn LambdamicrovmsMicrovm#execution_role_arn}.</summary>
        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExecutionRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>idle_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#idle_policy LambdamicrovmsMicrovm#idle_policy}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmIdlePolicy" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "idlePolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmIdlePolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IdlePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#image_version LambdamicrovmsMicrovm#image_version}.</summary>
        [JsiiProperty(name: "imageVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#ingress_network_connectors LambdamicrovmsMicrovm#ingress_network_connectors}.</summary>
        [JsiiProperty(name: "ingressNetworkConnectors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IngressNetworkConnectors
        {
            get
            {
                return null;
            }
        }

        /// <summary>logging block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#logging LambdamicrovmsMicrovm#logging}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLogging" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "logging", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmLogging\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Logging
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#maximum_duration_in_seconds LambdamicrovmsMicrovm#maximum_duration_in_seconds}.</summary>
        [JsiiProperty(name: "maximumDurationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumDurationInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#region LambdamicrovmsMicrovm#region}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#run_hook_payload LambdamicrovmsMicrovm#run_hook_payload}.</summary>
        [JsiiProperty(name: "runHookPayload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RunHookPayload
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#timeouts LambdamicrovmsMicrovm#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdamicrovmsMicrovmConfig), fullyQualifiedName: "aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#image_arn LambdamicrovmsMicrovm#image_arn}.</summary>
            [JsiiProperty(name: "imageArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ImageArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#egress_network_connectors LambdamicrovmsMicrovm#egress_network_connectors}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "egressNetworkConnectors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EgressNetworkConnectors
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#execution_role_arn LambdamicrovmsMicrovm#execution_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExecutionRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>idle_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#idle_policy LambdamicrovmsMicrovm#idle_policy}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmIdlePolicy" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idlePolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmIdlePolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IdlePolicy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#image_version LambdamicrovmsMicrovm#image_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#ingress_network_connectors LambdamicrovmsMicrovm#ingress_network_connectors}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ingressNetworkConnectors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IngressNetworkConnectors
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>logging block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#logging LambdamicrovmsMicrovm#logging}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLogging" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logging", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmLogging\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Logging
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#maximum_duration_in_seconds LambdamicrovmsMicrovm#maximum_duration_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumDurationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumDurationInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#region LambdamicrovmsMicrovm#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#run_hook_payload LambdamicrovmsMicrovm#run_hook_payload}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "runHookPayload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RunHookPayload
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#timeouts LambdamicrovmsMicrovm#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmTimeouts\"}", isOptional: true)]
            public aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
