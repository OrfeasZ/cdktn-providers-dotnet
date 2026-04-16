using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareApiToken
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareApiToken.DataCloudflareApiTokenConditionOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareApiToken.DataCloudflareApiTokenConditionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareApiTokenConditionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareApiTokenConditionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareApiTokenConditionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareApiTokenConditionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "requestIp", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiToken.DataCloudflareApiTokenConditionRequestIpOutputReference\"}")]
        public virtual cloudflare.DataCloudflareApiToken.DataCloudflareApiTokenConditionRequestIpOutputReference RequestIp
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiToken.DataCloudflareApiTokenConditionRequestIpOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiToken.DataCloudflareApiTokenCondition\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareApiToken.IDataCloudflareApiTokenCondition? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiToken.IDataCloudflareApiTokenCondition?>();
            set => SetInstanceProperty(value);
        }
    }
}
