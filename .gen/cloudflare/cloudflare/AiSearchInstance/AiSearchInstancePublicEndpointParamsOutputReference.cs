using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiClass(nativeType: typeof(cloudflare.AiSearchInstance.AiSearchInstancePublicEndpointParamsOutputReference), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AiSearchInstancePublicEndpointParamsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AiSearchInstancePublicEndpointParamsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AiSearchInstancePublicEndpointParamsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiSearchInstancePublicEndpointParamsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putChatCompletionsEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsChatCompletionsEndpoint\"}}]")]
        public virtual void PutChatCompletionsEndpoint(cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsChatCompletionsEndpoint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsChatCompletionsEndpoint)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMcp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsMcp\"}}]")]
        public virtual void PutMcp(cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsMcp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsMcp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRateLimit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsRateLimit\"}}]")]
        public virtual void PutRateLimit(cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsRateLimit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsRateLimit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSearchEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsSearchEndpoint\"}}]")]
        public virtual void PutSearchEndpoint(cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsSearchEndpoint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsSearchEndpoint)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthorizedHosts")]
        public virtual void ResetAuthorizedHosts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetChatCompletionsEndpoint")]
        public virtual void ResetChatCompletionsEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMcp")]
        public virtual void ResetMcp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRateLimit")]
        public virtual void ResetRateLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSearchEndpoint")]
        public virtual void ResetSearchEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "chatCompletionsEndpoint", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsChatCompletionsEndpointOutputReference\"}")]
        public virtual cloudflare.AiSearchInstance.AiSearchInstancePublicEndpointParamsChatCompletionsEndpointOutputReference ChatCompletionsEndpoint
        {
            get => GetInstanceProperty<cloudflare.AiSearchInstance.AiSearchInstancePublicEndpointParamsChatCompletionsEndpointOutputReference>()!;
        }

        [JsiiProperty(name: "mcp", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsMcpOutputReference\"}")]
        public virtual cloudflare.AiSearchInstance.AiSearchInstancePublicEndpointParamsMcpOutputReference Mcp
        {
            get => GetInstanceProperty<cloudflare.AiSearchInstance.AiSearchInstancePublicEndpointParamsMcpOutputReference>()!;
        }

        [JsiiProperty(name: "rateLimit", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsRateLimitOutputReference\"}")]
        public virtual cloudflare.AiSearchInstance.AiSearchInstancePublicEndpointParamsRateLimitOutputReference RateLimit
        {
            get => GetInstanceProperty<cloudflare.AiSearchInstance.AiSearchInstancePublicEndpointParamsRateLimitOutputReference>()!;
        }

        [JsiiProperty(name: "searchEndpoint", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsSearchEndpointOutputReference\"}")]
        public virtual cloudflare.AiSearchInstance.AiSearchInstancePublicEndpointParamsSearchEndpointOutputReference SearchEndpoint
        {
            get => GetInstanceProperty<cloudflare.AiSearchInstance.AiSearchInstancePublicEndpointParamsSearchEndpointOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizedHostsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AuthorizedHostsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "chatCompletionsEndpointInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsChatCompletionsEndpoint\"}]}}", isOptional: true)]
        public virtual object? ChatCompletionsEndpointInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mcpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsMcp\"}]}}", isOptional: true)]
        public virtual object? McpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rateLimitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsRateLimit\"}]}}", isOptional: true)]
        public virtual object? RateLimitInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "searchEndpointInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsSearchEndpoint\"}]}}", isOptional: true)]
        public virtual object? SearchEndpointInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "authorizedHosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AuthorizedHosts
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Enabled
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParams\"}]}}", isOptional: true)]
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
                        case cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParams cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParams).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
