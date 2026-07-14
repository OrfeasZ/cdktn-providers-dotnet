using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorBatchRuleSet
{
    [JsiiClass(nativeType: typeof(azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsOutputReference), fullyQualifiedName: "azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CdnFrontdoorBatchRuleSetRuleActionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CdnFrontdoorBatchRuleSetRuleActionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CdnFrontdoorBatchRuleSetRuleActionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnFrontdoorBatchRuleSetRuleActionsOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsModifyRequestHeader" />)[]</param>
        [JsiiMethod(name: "putModifyRequestHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsModifyRequestHeader\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutModifyRequestHeader(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsModifyRequestHeader[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsModifyRequestHeader).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsModifyRequestHeader).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsModifyResponseHeader" />)[]</param>
        [JsiiMethod(name: "putModifyResponseHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsModifyResponseHeader\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutModifyResponseHeader(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsModifyResponseHeader[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsModifyResponseHeader).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsModifyResponseHeader).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRouteConfigurationOverride", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverride\"}}]")]
        public virtual void PutRouteConfigurationOverride(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverride @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverride)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrlRedirect", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsUrlRedirect\"}}]")]
        public virtual void PutUrlRedirect(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsUrlRedirect @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsUrlRedirect)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrlRewrite", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsUrlRewrite\"}}]")]
        public virtual void PutUrlRewrite(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsUrlRewrite @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsUrlRewrite)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetModifyRequestHeader")]
        public virtual void ResetModifyRequestHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModifyResponseHeader")]
        public virtual void ResetModifyResponseHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRouteConfigurationOverride")]
        public virtual void ResetRouteConfigurationOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrlRedirect")]
        public virtual void ResetUrlRedirect()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrlRewrite")]
        public virtual void ResetUrlRewrite()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "modifyRequestHeader", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsModifyRequestHeaderList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsModifyRequestHeaderList ModifyRequestHeader
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsModifyRequestHeaderList>()!;
        }

        [JsiiProperty(name: "modifyResponseHeader", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsModifyResponseHeaderList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsModifyResponseHeaderList ModifyResponseHeader
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsModifyResponseHeaderList>()!;
        }

        [JsiiProperty(name: "routeConfigurationOverride", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOutputReference\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOutputReference RouteConfigurationOverride
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOutputReference>()!;
        }

        [JsiiProperty(name: "urlRedirect", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsUrlRedirectOutputReference\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsUrlRedirectOutputReference UrlRedirect
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsUrlRedirectOutputReference>()!;
        }

        [JsiiProperty(name: "urlRewrite", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsUrlRewriteOutputReference\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsUrlRewriteOutputReference UrlRewrite
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsUrlRewriteOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsModifyRequestHeader" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modifyRequestHeaderInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsModifyRequestHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ModifyRequestHeaderInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsModifyResponseHeader" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modifyResponseHeaderInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsModifyResponseHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ModifyResponseHeaderInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routeConfigurationOverrideInput", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverride\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverride? RouteConfigurationOverrideInput
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverride?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlRedirectInput", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsUrlRedirect\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsUrlRedirect? UrlRedirectInput
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsUrlRedirect?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlRewriteInput", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsUrlRewrite\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsUrlRewrite? UrlRewriteInput
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsUrlRewrite?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActions\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActions? InternalValue
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActions?>();
            set => SetInstanceProperty(value);
        }
    }
}
