using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCloudGuardTarget
{
    [JsiiClass(nativeType: typeof(oci.DataOciCloudGuardTarget.DataOciCloudGuardTargetTargetDetectorRecipesEffectiveDetectorRulesOutputReference), fullyQualifiedName: "oci.dataOciCloudGuardTarget.DataOciCloudGuardTargetTargetDetectorRecipesEffectiveDetectorRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCloudGuardTargetTargetDetectorRecipesEffectiveDetectorRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCloudGuardTargetTargetDetectorRecipesEffectiveDetectorRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCloudGuardTargetTargetDetectorRecipesEffectiveDetectorRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudGuardTargetTargetDetectorRecipesEffectiveDetectorRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dataSourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"oci.dataOciCloudGuardTarget.DataOciCloudGuardTargetTargetDetectorRecipesEffectiveDetectorRulesDetailsList\"}")]
        public virtual oci.DataOciCloudGuardTarget.DataOciCloudGuardTargetTargetDetectorRecipesEffectiveDetectorRulesDetailsList Details
        {
            get => GetInstanceProperty<oci.DataOciCloudGuardTarget.DataOciCloudGuardTargetTargetDetectorRecipesEffectiveDetectorRulesDetailsList>()!;
        }

        [JsiiProperty(name: "detector", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Detector
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "detectorRuleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DetectorRuleId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "entitiesMappings", typeJson: "{\"fqn\":\"oci.dataOciCloudGuardTarget.DataOciCloudGuardTargetTargetDetectorRecipesEffectiveDetectorRulesEntitiesMappingsList\"}")]
        public virtual oci.DataOciCloudGuardTarget.DataOciCloudGuardTargetTargetDetectorRecipesEffectiveDetectorRulesEntitiesMappingsList EntitiesMappings
        {
            get => GetInstanceProperty<oci.DataOciCloudGuardTarget.DataOciCloudGuardTargetTargetDetectorRecipesEffectiveDetectorRulesEntitiesMappingsList>()!;
        }

        [JsiiProperty(name: "isCloneable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCloneable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managedListTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ManagedListTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "recommendation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Recommendation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ruleType", typeJson: "{\"fqn\":\"oci.dataOciCloudGuardTarget.DataOciCloudGuardTargetTargetDetectorRecipesEffectiveDetectorRulesRuleTypeList\"}")]
        public virtual oci.DataOciCloudGuardTarget.DataOciCloudGuardTargetTargetDetectorRecipesEffectiveDetectorRulesRuleTypeList RuleType
        {
            get => GetInstanceProperty<oci.DataOciCloudGuardTarget.DataOciCloudGuardTargetTargetDetectorRecipesEffectiveDetectorRulesRuleTypeList>()!;
        }

        [JsiiProperty(name: "serviceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceType
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

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCloudGuardTarget.DataOciCloudGuardTargetTargetDetectorRecipesEffectiveDetectorRules\"}", isOptional: true)]
        public virtual oci.DataOciCloudGuardTarget.IDataOciCloudGuardTargetTargetDetectorRecipesEffectiveDetectorRules? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCloudGuardTarget.IDataOciCloudGuardTargetTargetDetectorRecipesEffectiveDetectorRules?>();
            set => SetInstanceProperty(value);
        }
    }
}
