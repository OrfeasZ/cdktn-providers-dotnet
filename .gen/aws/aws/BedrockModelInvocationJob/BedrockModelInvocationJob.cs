using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockModelInvocationJob
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job aws_bedrock_model_invocation_job}.</summary>
    [JsiiClass(nativeType: typeof(aws.BedrockModelInvocationJob.BedrockModelInvocationJob), fullyQualifiedName: "aws.bedrockModelInvocationJob.BedrockModelInvocationJob", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.bedrockModelInvocationJob.BedrockModelInvocationJobConfig\"}}]")]
    public class BedrockModelInvocationJob : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job aws_bedrock_model_invocation_job} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BedrockModelInvocationJob(Constructs.Construct scope, string id, aws.BedrockModelInvocationJob.IBedrockModelInvocationJobConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.BedrockModelInvocationJob.IBedrockModelInvocationJobConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BedrockModelInvocationJob(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BedrockModelInvocationJob(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a BedrockModelInvocationJob resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the BedrockModelInvocationJob to import.</param>
        /// <param name="importFromId">The id of the existing BedrockModelInvocationJob that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the BedrockModelInvocationJob to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the BedrockModelInvocationJob to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing BedrockModelInvocationJob that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the BedrockModelInvocationJob to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.BedrockModelInvocationJob.BedrockModelInvocationJob), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockModelInvocationJob.IBedrockModelInvocationJobInputDataConfig" />)[]</param>
        [JsiiMethod(name: "putInputDataConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockModelInvocationJob.BedrockModelInvocationJobInputDataConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInputDataConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BedrockModelInvocationJob.IBedrockModelInvocationJobInputDataConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockModelInvocationJob.IBedrockModelInvocationJobInputDataConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockModelInvocationJob.IBedrockModelInvocationJobInputDataConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockModelInvocationJob.IBedrockModelInvocationJobOutputDataConfig" />)[]</param>
        [JsiiMethod(name: "putOutputDataConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockModelInvocationJob.BedrockModelInvocationJobOutputDataConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOutputDataConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BedrockModelInvocationJob.IBedrockModelInvocationJobOutputDataConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockModelInvocationJob.IBedrockModelInvocationJobOutputDataConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockModelInvocationJob.IBedrockModelInvocationJobOutputDataConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.bedrockModelInvocationJob.BedrockModelInvocationJobTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.BedrockModelInvocationJob.IBedrockModelInvocationJobTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BedrockModelInvocationJob.IBedrockModelInvocationJobTimeouts)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockModelInvocationJob.IBedrockModelInvocationJobVpcConfig" />)[]</param>
        [JsiiMethod(name: "putVpcConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockModelInvocationJob.BedrockModelInvocationJobVpcConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVpcConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BedrockModelInvocationJob.IBedrockModelInvocationJobVpcConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockModelInvocationJob.IBedrockModelInvocationJobVpcConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockModelInvocationJob.IBedrockModelInvocationJobVpcConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInputDataConfig")]
        public virtual void ResetInputDataConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputDataConfig")]
        public virtual void ResetOutputDataConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkipDestroy")]
        public virtual void ResetSkipDestroy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeoutDurationInHours")]
        public virtual void ResetTimeoutDurationInHours()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcConfig")]
        public virtual void ResetVpcConfig()
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
        = GetStaticProperty<string>(typeof(aws.BedrockModelInvocationJob.BedrockModelInvocationJob))!;

        [JsiiProperty(name: "endTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errorRecordCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ErrorRecordCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "inputDataConfig", typeJson: "{\"fqn\":\"aws.bedrockModelInvocationJob.BedrockModelInvocationJobInputDataConfigList\"}")]
        public virtual aws.BedrockModelInvocationJob.BedrockModelInvocationJobInputDataConfigList InputDataConfig
        {
            get => GetInstanceProperty<aws.BedrockModelInvocationJob.BedrockModelInvocationJobInputDataConfigList>()!;
        }

        [JsiiProperty(name: "jobArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobExpirationTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobExpirationTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelInvocationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelInvocationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outputDataConfig", typeJson: "{\"fqn\":\"aws.bedrockModelInvocationJob.BedrockModelInvocationJobOutputDataConfigList\"}")]
        public virtual aws.BedrockModelInvocationJob.BedrockModelInvocationJobOutputDataConfigList OutputDataConfig
        {
            get => GetInstanceProperty<aws.BedrockModelInvocationJob.BedrockModelInvocationJobOutputDataConfigList>()!;
        }

        [JsiiProperty(name: "processedRecordCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProcessedRecordCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "submitTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubmitTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "successRecordCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SuccessRecordCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.bedrockModelInvocationJob.BedrockModelInvocationJobTimeoutsOutputReference\"}")]
        public virtual aws.BedrockModelInvocationJob.BedrockModelInvocationJobTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.BedrockModelInvocationJob.BedrockModelInvocationJobTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "totalRecordCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalRecordCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.bedrockModelInvocationJob.BedrockModelInvocationJobVpcConfigList\"}")]
        public virtual aws.BedrockModelInvocationJob.BedrockModelInvocationJobVpcConfigList VpcConfig
        {
            get => GetInstanceProperty<aws.BedrockModelInvocationJob.BedrockModelInvocationJobVpcConfigList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockModelInvocationJob.IBedrockModelInvocationJobInputDataConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inputDataConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockModelInvocationJob.BedrockModelInvocationJobInputDataConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InputDataConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockModelInvocationJob.IBedrockModelInvocationJobOutputDataConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outputDataConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockModelInvocationJob.BedrockModelInvocationJobOutputDataConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OutputDataConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "skipDestroyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SkipDestroyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutDurationInHoursInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TimeoutDurationInHoursInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.BedrockModelInvocationJob.IBedrockModelInvocationJobTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.bedrockModelInvocationJob.BedrockModelInvocationJobTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockModelInvocationJob.IBedrockModelInvocationJobVpcConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockModelInvocationJob.BedrockModelInvocationJobVpcConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VpcConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelId
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

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "skipDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object SkipDestroy
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "timeoutDurationInHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimeoutDurationInHours
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
