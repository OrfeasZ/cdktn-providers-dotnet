using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DlmLifecyclePolicy
{
    [JsiiInterface(nativeType: typeof(IDlmLifecyclePolicyPolicyDetailsExclusions), fullyQualifiedName: "aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsExclusions")]
    public interface IDlmLifecyclePolicyPolicyDetailsExclusions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dlm_lifecycle_policy#exclude_boot_volumes DlmLifecyclePolicy#exclude_boot_volumes}.</summary>
        [JsiiProperty(name: "excludeBootVolumes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExcludeBootVolumes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dlm_lifecycle_policy#exclude_tags DlmLifecyclePolicy#exclude_tags}.</summary>
        [JsiiProperty(name: "excludeTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? ExcludeTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dlm_lifecycle_policy#exclude_volume_types DlmLifecyclePolicy#exclude_volume_types}.</summary>
        [JsiiProperty(name: "excludeVolumeTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludeVolumeTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDlmLifecyclePolicyPolicyDetailsExclusions), fullyQualifiedName: "aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsExclusions")]
        internal sealed class _Proxy : DeputyBase, aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsExclusions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dlm_lifecycle_policy#exclude_boot_volumes DlmLifecyclePolicy#exclude_boot_volumes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludeBootVolumes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExcludeBootVolumes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dlm_lifecycle_policy#exclude_tags DlmLifecyclePolicy#exclude_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludeTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? ExcludeTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dlm_lifecycle_policy#exclude_volume_types DlmLifecyclePolicy#exclude_volume_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludeVolumeTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludeVolumeTypes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
