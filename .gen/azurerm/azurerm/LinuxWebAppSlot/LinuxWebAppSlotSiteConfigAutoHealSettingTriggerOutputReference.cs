using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebAppSlot
{
    [JsiiClass(nativeType: typeof(azurerm.LinuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerOutputReference), fullyQualifiedName: "azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LinuxWebAppSlotSiteConfigAutoHealSettingTriggerOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LinuxWebAppSlotSiteConfigAutoHealSettingTriggerOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LinuxWebAppSlotSiteConfigAutoHealSettingTriggerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxWebAppSlotSiteConfigAutoHealSettingTriggerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRequests", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerRequests\"}}]")]
        public virtual void PutRequests(azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTriggerRequests @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTriggerRequests)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSlowRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequest\"}}]")]
        public virtual void PutSlowRequest(azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequest)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestWithPath" />)[]</param>
        [JsiiMethod(name: "putSlowRequestWithPath", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestWithPath\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSlowRequestWithPath(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestWithPath[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestWithPath).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestWithPath).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTriggerStatusCode" />)[]</param>
        [JsiiMethod(name: "putStatusCode", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerStatusCode\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStatusCode(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTriggerStatusCode[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTriggerStatusCode).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTriggerStatusCode).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRequests")]
        public virtual void ResetRequests()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSlowRequest")]
        public virtual void ResetSlowRequest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSlowRequestWithPath")]
        public virtual void ResetSlowRequestWithPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatusCode")]
        public virtual void ResetStatusCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "requests", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerRequestsOutputReference\"}")]
        public virtual azurerm.LinuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerRequestsOutputReference Requests
        {
            get => GetInstanceProperty<azurerm.LinuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerRequestsOutputReference>()!;
        }

        [JsiiProperty(name: "slowRequest", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestOutputReference\"}")]
        public virtual azurerm.LinuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestOutputReference SlowRequest
        {
            get => GetInstanceProperty<azurerm.LinuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestOutputReference>()!;
        }

        [JsiiProperty(name: "slowRequestWithPath", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestWithPathList\"}")]
        public virtual azurerm.LinuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestWithPathList SlowRequestWithPath
        {
            get => GetInstanceProperty<azurerm.LinuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestWithPathList>()!;
        }

        [JsiiProperty(name: "statusCode", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerStatusCodeList\"}")]
        public virtual azurerm.LinuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerStatusCodeList StatusCode
        {
            get => GetInstanceProperty<azurerm.LinuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerStatusCodeList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestsInput", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerRequests\"}", isOptional: true)]
        public virtual azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTriggerRequests? RequestsInput
        {
            get => GetInstanceProperty<azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTriggerRequests?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "slowRequestInput", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequest\"}", isOptional: true)]
        public virtual azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequest? SlowRequestInput
        {
            get => GetInstanceProperty<azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequest?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestWithPath" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "slowRequestWithPathInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestWithPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SlowRequestWithPathInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTriggerStatusCode" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statusCodeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTriggerStatusCode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StatusCodeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTrigger\"}", isOptional: true)]
        public virtual azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTrigger? InternalValue
        {
            get => GetInstanceProperty<azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTrigger?>();
            set => SetInstanceProperty(value);
        }
    }
}
