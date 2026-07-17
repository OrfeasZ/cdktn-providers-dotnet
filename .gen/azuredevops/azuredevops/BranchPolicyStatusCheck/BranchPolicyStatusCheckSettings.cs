using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyStatusCheck
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.branchPolicyStatusCheck.BranchPolicyStatusCheckSettings")]
    public class BranchPolicyStatusCheckSettings : azuredevops.BranchPolicyStatusCheck.IBranchPolicyStatusCheckSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/branch_policy_status_check#name BranchPolicyStatusCheck#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object _scope;

        /// <summary>scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/branch_policy_status_check#scope BranchPolicyStatusCheck#scope}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BranchPolicyStatusCheck.IBranchPolicyStatusCheckSettingsScope" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyStatusCheck.BranchPolicyStatusCheckSettingsScope\"},\"kind\":\"array\"}}]}}")]
        public object Scope
        {
            get => _scope;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azuredevops.BranchPolicyStatusCheck.IBranchPolicyStatusCheckSettingsScope[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuredevops.BranchPolicyStatusCheck.IBranchPolicyStatusCheckSettingsScope).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuredevops.BranchPolicyStatusCheck.IBranchPolicyStatusCheckSettingsScope).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scope = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/branch_policy_status_check#applicability BranchPolicyStatusCheck#applicability}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applicability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Applicability
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/branch_policy_status_check#author_id BranchPolicyStatusCheck#author_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthorId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/branch_policy_status_check#display_name BranchPolicyStatusCheck#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/branch_policy_status_check#filename_patterns BranchPolicyStatusCheck#filename_patterns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filenamePatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? FilenamePatterns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/branch_policy_status_check#genre BranchPolicyStatusCheck#genre}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "genre", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Genre
        {
            get;
            set;
        }

        private object? _invalidateOnUpdate;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/branch_policy_status_check#invalidate_on_update BranchPolicyStatusCheck#invalidate_on_update}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "invalidateOnUpdate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? InvalidateOnUpdate
        {
            get => _invalidateOnUpdate;
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
                _invalidateOnUpdate = value;
            }
        }
    }
}
