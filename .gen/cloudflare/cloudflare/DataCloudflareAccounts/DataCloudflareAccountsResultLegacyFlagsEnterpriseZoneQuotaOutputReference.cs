using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAccounts
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAccounts.DataCloudflareAccountsResultLegacyFlagsEnterpriseZoneQuotaOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAccounts.DataCloudflareAccountsResultLegacyFlagsEnterpriseZoneQuotaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAccountsResultLegacyFlagsEnterpriseZoneQuotaOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAccountsResultLegacyFlagsEnterpriseZoneQuotaOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAccountsResultLegacyFlagsEnterpriseZoneQuotaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAccountsResultLegacyFlagsEnterpriseZoneQuotaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "available", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Available
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "current", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Current
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maximum", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Maximum
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccounts.DataCloudflareAccountsResultLegacyFlagsEnterpriseZoneQuota\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAccounts.IDataCloudflareAccountsResultLegacyFlagsEnterpriseZoneQuota? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccounts.IDataCloudflareAccountsResultLegacyFlagsEnterpriseZoneQuota?>();
            set => SetInstanceProperty(value);
        }
    }
}
