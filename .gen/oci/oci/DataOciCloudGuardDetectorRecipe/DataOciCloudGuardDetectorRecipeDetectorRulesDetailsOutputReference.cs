using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCloudGuardDetectorRecipe
{
    [JsiiClass(nativeType: typeof(oci.DataOciCloudGuardDetectorRecipe.DataOciCloudGuardDetectorRecipeDetectorRulesDetailsOutputReference), fullyQualifiedName: "oci.dataOciCloudGuardDetectorRecipe.DataOciCloudGuardDetectorRecipeDetectorRulesDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCloudGuardDetectorRecipeDetectorRulesDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCloudGuardDetectorRecipeDetectorRulesDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCloudGuardDetectorRecipeDetectorRulesDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudGuardDetectorRecipeDetectorRulesDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Condition
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configurations", typeJson: "{\"fqn\":\"oci.dataOciCloudGuardDetectorRecipe.DataOciCloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsList\"}")]
        public virtual oci.DataOciCloudGuardDetectorRecipe.DataOciCloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsList Configurations
        {
            get => GetInstanceProperty<oci.DataOciCloudGuardDetectorRecipe.DataOciCloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsList>()!;
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

        [JsiiProperty(name: "entitiesMappings", typeJson: "{\"fqn\":\"oci.dataOciCloudGuardDetectorRecipe.DataOciCloudGuardDetectorRecipeDetectorRulesDetailsEntitiesMappingsList\"}")]
        public virtual oci.DataOciCloudGuardDetectorRecipe.DataOciCloudGuardDetectorRecipeDetectorRulesDetailsEntitiesMappingsList EntitiesMappings
        {
            get => GetInstanceProperty<oci.DataOciCloudGuardDetectorRecipe.DataOciCloudGuardDetectorRecipeDetectorRulesDetailsEntitiesMappingsList>()!;
        }

        [JsiiProperty(name: "isConfigurationAllowed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsConfigurationAllowed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Labels
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "recommendation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Recommendation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "riskLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RiskLevel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCloudGuardDetectorRecipe.DataOciCloudGuardDetectorRecipeDetectorRulesDetails\"}", isOptional: true)]
        public virtual oci.DataOciCloudGuardDetectorRecipe.IDataOciCloudGuardDetectorRecipeDetectorRulesDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCloudGuardDetectorRecipe.IDataOciCloudGuardDetectorRecipeDetectorRulesDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
