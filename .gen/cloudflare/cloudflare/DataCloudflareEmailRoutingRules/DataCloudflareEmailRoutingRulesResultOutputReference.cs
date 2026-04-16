using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareEmailRoutingRules
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareEmailRoutingRules.DataCloudflareEmailRoutingRulesResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareEmailRoutingRules.DataCloudflareEmailRoutingRulesResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareEmailRoutingRulesResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareEmailRoutingRulesResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareEmailRoutingRulesResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareEmailRoutingRulesResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "actions", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareEmailRoutingRules.DataCloudflareEmailRoutingRulesResultActionsList\"}")]
        public virtual cloudflare.DataCloudflareEmailRoutingRules.DataCloudflareEmailRoutingRulesResultActionsList Actions
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareEmailRoutingRules.DataCloudflareEmailRoutingRulesResultActionsList>()!;
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

        [JsiiProperty(name: "matchers", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareEmailRoutingRules.DataCloudflareEmailRoutingRulesResultMatchersList\"}")]
        public virtual cloudflare.DataCloudflareEmailRoutingRules.DataCloudflareEmailRoutingRulesResultMatchersList Matchers
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareEmailRoutingRules.DataCloudflareEmailRoutingRulesResultMatchersList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareEmailRoutingRules.DataCloudflareEmailRoutingRulesResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareEmailRoutingRules.IDataCloudflareEmailRoutingRulesResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareEmailRoutingRules.IDataCloudflareEmailRoutingRulesResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
