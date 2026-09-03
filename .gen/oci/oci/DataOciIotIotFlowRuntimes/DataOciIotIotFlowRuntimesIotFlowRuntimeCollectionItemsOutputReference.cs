using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIotIotFlowRuntimes
{
    [JsiiClass(nativeType: typeof(oci.DataOciIotIotFlowRuntimes.DataOciIotIotFlowRuntimesIotFlowRuntimeCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciIotIotFlowRuntimes.DataOciIotIotFlowRuntimesIotFlowRuntimeCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIotIotFlowRuntimesIotFlowRuntimeCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIotIotFlowRuntimesIotFlowRuntimeCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIotIotFlowRuntimesIotFlowRuntimeCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIotIotFlowRuntimesIotFlowRuntimeCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "flowRuntimeHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FlowRuntimeHost
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

        [JsiiProperty(name: "iotDomainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IotDomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logConfig", typeJson: "{\"fqn\":\"oci.dataOciIotIotFlowRuntimes.DataOciIotIotFlowRuntimesIotFlowRuntimeCollectionItemsLogConfigList\"}")]
        public virtual oci.DataOciIotIotFlowRuntimes.DataOciIotIotFlowRuntimesIotFlowRuntimeCollectionItemsLogConfigList LogConfig
        {
            get => GetInstanceProperty<oci.DataOciIotIotFlowRuntimes.DataOciIotIotFlowRuntimesIotFlowRuntimeCollectionItemsLogConfigList>()!;
        }

        [JsiiProperty(name: "networkConfig", typeJson: "{\"fqn\":\"oci.dataOciIotIotFlowRuntimes.DataOciIotIotFlowRuntimesIotFlowRuntimeCollectionItemsNetworkConfigList\"}")]
        public virtual oci.DataOciIotIotFlowRuntimes.DataOciIotIotFlowRuntimesIotFlowRuntimeCollectionItemsNetworkConfigList NetworkConfig
        {
            get => GetInstanceProperty<oci.DataOciIotIotFlowRuntimes.DataOciIotIotFlowRuntimesIotFlowRuntimeCollectionItemsNetworkConfigList>()!;
        }

        [JsiiProperty(name: "scale", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scale
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIotIotFlowRuntimes.DataOciIotIotFlowRuntimesIotFlowRuntimeCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciIotIotFlowRuntimes.IDataOciIotIotFlowRuntimesIotFlowRuntimeCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIotIotFlowRuntimes.IDataOciIotIotFlowRuntimesIotFlowRuntimeCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
