using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOptimizerProfiles
{
    [JsiiClass(nativeType: typeof(oci.DataOciOptimizerProfiles.DataOciOptimizerProfilesProfileCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciOptimizerProfiles.DataOciOptimizerProfilesProfileCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOptimizerProfilesProfileCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOptimizerProfilesProfileCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOptimizerProfilesProfileCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOptimizerProfilesProfileCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "aggregationIntervalInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AggregationIntervalInDays
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "levelsConfiguration", typeJson: "{\"fqn\":\"oci.dataOciOptimizerProfiles.DataOciOptimizerProfilesProfileCollectionItemsLevelsConfigurationList\"}")]
        public virtual oci.DataOciOptimizerProfiles.DataOciOptimizerProfilesProfileCollectionItemsLevelsConfigurationList LevelsConfiguration
        {
            get => GetInstanceProperty<oci.DataOciOptimizerProfiles.DataOciOptimizerProfilesProfileCollectionItemsLevelsConfigurationList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
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

        [JsiiProperty(name: "targetCompartments", typeJson: "{\"fqn\":\"oci.dataOciOptimizerProfiles.DataOciOptimizerProfilesProfileCollectionItemsTargetCompartmentsList\"}")]
        public virtual oci.DataOciOptimizerProfiles.DataOciOptimizerProfilesProfileCollectionItemsTargetCompartmentsList TargetCompartments
        {
            get => GetInstanceProperty<oci.DataOciOptimizerProfiles.DataOciOptimizerProfilesProfileCollectionItemsTargetCompartmentsList>()!;
        }

        [JsiiProperty(name: "targetTags", typeJson: "{\"fqn\":\"oci.dataOciOptimizerProfiles.DataOciOptimizerProfilesProfileCollectionItemsTargetTagsList\"}")]
        public virtual oci.DataOciOptimizerProfiles.DataOciOptimizerProfilesProfileCollectionItemsTargetTagsList TargetTags
        {
            get => GetInstanceProperty<oci.DataOciOptimizerProfiles.DataOciOptimizerProfilesProfileCollectionItemsTargetTagsList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOptimizerProfiles.DataOciOptimizerProfilesProfileCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciOptimizerProfiles.IDataOciOptimizerProfilesProfileCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOptimizerProfiles.IDataOciOptimizerProfilesProfileCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
