using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardTarget
{
    [JsiiClass(nativeType: typeof(oci.CloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurationsOutputReference), fullyQualifiedName: "oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "additionalProperties", typeJson: "{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurationsAdditionalPropertiesList\"}")]
        public virtual oci.CloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurationsAdditionalPropertiesList AdditionalProperties
        {
            get => GetInstanceProperty<oci.CloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurationsAdditionalPropertiesList>()!;
        }

        [JsiiProperty(name: "allowedValues", typeJson: "{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurationsAllowedValuesList\"}")]
        public virtual oci.CloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurationsAllowedValuesList AllowedValues
        {
            get => GetInstanceProperty<oci.CloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurationsAllowedValuesList>()!;
        }

        [JsiiProperty(name: "allowedValuesDataType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllowedValuesDataType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Value
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "values", typeJson: "{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurationsValuesList\"}")]
        public virtual oci.CloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurationsValuesList Values
        {
            get => GetInstanceProperty<oci.CloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurationsValuesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurations\"}", isOptional: true)]
        public virtual oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurations? InternalValue
        {
            get => GetInstanceProperty<oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurations?>();
            set => SetInstanceProperty(value);
        }
    }
}
