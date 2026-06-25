using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDifStacks
{
    [JsiiClass(nativeType: typeof(oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDifStacks.DataOciDifStacksStackCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDifStacksStackCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDifStacksStackCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDifStacksStackCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDifStacksStackCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "adb", typeJson: "{\"fqn\":\"oci.dataOciDifStacks.DataOciDifStacksStackCollectionItemsAdbList\"}")]
        public virtual oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsAdbList Adb
        {
            get => GetInstanceProperty<oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsAdbList>()!;
        }

        [JsiiProperty(name: "addServiceTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AddServiceTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "aidataplatform", typeJson: "{\"fqn\":\"oci.dataOciDifStacks.DataOciDifStacksStackCollectionItemsAidataplatformList\"}")]
        public virtual oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsAidataplatformList Aidataplatform
        {
            get => GetInstanceProperty<oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsAidataplatformList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataflow", typeJson: "{\"fqn\":\"oci.dataOciDifStacks.DataOciDifStacksStackCollectionItemsDataflowList\"}")]
        public virtual oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsDataflowList Dataflow
        {
            get => GetInstanceProperty<oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsDataflowList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "deployArtifactsTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeployArtifactsTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "genai", typeJson: "{\"fqn\":\"oci.dataOciDifStacks.DataOciDifStacksStackCollectionItemsGenaiList\"}")]
        public virtual oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsGenaiList Genai
        {
            get => GetInstanceProperty<oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsGenaiList>()!;
        }

        [JsiiProperty(name: "ggcs", typeJson: "{\"fqn\":\"oci.dataOciDifStacks.DataOciDifStacksStackCollectionItemsGgcsList\"}")]
        public virtual oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsGgcsList Ggcs
        {
            get => GetInstanceProperty<oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsGgcsList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notificationEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotificationEmail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectstorage", typeJson: "{\"fqn\":\"oci.dataOciDifStacks.DataOciDifStacksStackCollectionItemsObjectstorageList\"}")]
        public virtual oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsObjectstorageList Objectstorage
        {
            get => GetInstanceProperty<oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsObjectstorageList>()!;
        }

        [JsiiProperty(name: "oke", typeJson: "{\"fqn\":\"oci.dataOciDifStacks.DataOciDifStacksStackCollectionItemsOkeList\"}")]
        public virtual oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsOkeList Oke
        {
            get => GetInstanceProperty<oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsOkeList>()!;
        }

        [JsiiProperty(name: "omk", typeJson: "{\"fqn\":\"oci.dataOciDifStacks.DataOciDifStacksStackCollectionItemsOmkList\"}")]
        public virtual oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsOmkList Omk
        {
            get => GetInstanceProperty<oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsOmkList>()!;
        }

        [JsiiProperty(name: "serviceDetails", typeJson: "{\"fqn\":\"oci.dataOciDifStacks.DataOciDifStacksStackCollectionItemsServiceDetailsList\"}")]
        public virtual oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsServiceDetailsList ServiceDetails
        {
            get => GetInstanceProperty<oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsServiceDetailsList>()!;
        }

        [JsiiProperty(name: "services", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Services
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "stackTemplates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] StackTemplates
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDifStacks.DataOciDifStacksStackCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDifStacks.IDataOciDifStacksStackCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDifStacks.IDataOciDifStacksStackCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
