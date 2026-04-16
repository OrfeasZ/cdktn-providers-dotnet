using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareDnsFirewalls
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareDnsFirewalls.DataCloudflareDnsFirewallsResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareDnsFirewalls.DataCloudflareDnsFirewallsResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareDnsFirewallsResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareDnsFirewallsResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareDnsFirewallsResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareDnsFirewallsResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "attackMitigation", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareDnsFirewalls.DataCloudflareDnsFirewallsResultAttackMitigationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareDnsFirewalls.DataCloudflareDnsFirewallsResultAttackMitigationOutputReference AttackMitigation
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareDnsFirewalls.DataCloudflareDnsFirewallsResultAttackMitigationOutputReference>()!;
        }

        [JsiiProperty(name: "deprecateAnyRequests", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeprecateAnyRequests
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "dnsFirewallIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DnsFirewallIps
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "ecsFallback", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EcsFallback
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maximumCacheTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumCacheTtl
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minimumCacheTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinimumCacheTtl
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "modifiedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "negativeCacheTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NegativeCacheTtl
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ratelimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ratelimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "retries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Retries
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "upstreamIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] UpstreamIps
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareDnsFirewalls.DataCloudflareDnsFirewallsResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareDnsFirewalls.IDataCloudflareDnsFirewallsResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareDnsFirewalls.IDataCloudflareDnsFirewallsResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
