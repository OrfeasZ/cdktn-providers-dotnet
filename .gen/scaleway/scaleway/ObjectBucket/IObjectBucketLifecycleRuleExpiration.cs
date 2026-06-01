using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucket
{
    [JsiiInterface(nativeType: typeof(IObjectBucketLifecycleRuleExpiration), fullyQualifiedName: "scaleway.objectBucket.ObjectBucketLifecycleRuleExpiration")]
    public interface IObjectBucketLifecycleRuleExpiration
    {
        /// <summary>Specifies the date the object is to be moved or deleted.</summary>
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

        /// <summary>Specifies whether Scaleway Object will remove a delete marker with no noncurrent versions.</summary>
        /// <remarks>
        /// If set to <c>true</c>, the delete marker will be expired; if set to <c>false</c> the policy takes no action
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket#expired_object_delete_marker ObjectBucket#expired_object_delete_marker}
        /// </remarks>
        [JsiiProperty(name: "expiredObjectDeleteMarker", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExpiredObjectDeleteMarker
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObjectBucketLifecycleRuleExpiration), fullyQualifiedName: "scaleway.objectBucket.ObjectBucketLifecycleRuleExpiration")]
        internal sealed class _Proxy : DeputyBase, scaleway.ObjectBucket.IObjectBucketLifecycleRuleExpiration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the date the object is to be moved or deleted.</summary>
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

            /// <summary>Specifies whether Scaleway Object will remove a delete marker with no noncurrent versions.</summary>
            /// <remarks>
            /// If set to <c>true</c>, the delete marker will be expired; if set to <c>false</c> the policy takes no action
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket#expired_object_delete_marker ObjectBucket#expired_object_delete_marker}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expiredObjectDeleteMarker", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExpiredObjectDeleteMarker
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
