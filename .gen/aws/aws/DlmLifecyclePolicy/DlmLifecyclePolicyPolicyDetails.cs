using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DlmLifecyclePolicy
{
    [JsiiByValue(fqn: "aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetails")]
    public class DlmLifecyclePolicyPolicyDetails : aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetails
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#action DlmLifecyclePolicy#action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsAction\"}", isOptional: true)]
        public aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsAction? Action
        {
            get;
            set;
        }

        private object? _copyTags;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#copy_tags DlmLifecyclePolicy#copy_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "copyTags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? CopyTags
        {
            get => _copyTags;
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
                _copyTags = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#create_interval DlmLifecyclePolicy#create_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "createInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CreateInterval
        {
            get;
            set;
        }

        /// <summary>event_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#event_source DlmLifecyclePolicy#event_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eventSource", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsEventSource\"}", isOptional: true)]
        public aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsEventSource? EventSource
        {
            get;
            set;
        }

        /// <summary>exclusions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#exclusions DlmLifecyclePolicy#exclusions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exclusions", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsExclusions\"}", isOptional: true)]
        public aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsExclusions? Exclusions
        {
            get;
            set;
        }

        private object? _extendDeletion;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#extend_deletion DlmLifecyclePolicy#extend_deletion}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "extendDeletion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ExtendDeletion
        {
            get => _extendDeletion;
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
                _extendDeletion = value;
            }
        }

        /// <summary>parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#parameters DlmLifecyclePolicy#parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsParameters\"}", isOptional: true)]
        public aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsParameters? Parameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#policy_language DlmLifecyclePolicy#policy_language}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policyLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PolicyLanguage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#policy_type DlmLifecyclePolicy#policy_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PolicyType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#resource_locations DlmLifecyclePolicy#resource_locations}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceLocations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ResourceLocations
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#resource_type DlmLifecyclePolicy#resource_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#resource_types DlmLifecyclePolicy#resource_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ResourceTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#retain_interval DlmLifecyclePolicy#retain_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retainInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetainInterval
        {
            get;
            set;
        }

        private object? _schedule;

        /// <summary>schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#schedule DlmLifecyclePolicy#schedule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsSchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Schedule
        {
            get => _schedule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsSchedule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsSchedule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _schedule = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#target_tags DlmLifecyclePolicy#target_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? TargetTags
        {
            get;
            set;
        }
    }
}
