using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessGroups
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResultIncludeExternalEvaluationOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResultIncludeExternalEvaluationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustAccessGroupsResultIncludeExternalEvaluationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustAccessGroupsResultIncludeExternalEvaluationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustAccessGroupsResultIncludeExternalEvaluationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessGroupsResultIncludeExternalEvaluationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "evaluateUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EvaluateUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keysUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeysUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResultIncludeExternalEvaluation\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroups.IDataCloudflareZeroTrustAccessGroupsResultIncludeExternalEvaluation? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroups.IDataCloudflareZeroTrustAccessGroupsResultIncludeExternalEvaluation?>();
            set => SetInstanceProperty(value);
        }
    }
}
