using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunctionScalingConfig
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/lambda_function_scaling_config aws_lambda_function_scaling_config}.</summary>
    [JsiiClass(nativeType: typeof(aws.LambdaFunctionScalingConfig.LambdaFunctionScalingConfig), fullyQualifiedName: "aws.lambdaFunctionScalingConfig.LambdaFunctionScalingConfig", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lambdaFunctionScalingConfig.LambdaFunctionScalingConfigConfig\"}}]")]
    public class LambdaFunctionScalingConfig : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/lambda_function_scaling_config aws_lambda_function_scaling_config} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LambdaFunctionScalingConfig(Constructs.Construct scope, string id, aws.LambdaFunctionScalingConfig.ILambdaFunctionScalingConfigConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.LambdaFunctionScalingConfig.ILambdaFunctionScalingConfigConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaFunctionScalingConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaFunctionScalingConfig(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a LambdaFunctionScalingConfig resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LambdaFunctionScalingConfig to import.</param>
        /// <param name="importFromId">The id of the existing LambdaFunctionScalingConfig that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LambdaFunctionScalingConfig to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LambdaFunctionScalingConfig to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/lambda_function_scaling_config#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LambdaFunctionScalingConfig that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LambdaFunctionScalingConfig to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.LambdaFunctionScalingConfig.LambdaFunctionScalingConfig), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdaFunctionScalingConfig.ILambdaFunctionScalingConfigFunctionScalingConfig" />)[]</param>
        [JsiiMethod(name: "putFunctionScalingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdaFunctionScalingConfig.LambdaFunctionScalingConfigFunctionScalingConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFunctionScalingConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.LambdaFunctionScalingConfig.ILambdaFunctionScalingConfigFunctionScalingConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdaFunctionScalingConfig.ILambdaFunctionScalingConfigFunctionScalingConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdaFunctionScalingConfig.ILambdaFunctionScalingConfigFunctionScalingConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaFunctionScalingConfig.LambdaFunctionScalingConfigTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.LambdaFunctionScalingConfig.ILambdaFunctionScalingConfigTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaFunctionScalingConfig.ILambdaFunctionScalingConfigTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFunctionScalingConfig")]
        public virtual void ResetFunctionScalingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.LambdaFunctionScalingConfig.LambdaFunctionScalingConfig))!;

        [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "functionScalingConfig", typeJson: "{\"fqn\":\"aws.lambdaFunctionScalingConfig.LambdaFunctionScalingConfigFunctionScalingConfigList\"}")]
        public virtual aws.LambdaFunctionScalingConfig.LambdaFunctionScalingConfigFunctionScalingConfigList FunctionScalingConfig
        {
            get => GetInstanceProperty<aws.LambdaFunctionScalingConfig.LambdaFunctionScalingConfigFunctionScalingConfigList>()!;
        }

        [JsiiProperty(name: "functionState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lambdaFunctionScalingConfig.LambdaFunctionScalingConfigTimeoutsOutputReference\"}")]
        public virtual aws.LambdaFunctionScalingConfig.LambdaFunctionScalingConfigTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.LambdaFunctionScalingConfig.LambdaFunctionScalingConfigTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FunctionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdaFunctionScalingConfig.ILambdaFunctionScalingConfigFunctionScalingConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "functionScalingConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdaFunctionScalingConfig.LambdaFunctionScalingConfigFunctionScalingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FunctionScalingConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "qualifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QualifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.LambdaFunctionScalingConfig.ILambdaFunctionScalingConfigTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.lambdaFunctionScalingConfig.LambdaFunctionScalingConfigTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "qualifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Qualifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
