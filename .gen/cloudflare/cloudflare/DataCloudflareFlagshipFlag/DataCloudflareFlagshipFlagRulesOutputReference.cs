using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareFlagshipFlag
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareFlagshipFlag.DataCloudflareFlagshipFlagRulesOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareFlagshipFlag.DataCloudflareFlagshipFlagRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareFlagshipFlagRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareFlagshipFlagRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareFlagshipFlagRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareFlagshipFlagRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "conditions", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareFlagshipFlag.DataCloudflareFlagshipFlagRulesConditionsList\"}")]
        public virtual cloudflare.DataCloudflareFlagshipFlag.DataCloudflareFlagshipFlagRulesConditionsList Conditions
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareFlagshipFlag.DataCloudflareFlagshipFlagRulesConditionsList>()!;
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rollout", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareFlagshipFlag.DataCloudflareFlagshipFlagRulesRolloutOutputReference\"}")]
        public virtual cloudflare.DataCloudflareFlagshipFlag.DataCloudflareFlagshipFlagRulesRolloutOutputReference Rollout
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareFlagshipFlag.DataCloudflareFlagshipFlagRulesRolloutOutputReference>()!;
        }

        [JsiiProperty(name: "serveVariation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServeVariation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareFlagshipFlag.DataCloudflareFlagshipFlagRules\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareFlagshipFlag.IDataCloudflareFlagshipFlagRules? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareFlagshipFlag.IDataCloudflareFlagshipFlagRules?>();
            set => SetInstanceProperty(value);
        }
    }
}
