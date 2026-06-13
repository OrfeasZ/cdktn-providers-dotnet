using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiGateways
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAiGateways.DataCloudflareAiGatewaysResultSpendLimitsRulesOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAiGateways.DataCloudflareAiGatewaysResultSpendLimitsRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareAiGatewaysResultSpendLimitsRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareAiGatewaysResultSpendLimitsRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareAiGatewaysResultSpendLimitsRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAiGatewaysResultSpendLimitsRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "aiGatewayProvider", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGateways.DataCloudflareAiGatewaysResultSpendLimitsRulesAiGatewayProviderOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiGateways.DataCloudflareAiGatewaysResultSpendLimitsRulesAiGatewayProviderOutputReference AiGatewayProvider
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGateways.DataCloudflareAiGatewaysResultSpendLimitsRulesAiGatewayProviderOutputReference>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Limit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "limitType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LimitType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGateways.DataCloudflareAiGatewaysResultSpendLimitsRulesMetadataMap\"}")]
        public virtual cloudflare.DataCloudflareAiGateways.DataCloudflareAiGatewaysResultSpendLimitsRulesMetadataMap Metadata
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGateways.DataCloudflareAiGatewaysResultSpendLimitsRulesMetadataMap>()!;
        }

        [JsiiProperty(name: "model", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGateways.DataCloudflareAiGatewaysResultSpendLimitsRulesModelOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiGateways.DataCloudflareAiGatewaysResultSpendLimitsRulesModelOutputReference Model
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGateways.DataCloudflareAiGatewaysResultSpendLimitsRulesModelOutputReference>()!;
        }

        [JsiiProperty(name: "technique", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Technique
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "window", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Window
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGateways.DataCloudflareAiGatewaysResultSpendLimitsRules\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAiGateways.IDataCloudflareAiGatewaysResultSpendLimitsRules? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGateways.IDataCloudflareAiGatewaysResultSpendLimitsRules?>();
            set => SetInstanceProperty(value);
        }
    }
}
