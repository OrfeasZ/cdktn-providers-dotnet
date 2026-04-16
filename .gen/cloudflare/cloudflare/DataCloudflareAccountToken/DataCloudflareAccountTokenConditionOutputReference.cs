using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAccountToken
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAccountToken.DataCloudflareAccountTokenConditionOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAccountToken.DataCloudflareAccountTokenConditionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAccountTokenConditionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAccountTokenConditionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAccountTokenConditionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAccountTokenConditionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "requestIp", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountToken.DataCloudflareAccountTokenConditionRequestIpOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountToken.DataCloudflareAccountTokenConditionRequestIpOutputReference RequestIp
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountToken.DataCloudflareAccountTokenConditionRequestIpOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountToken.DataCloudflareAccountTokenCondition\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAccountToken.IDataCloudflareAccountTokenCondition? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountToken.IDataCloudflareAccountTokenCondition?>();
            set => SetInstanceProperty(value);
        }
    }
}
