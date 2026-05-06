using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessAiControlsMcpPortal
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustAccessAiControlsMcpPortal.ZeroTrustAccessAiControlsMcpPortalServersOutputReference), fullyQualifiedName: "cloudflare.zeroTrustAccessAiControlsMcpPortal.ZeroTrustAccessAiControlsMcpPortalServersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ZeroTrustAccessAiControlsMcpPortalServersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ZeroTrustAccessAiControlsMcpPortalServersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected ZeroTrustAccessAiControlsMcpPortalServersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustAccessAiControlsMcpPortalServersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putUpdatedPrompts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessAiControlsMcpPortal.ZeroTrustAccessAiControlsMcpPortalServersUpdatedPrompts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUpdatedPrompts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case cloudflare.ZeroTrustAccessAiControlsMcpPortal.IZeroTrustAccessAiControlsMcpPortalServersUpdatedPrompts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessAiControlsMcpPortal.IZeroTrustAccessAiControlsMcpPortalServersUpdatedPrompts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessAiControlsMcpPortal.IZeroTrustAccessAiControlsMcpPortalServersUpdatedPrompts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpdatedTools", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessAiControlsMcpPortal.ZeroTrustAccessAiControlsMcpPortalServersUpdatedTools\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUpdatedTools(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case cloudflare.ZeroTrustAccessAiControlsMcpPortal.IZeroTrustAccessAiControlsMcpPortalServersUpdatedTools[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessAiControlsMcpPortal.IZeroTrustAccessAiControlsMcpPortalServersUpdatedTools).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessAiControlsMcpPortal.IZeroTrustAccessAiControlsMcpPortalServersUpdatedTools).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefaultDisabled")]
        public virtual void ResetDefaultDisabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnBehalf")]
        public virtual void ResetOnBehalf()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpdatedPrompts")]
        public virtual void ResetUpdatedPrompts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpdatedTools")]
        public virtual void ResetUpdatedTools()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "updatedPrompts", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessAiControlsMcpPortal.ZeroTrustAccessAiControlsMcpPortalServersUpdatedPromptsList\"}")]
        public virtual cloudflare.ZeroTrustAccessAiControlsMcpPortal.ZeroTrustAccessAiControlsMcpPortalServersUpdatedPromptsList UpdatedPrompts
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessAiControlsMcpPortal.ZeroTrustAccessAiControlsMcpPortalServersUpdatedPromptsList>()!;
        }

        [JsiiProperty(name: "updatedTools", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessAiControlsMcpPortal.ZeroTrustAccessAiControlsMcpPortalServersUpdatedToolsList\"}")]
        public virtual cloudflare.ZeroTrustAccessAiControlsMcpPortal.ZeroTrustAccessAiControlsMcpPortalServersUpdatedToolsList UpdatedTools
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessAiControlsMcpPortal.ZeroTrustAccessAiControlsMcpPortalServersUpdatedToolsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultDisabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DefaultDisabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onBehalfInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? OnBehalfInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "updatedPromptsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessAiControlsMcpPortal.ZeroTrustAccessAiControlsMcpPortalServersUpdatedPrompts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UpdatedPromptsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "updatedToolsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessAiControlsMcpPortal.ZeroTrustAccessAiControlsMcpPortalServersUpdatedTools\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UpdatedToolsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "defaultDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DefaultDisabled
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

        [JsiiProperty(name: "onBehalf", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object OnBehalf
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

        [JsiiProperty(name: "serverId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessAiControlsMcpPortal.ZeroTrustAccessAiControlsMcpPortalServers\"}]}}", isOptional: true)]
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
                        case cloudflare.ZeroTrustAccessAiControlsMcpPortal.IZeroTrustAccessAiControlsMcpPortalServers cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessAiControlsMcpPortal.IZeroTrustAccessAiControlsMcpPortalServers).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
