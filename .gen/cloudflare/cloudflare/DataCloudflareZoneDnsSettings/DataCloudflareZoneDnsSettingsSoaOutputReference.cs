using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZoneDnsSettings
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZoneDnsSettings.DataCloudflareZoneDnsSettingsSoaOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZoneDnsSettings.DataCloudflareZoneDnsSettingsSoaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZoneDnsSettingsSoaOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZoneDnsSettingsSoaOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZoneDnsSettingsSoaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZoneDnsSettingsSoaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "expire", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Expire
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinTtl
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refresh", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Refresh
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "retry", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Retry
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Rname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ttl
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZoneDnsSettings.DataCloudflareZoneDnsSettingsSoa\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZoneDnsSettings.IDataCloudflareZoneDnsSettingsSoa? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZoneDnsSettings.IDataCloudflareZoneDnsSettingsSoa?>();
            set => SetInstanceProperty(value);
        }
    }
}
