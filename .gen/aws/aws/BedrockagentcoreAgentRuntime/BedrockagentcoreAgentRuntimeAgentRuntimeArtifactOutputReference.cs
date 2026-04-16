using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreAgentRuntime
{
    [JsiiClass(nativeType: typeof(aws.BedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifactOutputReference), fullyQualifiedName: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifactOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class BedrockagentcoreAgentRuntimeAgentRuntimeArtifactOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public BedrockagentcoreAgentRuntimeAgentRuntimeArtifactOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected BedrockagentcoreAgentRuntimeAgentRuntimeArtifactOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BedrockagentcoreAgentRuntimeAgentRuntimeArtifactOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCodeConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifactCodeConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCodeConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAgentRuntimeArtifactCodeConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAgentRuntimeArtifactCodeConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAgentRuntimeArtifactCodeConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putContainerConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifactContainerConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutContainerConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAgentRuntimeArtifactContainerConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAgentRuntimeArtifactContainerConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAgentRuntimeArtifactContainerConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCodeConfiguration")]
        public virtual void ResetCodeConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContainerConfiguration")]
        public virtual void ResetContainerConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "codeConfiguration", typeJson: "{\"fqn\":\"aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifactCodeConfigurationList\"}")]
        public virtual aws.BedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifactCodeConfigurationList CodeConfiguration
        {
            get => GetInstanceProperty<aws.BedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifactCodeConfigurationList>()!;
        }

        [JsiiProperty(name: "containerConfiguration", typeJson: "{\"fqn\":\"aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifactContainerConfigurationList\"}")]
        public virtual aws.BedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifactContainerConfigurationList ContainerConfiguration
        {
            get => GetInstanceProperty<aws.BedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifactContainerConfigurationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifactCodeConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CodeConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifactContainerConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ContainerConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifact\"}]}}", isOptional: true)]
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
                        case aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAgentRuntimeArtifact cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAgentRuntimeArtifact).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
