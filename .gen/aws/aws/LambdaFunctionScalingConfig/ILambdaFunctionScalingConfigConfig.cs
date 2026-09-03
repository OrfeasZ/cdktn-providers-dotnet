using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunctionScalingConfig
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionScalingConfigConfig), fullyQualifiedName: "aws.lambdaFunctionScalingConfig.LambdaFunctionScalingConfigConfig")]
    public interface ILambdaFunctionScalingConfigConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Name or ARN of the Lambda function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambda_function_scaling_config#function_name LambdaFunctionScalingConfig#function_name}
        /// </remarks>
        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
        string FunctionName
        {
            get;
        }

        /// <summary>Qualifier for the scaling configuration. Valid values: $LATEST.PUBLISHED or a numeric version number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambda_function_scaling_config#qualifier LambdaFunctionScalingConfig#qualifier}
        /// </remarks>
        [JsiiProperty(name: "qualifier", typeJson: "{\"primitive\":\"string\"}")]
        string Qualifier
        {
            get;
        }

        /// <summary>function_scaling_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambda_function_scaling_config#function_scaling_config LambdaFunctionScalingConfig#function_scaling_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdaFunctionScalingConfig.ILambdaFunctionScalingConfigFunctionScalingConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "functionScalingConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdaFunctionScalingConfig.LambdaFunctionScalingConfigFunctionScalingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FunctionScalingConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambda_function_scaling_config#region LambdaFunctionScalingConfig#region}
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambda_function_scaling_config#timeouts LambdaFunctionScalingConfig#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lambdaFunctionScalingConfig.LambdaFunctionScalingConfigTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LambdaFunctionScalingConfig.ILambdaFunctionScalingConfigTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionScalingConfigConfig), fullyQualifiedName: "aws.lambdaFunctionScalingConfig.LambdaFunctionScalingConfigConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaFunctionScalingConfig.ILambdaFunctionScalingConfigConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name or ARN of the Lambda function.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambda_function_scaling_config#function_name LambdaFunctionScalingConfig#function_name}
            /// </remarks>
            [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
            public string FunctionName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Qualifier for the scaling configuration. Valid values: $LATEST.PUBLISHED or a numeric version number.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambda_function_scaling_config#qualifier LambdaFunctionScalingConfig#qualifier}
            /// </remarks>
            [JsiiProperty(name: "qualifier", typeJson: "{\"primitive\":\"string\"}")]
            public string Qualifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>function_scaling_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambda_function_scaling_config#function_scaling_config LambdaFunctionScalingConfig#function_scaling_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdaFunctionScalingConfig.ILambdaFunctionScalingConfigFunctionScalingConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "functionScalingConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdaFunctionScalingConfig.LambdaFunctionScalingConfigFunctionScalingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FunctionScalingConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambda_function_scaling_config#region LambdaFunctionScalingConfig#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambda_function_scaling_config#timeouts LambdaFunctionScalingConfig#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lambdaFunctionScalingConfig.LambdaFunctionScalingConfigTimeouts\"}", isOptional: true)]
            public aws.LambdaFunctionScalingConfig.ILambdaFunctionScalingConfigTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.LambdaFunctionScalingConfig.ILambdaFunctionScalingConfigTimeouts?>();
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
