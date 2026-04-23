using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DlmLifecyclePolicy
{
    [JsiiByValue(fqn: "aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsExclusions")]
    public class DlmLifecyclePolicyPolicyDetailsExclusions : aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsExclusions
    {
        private object? _excludeBootVolumes;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#exclude_boot_volumes DlmLifecyclePolicy#exclude_boot_volumes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludeBootVolumes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ExcludeBootVolumes
        {
            get => _excludeBootVolumes;
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
                _excludeBootVolumes = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#exclude_tags DlmLifecyclePolicy#exclude_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludeTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? ExcludeTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#exclude_volume_types DlmLifecyclePolicy#exclude_volume_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludeVolumeTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludeVolumeTypes
        {
            get;
            set;
        }
    }
}
