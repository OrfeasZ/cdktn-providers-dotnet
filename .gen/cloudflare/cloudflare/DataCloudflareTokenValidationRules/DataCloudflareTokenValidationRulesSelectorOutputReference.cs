using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareTokenValidationRules
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareTokenValidationRules.DataCloudflareTokenValidationRulesSelectorOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareTokenValidationRules.DataCloudflareTokenValidationRulesSelectorOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareTokenValidationRulesSelectorOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareTokenValidationRulesSelectorOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareTokenValidationRulesSelectorOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareTokenValidationRulesSelectorOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareTokenValidationRules.DataCloudflareTokenValidationRulesSelectorExcludeList\"}")]
        public virtual cloudflare.DataCloudflareTokenValidationRules.DataCloudflareTokenValidationRulesSelectorExcludeList Exclude
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareTokenValidationRules.DataCloudflareTokenValidationRulesSelectorExcludeList>()!;
        }

        [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareTokenValidationRules.DataCloudflareTokenValidationRulesSelectorIncludeList\"}")]
        public virtual cloudflare.DataCloudflareTokenValidationRules.DataCloudflareTokenValidationRulesSelectorIncludeList Include
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareTokenValidationRules.DataCloudflareTokenValidationRulesSelectorIncludeList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareTokenValidationRules.DataCloudflareTokenValidationRulesSelector\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareTokenValidationRules.IDataCloudflareTokenValidationRulesSelector? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareTokenValidationRules.IDataCloudflareTokenValidationRulesSelector?>();
            set => SetInstanceProperty(value);
        }
    }
}
