using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucket
{
    [JsiiInterface(nativeType: typeof(IObjectBucketLifecycleRuleTransition), fullyQualifiedName: "scaleway.objectBucket.ObjectBucketLifecycleRuleTransition")]
    public interface IObjectBucketLifecycleRuleTransition
    {
        /// <summary>Specifies the Scaleway Object Storage class to which you want the object to transition.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket#storage_class ObjectBucket#storage_class}
        /// </remarks>
        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}")]
        string StorageClass
        {
            get;
        }

        /// <summary>Specifies the date objects are transitioned to the specified storage class.</summary>
        /// <remarks>
        /// The date value must be in RFC3339 full-date format e.g. <c>2023-08-22</c>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket#date ObjectBucket#date}
        /// </remarks>
        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Date
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the number of days after object creation when the specific rule action takes effect.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket#days ObjectBucket#days}
        /// </remarks>
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Days
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObjectBucketLifecycleRuleTransition), fullyQualifiedName: "scaleway.objectBucket.ObjectBucketLifecycleRuleTransition")]
        internal sealed class _Proxy : DeputyBase, scaleway.ObjectBucket.IObjectBucketLifecycleRuleTransition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the Scaleway Object Storage class to which you want the object to transition.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket#storage_class ObjectBucket#storage_class}
            /// </remarks>
            [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageClass
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specifies the date objects are transitioned to the specified storage class.</summary>
            /// <remarks>
            /// The date value must be in RFC3339 full-date format e.g. <c>2023-08-22</c>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket#date ObjectBucket#date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Date
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies the number of days after object creation when the specific rule action takes effect.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket#days ObjectBucket#days}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Days
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
