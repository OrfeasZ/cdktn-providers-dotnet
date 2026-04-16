using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareRateLimits
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareRateLimits.DataCloudflareRateLimitsResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareRateLimits.DataCloudflareRateLimitsResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareRateLimitsResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareRateLimitsResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareRateLimitsResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareRateLimitsResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRateLimits.DataCloudflareRateLimitsResultActionOutputReference\"}")]
        public virtual cloudflare.DataCloudflareRateLimits.DataCloudflareRateLimitsResultActionOutputReference Action
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRateLimits.DataCloudflareRateLimitsResultActionOutputReference>()!;
        }

        [JsiiProperty(name: "bypass", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRateLimits.DataCloudflareRateLimitsResultBypassList\"}")]
        public virtual cloudflare.DataCloudflareRateLimits.DataCloudflareRateLimitsResultBypassList Bypass
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRateLimits.DataCloudflareRateLimitsResultBypassList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Disabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRateLimits.DataCloudflareRateLimitsResultMatchOutputReference\"}")]
        public virtual cloudflare.DataCloudflareRateLimits.DataCloudflareRateLimitsResultMatchOutputReference Match
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRateLimits.DataCloudflareRateLimitsResultMatchOutputReference>()!;
        }

        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Period
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Threshold
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRateLimits.DataCloudflareRateLimitsResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareRateLimits.IDataCloudflareRateLimitsResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRateLimits.IDataCloudflareRateLimitsResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
