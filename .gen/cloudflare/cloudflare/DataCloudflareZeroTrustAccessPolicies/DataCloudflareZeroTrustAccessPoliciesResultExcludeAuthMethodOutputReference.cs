using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessPolicies
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultExcludeAuthMethodOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultExcludeAuthMethodOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustAccessPoliciesResultExcludeAuthMethodOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustAccessPoliciesResultExcludeAuthMethodOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustAccessPoliciesResultExcludeAuthMethodOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessPoliciesResultExcludeAuthMethodOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultExcludeAuthMethod\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.IDataCloudflareZeroTrustAccessPoliciesResultExcludeAuthMethod? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.IDataCloudflareZeroTrustAccessPoliciesResultExcludeAuthMethod?>();
            set => SetInstanceProperty(value);
        }
    }
}
