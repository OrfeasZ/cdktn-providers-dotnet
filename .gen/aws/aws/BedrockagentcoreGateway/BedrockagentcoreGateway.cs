using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGateway
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway aws_bedrockagentcore_gateway}.</summary>
    [JsiiClass(nativeType: typeof(aws.BedrockagentcoreGateway.BedrockagentcoreGateway), fullyQualifiedName: "aws.bedrockagentcoreGateway.BedrockagentcoreGateway", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayConfig\"}}]")]
    public class BedrockagentcoreGateway : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway aws_bedrockagentcore_gateway} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BedrockagentcoreGateway(Constructs.Construct scope, string id, aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BedrockagentcoreGateway(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BedrockagentcoreGateway(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a BedrockagentcoreGateway resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the BedrockagentcoreGateway to import.</param>
        /// <param name="importFromId">The id of the existing BedrockagentcoreGateway that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the BedrockagentcoreGateway to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the BedrockagentcoreGateway to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing BedrockagentcoreGateway that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the BedrockagentcoreGateway to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.BedrockagentcoreGateway.BedrockagentcoreGateway), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAuthorizerConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayAuthorizerConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAuthorizerConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayAuthorizerConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayAuthorizerConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayAuthorizerConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInterceptorConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayInterceptorConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInterceptorConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayInterceptorConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayInterceptorConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayInterceptorConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProtocolConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProtocolConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthorizerConfiguration")]
        public virtual void ResetAuthorizerConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExceptionLevel")]
        public virtual void ResetExceptionLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInterceptorConfiguration")]
        public virtual void ResetInterceptorConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyArn")]
        public virtual void ResetKmsKeyArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocolConfiguration")]
        public virtual void ResetProtocolConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.BedrockagentcoreGateway.BedrockagentcoreGateway))!;

        [JsiiProperty(name: "authorizerConfiguration", typeJson: "{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayAuthorizerConfigurationList\"}")]
        public virtual aws.BedrockagentcoreGateway.BedrockagentcoreGatewayAuthorizerConfigurationList AuthorizerConfiguration
        {
            get => GetInstanceProperty<aws.BedrockagentcoreGateway.BedrockagentcoreGatewayAuthorizerConfigurationList>()!;
        }

        [JsiiProperty(name: "gatewayArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gatewayUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "interceptorConfiguration", typeJson: "{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayInterceptorConfigurationList\"}")]
        public virtual aws.BedrockagentcoreGateway.BedrockagentcoreGatewayInterceptorConfigurationList InterceptorConfiguration
        {
            get => GetInstanceProperty<aws.BedrockagentcoreGateway.BedrockagentcoreGatewayInterceptorConfigurationList>()!;
        }

        [JsiiProperty(name: "protocolConfiguration", typeJson: "{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationList\"}")]
        public virtual aws.BedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationList ProtocolConfiguration
        {
            get => GetInstanceProperty<aws.BedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationList>()!;
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap TagsAll
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayTimeoutsOutputReference\"}")]
        public virtual aws.BedrockagentcoreGateway.BedrockagentcoreGatewayTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.BedrockagentcoreGateway.BedrockagentcoreGatewayTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "workloadIdentityDetails", typeJson: "{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayWorkloadIdentityDetailsList\"}")]
        public virtual aws.BedrockagentcoreGateway.BedrockagentcoreGatewayWorkloadIdentityDetailsList WorkloadIdentityDetails
        {
            get => GetInstanceProperty<aws.BedrockagentcoreGateway.BedrockagentcoreGatewayWorkloadIdentityDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizerConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayAuthorizerConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AuthorizerConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizerTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizerTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exceptionLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExceptionLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "interceptorConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayInterceptorConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InterceptorConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProtocolConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolTypeInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "authorizerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizerType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "exceptionLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExceptionLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocolType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtocolType
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
