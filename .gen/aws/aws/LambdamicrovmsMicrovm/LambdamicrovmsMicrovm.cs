using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdamicrovmsMicrovm
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm aws_lambdamicrovms_microvm}.</summary>
    [JsiiClass(nativeType: typeof(aws.LambdamicrovmsMicrovm.LambdamicrovmsMicrovm), fullyQualifiedName: "aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovm", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmConfig\"}}]")]
    public class LambdamicrovmsMicrovm : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm aws_lambdamicrovms_microvm} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LambdamicrovmsMicrovm(Constructs.Construct scope, string id, aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdamicrovmsMicrovm(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdamicrovmsMicrovm(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a LambdamicrovmsMicrovm resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LambdamicrovmsMicrovm to import.</param>
        /// <param name="importFromId">The id of the existing LambdamicrovmsMicrovm that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LambdamicrovmsMicrovm to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LambdamicrovmsMicrovm to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LambdamicrovmsMicrovm that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LambdamicrovmsMicrovm to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.LambdamicrovmsMicrovm.LambdamicrovmsMicrovm), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmIdlePolicy" />)[]</param>
        [JsiiMethod(name: "putIdlePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmIdlePolicy\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIdlePolicy(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmIdlePolicy[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmIdlePolicy).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmIdlePolicy).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLogging" />)[]</param>
        [JsiiMethod(name: "putLogging", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmLogging\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLogging(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLogging[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLogging).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLogging).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEgressNetworkConnectors")]
        public virtual void ResetEgressNetworkConnectors()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExecutionRoleArn")]
        public virtual void ResetExecutionRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdlePolicy")]
        public virtual void ResetIdlePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageVersion")]
        public virtual void ResetImageVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIngressNetworkConnectors")]
        public virtual void ResetIngressNetworkConnectors()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogging")]
        public virtual void ResetLogging()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumDurationInSeconds")]
        public virtual void ResetMaximumDurationInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunHookPayload")]
        public virtual void ResetRunHookPayload()
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
        = GetStaticProperty<string>(typeof(aws.LambdamicrovmsMicrovm.LambdamicrovmsMicrovm))!;

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idlePolicy", typeJson: "{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmIdlePolicyList\"}")]
        public virtual aws.LambdamicrovmsMicrovm.LambdamicrovmsMicrovmIdlePolicyList IdlePolicy
        {
            get => GetInstanceProperty<aws.LambdamicrovmsMicrovm.LambdamicrovmsMicrovmIdlePolicyList>()!;
        }

        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmLoggingList\"}")]
        public virtual aws.LambdamicrovmsMicrovm.LambdamicrovmsMicrovmLoggingList Logging
        {
            get => GetInstanceProperty<aws.LambdamicrovmsMicrovm.LambdamicrovmsMicrovmLoggingList>()!;
        }

        [JsiiProperty(name: "microvmId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MicrovmId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmTimeoutsOutputReference\"}")]
        public virtual aws.LambdamicrovmsMicrovm.LambdamicrovmsMicrovmTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.LambdamicrovmsMicrovm.LambdamicrovmsMicrovmTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "egressNetworkConnectorsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? EgressNetworkConnectorsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutionRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmIdlePolicy" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idlePolicyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmIdlePolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IdlePolicyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ingressNetworkConnectorsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IngressNetworkConnectorsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLogging" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "loggingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmLogging\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LoggingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumDurationInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumDurationInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runHookPayloadInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RunHookPayloadInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "egressNetworkConnectors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EgressNetworkConnectors
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ingressNetworkConnectors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IngressNetworkConnectors
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumDurationInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumDurationInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runHookPayload", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RunHookPayload
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
