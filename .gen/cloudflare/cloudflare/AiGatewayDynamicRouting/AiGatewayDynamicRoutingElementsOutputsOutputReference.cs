using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiGatewayDynamicRouting
{
    [JsiiClass(nativeType: typeof(cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsOutputReference), fullyQualifiedName: "cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AiGatewayDynamicRoutingElementsOutputsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AiGatewayDynamicRoutingElementsOutputsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AiGatewayDynamicRoutingElementsOutputsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiGatewayDynamicRoutingElementsOutputsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFallback", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsFallback\"}}]")]
        public virtual void PutFallback(cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsFallback @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsFallback)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFalse", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsFalse\"}}]")]
        public virtual void PutFalse(cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsFalse @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsFalse)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNext", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsNext\"}}]")]
        public virtual void PutNext(cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsNext @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsNext)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSuccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsSuccess\"}}]")]
        public virtual void PutSuccess(cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsSuccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsSuccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrue", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsTrue\"}}]")]
        public virtual void PutTrue(cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsTrue @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsTrue)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetElementId")]
        public virtual void ResetElementId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFallback")]
        public virtual void ResetFallback()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFalse")]
        public virtual void ResetFalse()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNext")]
        public virtual void ResetNext()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSuccess")]
        public virtual void ResetSuccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrue")]
        public virtual void ResetTrue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "fallback", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsFallbackOutputReference\"}")]
        public virtual cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsFallbackOutputReference Fallback
        {
            get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsFallbackOutputReference>()!;
        }

        [JsiiProperty(name: "false", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsFalseOutputReference\"}")]
        public virtual cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsFalseOutputReference False
        {
            get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsFalseOutputReference>()!;
        }

        [JsiiProperty(name: "next", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsNextOutputReference\"}")]
        public virtual cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsNextOutputReference Next
        {
            get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsNextOutputReference>()!;
        }

        [JsiiProperty(name: "success", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsSuccessOutputReference\"}")]
        public virtual cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsSuccessOutputReference Success
        {
            get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsSuccessOutputReference>()!;
        }

        [JsiiProperty(name: "true", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsTrueOutputReference\"}")]
        public virtual cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsTrueOutputReference True
        {
            get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsTrueOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "elementIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ElementIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fallbackInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsFallback\"}]}}", isOptional: true)]
        public virtual object? FallbackInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "falseInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsFalse\"}]}}", isOptional: true)]
        public virtual object? FalseInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nextInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsNext\"}]}}", isOptional: true)]
        public virtual object? NextInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "successInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsSuccess\"}]}}", isOptional: true)]
        public virtual object? SuccessInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trueInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsTrue\"}]}}", isOptional: true)]
        public virtual object? TrueInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "elementId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElementId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputs\"}]}}", isOptional: true)]
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
                        case cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputs cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputs).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
