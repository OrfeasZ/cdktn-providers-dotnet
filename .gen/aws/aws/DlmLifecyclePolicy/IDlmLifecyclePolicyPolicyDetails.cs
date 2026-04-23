using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DlmLifecyclePolicy
{
    [JsiiInterface(nativeType: typeof(IDlmLifecyclePolicyPolicyDetails), fullyQualifiedName: "aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetails")]
    public interface IDlmLifecyclePolicyPolicyDetails
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#action DlmLifecyclePolicy#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsAction? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#copy_tags DlmLifecyclePolicy#copy_tags}.</summary>
        [JsiiProperty(name: "copyTags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CopyTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#create_interval DlmLifecyclePolicy#create_interval}.</summary>
        [JsiiProperty(name: "createInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CreateInterval
        {
            get
            {
                return null;
            }
        }

        /// <summary>event_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#event_source DlmLifecyclePolicy#event_source}
        /// </remarks>
        [JsiiProperty(name: "eventSource", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsEventSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsEventSource? EventSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>exclusions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#exclusions DlmLifecyclePolicy#exclusions}
        /// </remarks>
        [JsiiProperty(name: "exclusions", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsExclusions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsExclusions? Exclusions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#extend_deletion DlmLifecyclePolicy#extend_deletion}.</summary>
        [JsiiProperty(name: "extendDeletion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExtendDeletion
        {
            get
            {
                return null;
            }
        }

        /// <summary>parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#parameters DlmLifecyclePolicy#parameters}
        /// </remarks>
        [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsParameters? Parameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#policy_language DlmLifecyclePolicy#policy_language}.</summary>
        [JsiiProperty(name: "policyLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PolicyLanguage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#policy_type DlmLifecyclePolicy#policy_type}.</summary>
        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PolicyType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#resource_locations DlmLifecyclePolicy#resource_locations}.</summary>
        [JsiiProperty(name: "resourceLocations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ResourceLocations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#resource_type DlmLifecyclePolicy#resource_type}.</summary>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#resource_types DlmLifecyclePolicy#resource_types}.</summary>
        [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ResourceTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#retain_interval DlmLifecyclePolicy#retain_interval}.</summary>
        [JsiiProperty(name: "retainInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetainInterval
        {
            get
            {
                return null;
            }
        }

        /// <summary>schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#schedule DlmLifecyclePolicy#schedule}
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsSchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Schedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#target_tags DlmLifecyclePolicy#target_tags}.</summary>
        [JsiiProperty(name: "targetTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TargetTags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDlmLifecyclePolicyPolicyDetails), fullyQualifiedName: "aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetails")]
        internal sealed class _Proxy : DeputyBase, aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#action DlmLifecyclePolicy#action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsAction\"}", isOptional: true)]
            public aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsAction? Action
            {
                get => GetInstanceProperty<aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsAction?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#copy_tags DlmLifecyclePolicy#copy_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "copyTags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CopyTags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#create_interval DlmLifecyclePolicy#create_interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "createInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CreateInterval
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>event_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#event_source DlmLifecyclePolicy#event_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eventSource", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsEventSource\"}", isOptional: true)]
            public aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsEventSource? EventSource
            {
                get => GetInstanceProperty<aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsEventSource?>();
            }

            /// <summary>exclusions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#exclusions DlmLifecyclePolicy#exclusions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exclusions", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsExclusions\"}", isOptional: true)]
            public aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsExclusions? Exclusions
            {
                get => GetInstanceProperty<aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsExclusions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#extend_deletion DlmLifecyclePolicy#extend_deletion}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "extendDeletion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExtendDeletion
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#parameters DlmLifecyclePolicy#parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsParameters\"}", isOptional: true)]
            public aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsParameters? Parameters
            {
                get => GetInstanceProperty<aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsParameters?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#policy_language DlmLifecyclePolicy#policy_language}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "policyLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PolicyLanguage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#policy_type DlmLifecyclePolicy#policy_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PolicyType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#resource_locations DlmLifecyclePolicy#resource_locations}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceLocations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ResourceLocations
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#resource_type DlmLifecyclePolicy#resource_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#resource_types DlmLifecyclePolicy#resource_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ResourceTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#retain_interval DlmLifecyclePolicy#retain_interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retainInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetainInterval
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#schedule DlmLifecyclePolicy#schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsSchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Schedule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#target_tags DlmLifecyclePolicy#target_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TargetTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
