using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucket
{
    [JsiiInterface(nativeType: typeof(IObjectBucketVersioning), fullyQualifiedName: "scaleway.objectBucket.ObjectBucketVersioning")]
    public interface IObjectBucketVersioning
    {
        /// <summary>Enable versioning. Once you version-enable a bucket, it can never return to an unversioned state.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket#enabled ObjectBucket#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObjectBucketVersioning), fullyQualifiedName: "scaleway.objectBucket.ObjectBucketVersioning")]
        internal sealed class _Proxy : DeputyBase, scaleway.ObjectBucket.IObjectBucketVersioning
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enable versioning. Once you version-enable a bucket, it can never return to an unversioned state.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket#enabled ObjectBucket#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
