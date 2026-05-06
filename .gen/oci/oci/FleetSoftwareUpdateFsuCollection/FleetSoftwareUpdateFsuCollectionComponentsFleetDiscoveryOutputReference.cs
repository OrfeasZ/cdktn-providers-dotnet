using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuCollection
{
    [JsiiClass(nativeType: typeof(oci.FleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionComponentsFleetDiscoveryOutputReference), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionComponentsFleetDiscoveryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FleetSoftwareUpdateFsuCollectionComponentsFleetDiscoveryOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FleetSoftwareUpdateFsuCollectionComponentsFleetDiscoveryOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FleetSoftwareUpdateFsuCollectionComponentsFleetDiscoveryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetSoftwareUpdateFsuCollectionComponentsFleetDiscoveryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFilters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionComponentsFleetDiscoveryFilters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionComponentsFleetDiscoveryFilters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionComponentsFleetDiscoveryFilters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionComponentsFleetDiscoveryFilters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilters")]
        public virtual void ResetFilters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFsuDiscoveryId")]
        public virtual void ResetFsuDiscoveryId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuery")]
        public virtual void ResetQuery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargets")]
        public virtual void ResetTargets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "filters", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionComponentsFleetDiscoveryFiltersList\"}")]
        public virtual oci.FleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionComponentsFleetDiscoveryFiltersList Filters
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionComponentsFleetDiscoveryFiltersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filtersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionComponentsFleetDiscoveryFilters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FiltersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fsuDiscoveryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FsuDiscoveryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QueryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "strategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TargetsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "fsuDiscoveryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FsuDiscoveryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Query
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Strategy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Targets
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionComponentsFleetDiscovery\"}", isOptional: true)]
        public virtual oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionComponentsFleetDiscovery? InternalValue
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionComponentsFleetDiscovery?>();
            set => SetInstanceProperty(value);
        }
    }
}
