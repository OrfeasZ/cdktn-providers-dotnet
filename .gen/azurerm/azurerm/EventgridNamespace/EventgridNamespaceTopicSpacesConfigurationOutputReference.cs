using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridNamespace
{
    [JsiiClass(nativeType: typeof(azurerm.EventgridNamespace.EventgridNamespaceTopicSpacesConfigurationOutputReference), fullyQualifiedName: "azurerm.eventgridNamespace.EventgridNamespaceTopicSpacesConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EventgridNamespaceTopicSpacesConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public EventgridNamespaceTopicSpacesConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected EventgridNamespaceTopicSpacesConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EventgridNamespaceTopicSpacesConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment" />)[]</param>
        [JsiiMethod(name: "putDynamicRoutingEnrichment", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridNamespace.EventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDynamicRoutingEnrichment(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationStaticRoutingEnrichment" />)[]</param>
        [JsiiMethod(name: "putStaticRoutingEnrichment", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridNamespace.EventgridNamespaceTopicSpacesConfigurationStaticRoutingEnrichment\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStaticRoutingEnrichment(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationStaticRoutingEnrichment[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationStaticRoutingEnrichment).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationStaticRoutingEnrichment).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlternativeAuthenticationNameSource")]
        public virtual void ResetAlternativeAuthenticationNameSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDynamicRoutingEnrichment")]
        public virtual void ResetDynamicRoutingEnrichment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumClientSessionsPerAuthenticationName")]
        public virtual void ResetMaximumClientSessionsPerAuthenticationName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumSessionExpiryInHours")]
        public virtual void ResetMaximumSessionExpiryInHours()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRouteTopicId")]
        public virtual void ResetRouteTopicId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStaticRoutingEnrichment")]
        public virtual void ResetStaticRoutingEnrichment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dynamicRoutingEnrichment", typeJson: "{\"fqn\":\"azurerm.eventgridNamespace.EventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichmentList\"}")]
        public virtual azurerm.EventgridNamespace.EventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichmentList DynamicRoutingEnrichment
        {
            get => GetInstanceProperty<azurerm.EventgridNamespace.EventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichmentList>()!;
        }

        [JsiiProperty(name: "staticRoutingEnrichment", typeJson: "{\"fqn\":\"azurerm.eventgridNamespace.EventgridNamespaceTopicSpacesConfigurationStaticRoutingEnrichmentList\"}")]
        public virtual azurerm.EventgridNamespace.EventgridNamespaceTopicSpacesConfigurationStaticRoutingEnrichmentList StaticRoutingEnrichment
        {
            get => GetInstanceProperty<azurerm.EventgridNamespace.EventgridNamespaceTopicSpacesConfigurationStaticRoutingEnrichmentList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alternativeAuthenticationNameSourceInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AlternativeAuthenticationNameSourceInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dynamicRoutingEnrichmentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridNamespace.EventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DynamicRoutingEnrichmentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumClientSessionsPerAuthenticationNameInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumClientSessionsPerAuthenticationNameInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumSessionExpiryInHoursInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumSessionExpiryInHoursInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routeTopicIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RouteTopicIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationStaticRoutingEnrichment" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "staticRoutingEnrichmentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridNamespace.EventgridNamespaceTopicSpacesConfigurationStaticRoutingEnrichment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StaticRoutingEnrichmentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "alternativeAuthenticationNameSource", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AlternativeAuthenticationNameSource
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumClientSessionsPerAuthenticationName", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumClientSessionsPerAuthenticationName
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumSessionExpiryInHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumSessionExpiryInHours
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routeTopicId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RouteTopicId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfiguration" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.eventgridNamespace.EventgridNamespaceTopicSpacesConfiguration\"}]}}", isOptional: true)]
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
                        case azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfiguration cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfiguration).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
