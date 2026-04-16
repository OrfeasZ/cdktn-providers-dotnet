using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZones
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZones.DataCloudflareZonesResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZones.DataCloudflareZonesResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareZonesResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareZonesResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareZonesResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZonesResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "account", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZones.DataCloudflareZonesResultAccountOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZones.DataCloudflareZonesResultAccountOutputReference Account
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZones.DataCloudflareZonesResultAccountOutputReference>()!;
        }

        [JsiiProperty(name: "activatedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActivatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cnameSuffix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CnameSuffix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "developmentMode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DevelopmentMode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZones.DataCloudflareZonesResultMetaOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZones.DataCloudflareZonesResultMetaOutputReference Meta
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZones.DataCloudflareZonesResultMetaOutputReference>()!;
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

        [JsiiProperty(name: "nameServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NameServers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "originalDnshost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginalDnshost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "originalNameServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OriginalNameServers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "originalRegistrar", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginalRegistrar
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "owner", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZones.DataCloudflareZonesResultOwnerOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZones.DataCloudflareZonesResultOwnerOutputReference Owner
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZones.DataCloudflareZonesResultOwnerOutputReference>()!;
        }

        [JsiiProperty(name: "paused", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Paused
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Permissions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZones.DataCloudflareZonesResultPlanOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZones.DataCloudflareZonesResultPlanOutputReference Plan
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZones.DataCloudflareZonesResultPlanOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenant", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZones.DataCloudflareZonesResultTenantOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZones.DataCloudflareZonesResultTenantOutputReference Tenant
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZones.DataCloudflareZonesResultTenantOutputReference>()!;
        }

        [JsiiProperty(name: "tenantUnit", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZones.DataCloudflareZonesResultTenantUnitOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZones.DataCloudflareZonesResultTenantUnitOutputReference TenantUnit
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZones.DataCloudflareZonesResultTenantUnitOutputReference>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vanityNameServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VanityNameServers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "verificationKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VerificationKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZones.DataCloudflareZonesResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZones.IDataCloudflareZonesResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZones.IDataCloudflareZonesResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
