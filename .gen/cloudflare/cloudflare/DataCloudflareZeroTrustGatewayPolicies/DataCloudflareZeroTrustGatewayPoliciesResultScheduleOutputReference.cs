using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustGatewayPolicies
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultScheduleOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultScheduleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustGatewayPoliciesResultScheduleOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustGatewayPoliciesResultScheduleOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustGatewayPoliciesResultScheduleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustGatewayPoliciesResultScheduleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "fri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mon", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mon
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sun", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sun
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "thu", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Thu
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "wed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Wed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultSchedule\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicies.IDataCloudflareZeroTrustGatewayPoliciesResultSchedule? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicies.IDataCloudflareZeroTrustGatewayPoliciesResultSchedule?>();
            set => SetInstanceProperty(value);
        }
    }
}
