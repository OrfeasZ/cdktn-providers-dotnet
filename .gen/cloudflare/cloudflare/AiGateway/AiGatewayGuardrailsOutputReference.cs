using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiGateway
{
    [JsiiClass(nativeType: typeof(cloudflare.AiGateway.AiGatewayGuardrailsOutputReference), fullyQualifiedName: "cloudflare.aiGateway.AiGatewayGuardrailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AiGatewayGuardrailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AiGatewayGuardrailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiGatewayGuardrailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiGatewayGuardrailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPrompt", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiGateway.AiGatewayGuardrailsPrompt\"}}]")]
        public virtual void PutPrompt(cloudflare.AiGateway.IAiGatewayGuardrailsPrompt @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiGateway.IAiGatewayGuardrailsPrompt)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResponse", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiGateway.AiGatewayGuardrailsResponse\"}}]")]
        public virtual void PutResponse(cloudflare.AiGateway.IAiGatewayGuardrailsResponse @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiGateway.IAiGatewayGuardrailsResponse)}, new object[]{@value});
        }

        [JsiiProperty(name: "prompt", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewayGuardrailsPromptOutputReference\"}")]
        public virtual cloudflare.AiGateway.AiGatewayGuardrailsPromptOutputReference Prompt
        {
            get => GetInstanceProperty<cloudflare.AiGateway.AiGatewayGuardrailsPromptOutputReference>()!;
        }

        [JsiiProperty(name: "response", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewayGuardrailsResponseOutputReference\"}")]
        public virtual cloudflare.AiGateway.AiGatewayGuardrailsResponseOutputReference Response
        {
            get => GetInstanceProperty<cloudflare.AiGateway.AiGatewayGuardrailsResponseOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.AiGateway.IAiGatewayGuardrailsPrompt" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "promptInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiGateway.AiGatewayGuardrailsPrompt\"}]}}", isOptional: true)]
        public virtual object? PromptInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.AiGateway.IAiGatewayGuardrailsResponse" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "responseInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiGateway.AiGatewayGuardrailsResponse\"}]}}", isOptional: true)]
        public virtual object? ResponseInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.AiGateway.IAiGatewayGuardrails" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiGateway.AiGatewayGuardrails\"}]}}", isOptional: true)]
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
                        case cloudflare.AiGateway.IAiGatewayGuardrails cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.AiGateway.IAiGatewayGuardrails).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
