using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareFlagshipFlag
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareFlagshipFlag.DataCloudflareFlagshipFlagRulesConditionsClausesOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareFlagshipFlag.DataCloudflareFlagshipFlagRulesConditionsClausesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareFlagshipFlagRulesConditionsClausesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareFlagshipFlagRulesConditionsClausesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareFlagshipFlagRulesConditionsClausesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareFlagshipFlagRulesConditionsClausesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Attribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clauses", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareFlagshipFlag.DataCloudflareFlagshipFlagRulesConditionsClausesList\"}")]
        public virtual cloudflare.DataCloudflareFlagshipFlag.DataCloudflareFlagshipFlagRulesConditionsClausesList Clauses
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareFlagshipFlag.DataCloudflareFlagshipFlagRulesConditionsClausesList>()!;
        }

        [JsiiProperty(name: "logicalOperator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogicalOperator
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Operator
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Value
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareFlagshipFlag.DataCloudflareFlagshipFlagRulesConditionsClauses\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareFlagshipFlag.IDataCloudflareFlagshipFlagRulesConditionsClauses? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareFlagshipFlag.IDataCloudflareFlagshipFlagRulesConditionsClauses?>();
            set => SetInstanceProperty(value);
        }
    }
}
