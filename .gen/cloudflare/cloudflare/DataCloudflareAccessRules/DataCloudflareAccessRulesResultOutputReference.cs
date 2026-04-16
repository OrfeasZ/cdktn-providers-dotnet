using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAccessRules
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAccessRules.DataCloudflareAccessRulesResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAccessRules.DataCloudflareAccessRulesResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareAccessRulesResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareAccessRulesResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareAccessRulesResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAccessRulesResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allowedModes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedModes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccessRules.DataCloudflareAccessRulesResultConfigurationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccessRules.DataCloudflareAccessRulesResultConfigurationOutputReference Configuration
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccessRules.DataCloudflareAccessRulesResultConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modifiedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Notes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scope", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccessRules.DataCloudflareAccessRulesResultScopeOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccessRules.DataCloudflareAccessRulesResultScopeOutputReference Scope
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccessRules.DataCloudflareAccessRulesResultScopeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccessRules.DataCloudflareAccessRulesResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAccessRules.IDataCloudflareAccessRulesResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccessRules.IDataCloudflareAccessRulesResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
