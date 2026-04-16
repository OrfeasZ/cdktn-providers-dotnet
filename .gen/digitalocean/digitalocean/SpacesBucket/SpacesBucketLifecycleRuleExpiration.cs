using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.SpacesBucket
{
    [JsiiByValue(fqn: "digitalocean.spacesBucket.SpacesBucketLifecycleRuleExpiration")]
    public class SpacesBucketLifecycleRuleExpiration : digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleExpiration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#date SpacesBucket#date}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Date
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#days SpacesBucket#days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Days
        {
            get;
            set;
        }

        private object? _expiredObjectDeleteMarker;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#expired_object_delete_marker SpacesBucket#expired_object_delete_marker}.</summary>
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
