using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualHubConnection
{
    [JsiiClass(nativeType: typeof(azurerm.VirtualHubConnection.VirtualHubConnectionRoutingOutputReference), fullyQualifiedName: "azurerm.virtualHubConnection.VirtualHubConnectionRoutingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VirtualHubConnectionRoutingOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VirtualHubConnectionRoutingOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VirtualHubConnectionRoutingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualHubConnectionRoutingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPropagatedRouteTable", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualHubConnection.VirtualHubConnectionRoutingPropagatedRouteTable\"}}]")]
        public virtual void PutPropagatedRouteTable(azurerm.VirtualHubConnection.IVirtualHubConnectionRoutingPropagatedRouteTable @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualHubConnection.IVirtualHubConnectionRoutingPropagatedRouteTable)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualHubConnection.IVirtualHubConnectionRoutingStaticVnetRoute" />)[]</param>
        [JsiiMethod(name: "putStaticVnetRoute", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualHubConnection.VirtualHubConnectionRoutingStaticVnetRoute\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStaticVnetRoute(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.VirtualHubConnection.IVirtualHubConnectionRoutingStaticVnetRoute[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.VirtualHubConnection.IVirtualHubConnectionRoutingStaticVnetRoute).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.VirtualHubConnection.IVirtualHubConnectionRoutingStaticVnetRoute).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAssociatedRouteTableId")]
        public virtual void ResetAssociatedRouteTableId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInboundRouteMapId")]
        public virtual void ResetInboundRouteMapId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutboundRouteMapId")]
        public virtual void ResetOutboundRouteMapId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPropagatedRouteTable")]
        public virtual void ResetPropagatedRouteTable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStaticVnetLocalRouteOverrideCriteria")]
        public virtual void ResetStaticVnetLocalRouteOverrideCriteria()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStaticVnetPropagateStaticRoutesEnabled")]
        public virtual void ResetStaticVnetPropagateStaticRoutesEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStaticVnetRoute")]
        public virtual void ResetStaticVnetRoute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "propagatedRouteTable", typeJson: "{\"fqn\":\"azurerm.virtualHubConnection.VirtualHubConnectionRoutingPropagatedRouteTableOutputReference\"}")]
        public virtual azurerm.VirtualHubConnection.VirtualHubConnectionRoutingPropagatedRouteTableOutputReference PropagatedRouteTable
        {
            get => GetInstanceProperty<azurerm.VirtualHubConnection.VirtualHubConnectionRoutingPropagatedRouteTableOutputReference>()!;
        }

        [JsiiProperty(name: "staticVnetRoute", typeJson: "{\"fqn\":\"azurerm.virtualHubConnection.VirtualHubConnectionRoutingStaticVnetRouteList\"}")]
        public virtual azurerm.VirtualHubConnection.VirtualHubConnectionRoutingStaticVnetRouteList StaticVnetRoute
        {
            get => GetInstanceProperty<azurerm.VirtualHubConnection.VirtualHubConnectionRoutingStaticVnetRouteList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "associatedRouteTableIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AssociatedRouteTableIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inboundRouteMapIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InboundRouteMapIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outboundRouteMapIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutboundRouteMapIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "propagatedRouteTableInput", typeJson: "{\"fqn\":\"azurerm.virtualHubConnection.VirtualHubConnectionRoutingPropagatedRouteTable\"}", isOptional: true)]
        public virtual azurerm.VirtualHubConnection.IVirtualHubConnectionRoutingPropagatedRouteTable? PropagatedRouteTableInput
        {
            get => GetInstanceProperty<azurerm.VirtualHubConnection.IVirtualHubConnectionRoutingPropagatedRouteTable?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "staticVnetLocalRouteOverrideCriteriaInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StaticVnetLocalRouteOverrideCriteriaInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "staticVnetPropagateStaticRoutesEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? StaticVnetPropagateStaticRoutesEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualHubConnection.IVirtualHubConnectionRoutingStaticVnetRoute" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "staticVnetRouteInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualHubConnection.VirtualHubConnectionRoutingStaticVnetRoute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StaticVnetRouteInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "associatedRouteTableId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociatedRouteTableId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inboundRouteMapId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InboundRouteMapId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outboundRouteMapId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutboundRouteMapId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "staticVnetLocalRouteOverrideCriteria", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StaticVnetLocalRouteOverrideCriteria
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "staticVnetPropagateStaticRoutesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object StaticVnetPropagateStaticRoutesEnabled
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.virtualHubConnection.VirtualHubConnectionRouting\"}", isOptional: true)]
        public virtual azurerm.VirtualHubConnection.IVirtualHubConnectionRouting? InternalValue
        {
            get => GetInstanceProperty<azurerm.VirtualHubConnection.IVirtualHubConnectionRouting?>();
            set => SetInstanceProperty(value);
        }
    }
}
