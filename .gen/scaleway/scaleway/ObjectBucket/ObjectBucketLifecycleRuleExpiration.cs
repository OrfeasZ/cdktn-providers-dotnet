using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucket
{
    [JsiiByValue(fqn: "scaleway.objectBucket.ObjectBucketLifecycleRuleExpiration")]
    public class ObjectBucketLifecycleRuleExpiration : scaleway.ObjectBucket.IObjectBucketLifecycleRuleExpiration
    {
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
            get;
            set;
        }

        /// <summary>Specifies the number of days after object creation when the specific rule action takes effect.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket#days ObjectBucket#days}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Days
        {
            get;
            set;
        }

        private object? _expiredObjectDeleteMarker;

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
            get => _expiredObjectDeleteMarker;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _expiredObjectDeleteMarker = value;
            }
        }
    }
}
