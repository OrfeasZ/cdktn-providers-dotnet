using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermExpressRouteCircuitPeering
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeeringIpv6OutputReference), fullyQualifiedName: "azurerm.dataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeeringIpv6OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermExpressRouteCircuitPeeringIpv6OutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermExpressRouteCircuitPeeringIpv6OutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermExpressRouteCircuitPeeringIpv6OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermExpressRouteCircuitPeeringIpv6OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "microsoftPeering", typeJson: "{\"fqn\":\"azurerm.dataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeeringIpv6MicrosoftPeeringList\"}")]
        public virtual azurerm.DataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeeringIpv6MicrosoftPeeringList MicrosoftPeering
        {
            get => GetInstanceProperty<azurerm.DataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeeringIpv6MicrosoftPeeringList>()!;
        }

        [JsiiProperty(name: "primaryPeerAddressPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryPeerAddressPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routeFilterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RouteFilterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryPeerAddressPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryPeerAddressPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeeringIpv6\"}", isOptional: true)]
        public virtual azurerm.DataAzurermExpressRouteCircuitPeering.IDataAzurermExpressRouteCircuitPeeringIpv6? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermExpressRouteCircuitPeering.IDataAzurermExpressRouteCircuitPeeringIpv6?>();
            set => SetInstanceProperty(value);
        }
    }
}
