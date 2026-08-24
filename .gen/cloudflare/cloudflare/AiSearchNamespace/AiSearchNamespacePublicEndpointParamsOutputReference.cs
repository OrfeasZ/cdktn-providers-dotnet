using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchNamespace
{
    [JsiiClass(nativeType: typeof(cloudflare.AiSearchNamespace.AiSearchNamespacePublicEndpointParamsOutputReference), fullyQualifiedName: "cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AiSearchNamespacePublicEndpointParamsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AiSearchNamespacePublicEndpointParamsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AiSearchNamespacePublicEndpointParamsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiSearchNamespacePublicEndpointParamsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putChatCompletionsEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsChatCompletionsEndpoint\"}}]")]
        public virtual void PutChatCompletionsEndpoint(cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParamsChatCompletionsEndpoint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParamsChatCompletionsEndpoint)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMcp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsMcp\"}}]")]
        public virtual void PutMcp(cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParamsMcp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParamsMcp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRateLimit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsRateLimit\"}}]")]
        public virtual void PutRateLimit(cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParamsRateLimit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParamsRateLimit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSearchEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsSearchEndpoint\"}}]")]
        public virtual void PutSearchEndpoint(cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParamsSearchEndpoint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParamsSearchEndpoint)}, new object[]{@value});
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

        [JsiiMethod(name: "resetCustomDomains")]
        public virtual void ResetCustomDomains()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultDomainEnabled")]
        public virtual void ResetDefaultDomainEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstancesAllowed")]
        public virtual void ResetInstancesAllowed()
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

        [JsiiProperty(name: "chatCompletionsEndpoint", typeJson: "{\"fqn\":\"cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsChatCompletionsEndpointOutputReference\"}")]
        public virtual cloudflare.AiSearchNamespace.AiSearchNamespacePublicEndpointParamsChatCompletionsEndpointOutputReference ChatCompletionsEndpoint
        {
            get => GetInstanceProperty<cloudflare.AiSearchNamespace.AiSearchNamespacePublicEndpointParamsChatCompletionsEndpointOutputReference>()!;
        }

        [JsiiProperty(name: "mcp", typeJson: "{\"fqn\":\"cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsMcpOutputReference\"}")]
        public virtual cloudflare.AiSearchNamespace.AiSearchNamespacePublicEndpointParamsMcpOutputReference Mcp
        {
            get => GetInstanceProperty<cloudflare.AiSearchNamespace.AiSearchNamespacePublicEndpointParamsMcpOutputReference>()!;
        }

        [JsiiProperty(name: "rateLimit", typeJson: "{\"fqn\":\"cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsRateLimitOutputReference\"}")]
        public virtual cloudflare.AiSearchNamespace.AiSearchNamespacePublicEndpointParamsRateLimitOutputReference RateLimit
        {
            get => GetInstanceProperty<cloudflare.AiSearchNamespace.AiSearchNamespacePublicEndpointParamsRateLimitOutputReference>()!;
        }

        [JsiiProperty(name: "searchEndpoint", typeJson: "{\"fqn\":\"cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsSearchEndpointOutputReference\"}")]
        public virtual cloudflare.AiSearchNamespace.AiSearchNamespacePublicEndpointParamsSearchEndpointOutputReference SearchEndpoint
        {
            get => GetInstanceProperty<cloudflare.AiSearchNamespace.AiSearchNamespacePublicEndpointParamsSearchEndpointOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizedHostsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AuthorizedHostsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParamsChatCompletionsEndpoint" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "chatCompletionsEndpointInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsChatCompletionsEndpoint\"}]}}", isOptional: true)]
        public virtual object? ChatCompletionsEndpointInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customDomainsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? CustomDomainsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultDomainEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DefaultDomainEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instancesAllowedInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? InstancesAllowedInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParamsMcp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mcpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsMcp\"}]}}", isOptional: true)]
        public virtual object? McpInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParamsRateLimit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rateLimitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsRateLimit\"}]}}", isOptional: true)]
        public virtual object? RateLimitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParamsSearchEndpoint" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "searchEndpointInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsSearchEndpoint\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "customDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CustomDomains
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "defaultDomainEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DefaultDomainEnabled
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
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

        [JsiiProperty(name: "instancesAllowed", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] InstancesAllowed
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParams" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParams\"}]}}", isOptional: true)]
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
                        case cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParams cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParams).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
