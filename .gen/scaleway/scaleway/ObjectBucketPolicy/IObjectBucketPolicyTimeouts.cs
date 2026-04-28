using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketPolicy
{
    [JsiiInterface(nativeType: typeof(IObjectBucketPolicyTimeouts), fullyQualifiedName: "scaleway.objectBucketPolicy.ObjectBucketPolicyTimeouts")]
    public interface IObjectBucketPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket_policy#default ObjectBucketPolicy#default}.</summary>
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Default
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObjectBucketPolicyTimeouts), fullyQualifiedName: "scaleway.objectBucketPolicy.ObjectBucketPolicyTimeouts")]
        internal sealed class _Proxy : DeputyBase, scaleway.ObjectBucketPolicy.IObjectBucketPolicyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket_policy#default ObjectBucketPolicy#default}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Default
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
