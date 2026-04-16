using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustRiskBehavior
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustRiskBehavior.DataCloudflareZeroTrustRiskBehaviorBehaviorsMap), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustRiskBehavior.DataCloudflareZeroTrustRiskBehaviorBehaviorsMap", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustRiskBehaviorBehaviorsMap : Io.Cdktn.ComplexMap
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustRiskBehaviorBehaviorsMap(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustRiskBehaviorBehaviorsMap(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustRiskBehaviorBehaviorsMap(DeputyProps props): base(props)
        {
        }

        /// <param name="key">the key of the item to return.</param>
        [JsiiMethod(name: "get", returnsJson: "{\"type\":{\"fqn\":\"cloudflare.dataCloudflareZeroTrustRiskBehavior.DataCloudflareZeroTrustRiskBehaviorBehaviorsOutputReference\"}}", parametersJson: "[{\"docs\":{\"summary\":\"the key of the item to return.\"},\"name\":\"key\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual cloudflare.DataCloudflareZeroTrustRiskBehavior.DataCloudflareZeroTrustRiskBehaviorBehaviorsOutputReference Get(string key)
        {
            return InvokeInstanceMethod<cloudflare.DataCloudflareZeroTrustRiskBehavior.DataCloudflareZeroTrustRiskBehaviorBehaviorsOutputReference>(new System.Type[]{typeof(string)}, new object[]{key})!;
        }
    }
}
