using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreCrossConnects
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreCrossConnects.DataOciCoreCrossConnectsCrossConnectsOutputReference), fullyQualifiedName: "oci.dataOciCoreCrossConnects.DataOciCoreCrossConnectsCrossConnectsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreCrossConnectsCrossConnectsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreCrossConnectsCrossConnectsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreCrossConnectsCrossConnectsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreCrossConnectsCrossConnectsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "crossConnectGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CrossConnectGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerReferenceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerReferenceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "farCrossConnectOrCrossConnectGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FarCrossConnectOrCrossConnectGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isActive", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsActive
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "locationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocationName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "macsecProperties", typeJson: "{\"fqn\":\"oci.dataOciCoreCrossConnects.DataOciCoreCrossConnectsCrossConnectsMacsecPropertiesList\"}")]
        public virtual oci.DataOciCoreCrossConnects.DataOciCoreCrossConnectsCrossConnectsMacsecPropertiesList MacsecProperties
        {
            get => GetInstanceProperty<oci.DataOciCoreCrossConnects.DataOciCoreCrossConnectsCrossConnectsMacsecPropertiesList>()!;
        }

        [JsiiProperty(name: "nearCrossConnectOrCrossConnectGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NearCrossConnectOrCrossConnectGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ociLogicalDeviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciLogicalDeviceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ociPhysicalDeviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciPhysicalDeviceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "portName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PortName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "portSpeedShapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PortSpeedShapeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreCrossConnects.DataOciCoreCrossConnectsCrossConnects\"}", isOptional: true)]
        public virtual oci.DataOciCoreCrossConnects.IDataOciCoreCrossConnectsCrossConnects? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreCrossConnects.IDataOciCoreCrossConnectsCrossConnects?>();
            set => SetInstanceProperty(value);
        }
    }
}
