using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardDetectorRecipe
{
    [JsiiClass(nativeType: typeof(oci.CloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesOutputReference), fullyQualifiedName: "oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudGuardDetectorRecipeDetectorRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CloudGuardDetectorRecipeDetectorRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CloudGuardDetectorRecipeDetectorRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudGuardDetectorRecipeDetectorRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetails\"}}]")]
        public virtual void PutDetails(oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetails)}, new object[]{@value});
        }

        [JsiiProperty(name: "candidateResponderRules", typeJson: "{\"fqn\":\"oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesCandidateResponderRulesList\"}")]
        public virtual oci.CloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesCandidateResponderRulesList CandidateResponderRules
        {
            get => GetInstanceProperty<oci.CloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesCandidateResponderRulesList>()!;
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

        [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetailsOutputReference\"}")]
        public virtual oci.CloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetailsOutputReference Details
        {
            get => GetInstanceProperty<oci.CloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "detector", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Detector
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "entitiesMappings", typeJson: "{\"fqn\":\"oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesEntitiesMappingsList\"}")]
        public virtual oci.CloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesEntitiesMappingsList EntitiesMappings
        {
            get => GetInstanceProperty<oci.CloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesEntitiesMappingsList>()!;
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

        [JsiiProperty(name: "ruleType", typeJson: "{\"fqn\":\"oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesRuleTypeList\"}")]
        public virtual oci.CloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesRuleTypeList RuleType
        {
            get => GetInstanceProperty<oci.CloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesRuleTypeList>()!;
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
        [JsiiProperty(name: "detailsInput", typeJson: "{\"fqn\":\"oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetails\"}", isOptional: true)]
        public virtual oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetails? DetailsInput
        {
            get => GetInstanceProperty<oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "detectorRuleIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DetectorRuleIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "detectorRuleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DetectorRuleId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRules\"}]}}", isOptional: true)]
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
                        case oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRules cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRules).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
