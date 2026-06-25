using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGateway
{
    [JsiiClass(nativeType: typeof(aws.BedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationMcpOutputReference), fullyQualifiedName: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationMcpOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class BedrockagentcoreGatewayProtocolConfigurationMcpOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public BedrockagentcoreGatewayProtocolConfigurationMcpOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BedrockagentcoreGatewayProtocolConfigurationMcpOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BedrockagentcoreGatewayProtocolConfigurationMcpOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfigurationMcpSessionConfiguration" />)[]</param>
        [JsiiMethod(name: "putSessionConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationMcpSessionConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSessionConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfigurationMcpSessionConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfigurationMcpSessionConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfigurationMcpSessionConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfigurationMcpStreamingConfiguration" />)[]</param>
        [JsiiMethod(name: "putStreamingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationMcpStreamingConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStreamingConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfigurationMcpStreamingConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfigurationMcpStreamingConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfigurationMcpStreamingConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInstructions")]
        public virtual void ResetInstructions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSearchType")]
        public virtual void ResetSearchType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSessionConfiguration")]
        public virtual void ResetSessionConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStreamingConfiguration")]
        public virtual void ResetStreamingConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSupportedVersions")]
        public virtual void ResetSupportedVersions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "sessionConfiguration", typeJson: "{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationMcpSessionConfigurationList\"}")]
        public virtual aws.BedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationMcpSessionConfigurationList SessionConfiguration
        {
            get => GetInstanceProperty<aws.BedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationMcpSessionConfigurationList>()!;
        }

        [JsiiProperty(name: "streamingConfiguration", typeJson: "{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationMcpStreamingConfigurationList\"}")]
        public virtual aws.BedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationMcpStreamingConfigurationList StreamingConfiguration
        {
            get => GetInstanceProperty<aws.BedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationMcpStreamingConfigurationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instructionsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstructionsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "searchTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SearchTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfigurationMcpSessionConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sessionConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationMcpSessionConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SessionConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfigurationMcpStreamingConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "streamingConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationMcpStreamingConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StreamingConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "supportedVersionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SupportedVersionsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "instructions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Instructions
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "searchType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SearchType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "supportedVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportedVersions
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfigurationMcp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationMcp\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfigurationMcp cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfigurationMcp).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
