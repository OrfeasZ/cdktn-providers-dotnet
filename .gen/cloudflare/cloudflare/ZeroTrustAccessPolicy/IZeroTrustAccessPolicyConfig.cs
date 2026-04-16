using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessPolicyConfig), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyConfig")]
    public interface IZeroTrustAccessPolicyConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#account_id ZeroTrustAccessPolicy#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>The action Access will take if a user matches this policy.</summary>
        /// <remarks>
        /// Infrastructure application policies can only use the Allow action.
        /// Available values: "allow", "deny", "non_identity", "bypass".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#decision ZeroTrustAccessPolicy#decision}
        /// </remarks>
        [JsiiProperty(name: "decision", typeJson: "{\"primitive\":\"string\"}")]
        string Decision
        {
            get;
        }

        /// <summary>The name of the Access policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#name ZeroTrustAccessPolicy#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Administrators who can approve a temporary authentication request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#approval_groups ZeroTrustAccessPolicy#approval_groups}
        /// </remarks>
        [JsiiProperty(name: "approvalGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyApprovalGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApprovalGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Requires the user to request access from an administrator at the start of each session.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#approval_required ZeroTrustAccessPolicy#approval_required}
        /// </remarks>
        [JsiiProperty(name: "approvalRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApprovalRequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>The rules that define how users may connect to targets secured by your application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#connection_rules ZeroTrustAccessPolicy#connection_rules}
        /// </remarks>
        [JsiiProperty(name: "connectionRules", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyConnectionRules\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyConnectionRules? ConnectionRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>Rules evaluated with a NOT logical operator.</summary>
        /// <remarks>
        /// To match the policy, a user cannot meet any of the Exclude rules.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#exclude ZeroTrustAccessPolicy#exclude}
        /// </remarks>
        [JsiiProperty(name: "exclude", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExclude\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Exclude
        {
            get
            {
                return null;
            }
        }

        /// <summary>Rules evaluated with an OR logical operator. A user needs to meet only one of the Include rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#include ZeroTrustAccessPolicy#include}
        /// </remarks>
        [JsiiProperty(name: "include", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyInclude\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Include
        {
            get
            {
                return null;
            }
        }

        /// <summary>Require this application to be served in an isolated browser for users matching this policy.</summary>
        /// <remarks>
        /// 'Client Web Isolation' must be on for the account in order to use this feature.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#isolation_required ZeroTrustAccessPolicy#isolation_required}
        /// </remarks>
        [JsiiProperty(name: "isolationRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsolationRequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures multi-factor authentication (MFA) settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#mfa_config ZeroTrustAccessPolicy#mfa_config}
        /// </remarks>
        [JsiiProperty(name: "mfaConfig", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyMfaConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyMfaConfig? MfaConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>A custom message that will appear on the purpose justification screen.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#purpose_justification_prompt ZeroTrustAccessPolicy#purpose_justification_prompt}
        /// </remarks>
        [JsiiProperty(name: "purposeJustificationPrompt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PurposeJustificationPrompt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Require users to enter a justification when they log in to the application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#purpose_justification_required ZeroTrustAccessPolicy#purpose_justification_required}
        /// </remarks>
        [JsiiProperty(name: "purposeJustificationRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PurposeJustificationRequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>Rules evaluated with an AND logical operator.</summary>
        /// <remarks>
        /// To match the policy, a user must meet all of the Require rules.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#require ZeroTrustAccessPolicy#require}
        /// </remarks>
        [JsiiProperty(name: "require", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequire\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Require
        {
            get
            {
                return null;
            }
        }

        /// <summary>The amount of time that tokens issued for the application will be valid.</summary>
        /// <remarks>
        /// Must be in the format <c>300ms</c> or <c>2h45m</c>. Valid time units are: ns, us (or µs), ms, s, m, h.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#session_duration ZeroTrustAccessPolicy#session_duration}
        /// </remarks>
        [JsiiProperty(name: "sessionDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SessionDuration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessPolicyConfig), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#account_id ZeroTrustAccessPolicy#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The action Access will take if a user matches this policy.</summary>
            /// <remarks>
            /// Infrastructure application policies can only use the Allow action.
            /// Available values: "allow", "deny", "non_identity", "bypass".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#decision ZeroTrustAccessPolicy#decision}
            /// </remarks>
            [JsiiProperty(name: "decision", typeJson: "{\"primitive\":\"string\"}")]
            public string Decision
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the Access policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#name ZeroTrustAccessPolicy#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Administrators who can approve a temporary authentication request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#approval_groups ZeroTrustAccessPolicy#approval_groups}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "approvalGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyApprovalGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ApprovalGroups
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Requires the user to request access from an administrator at the start of each session.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#approval_required ZeroTrustAccessPolicy#approval_required}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "approvalRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ApprovalRequired
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The rules that define how users may connect to targets secured by your application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#connection_rules ZeroTrustAccessPolicy#connection_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionRules", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyConnectionRules\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyConnectionRules? ConnectionRules
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyConnectionRules?>();
            }

            /// <summary>Rules evaluated with a NOT logical operator.</summary>
            /// <remarks>
            /// To match the policy, a user cannot meet any of the Exclude rules.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#exclude ZeroTrustAccessPolicy#exclude}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exclude", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExclude\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Exclude
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Rules evaluated with an OR logical operator. A user needs to meet only one of the Include rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#include ZeroTrustAccessPolicy#include}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "include", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyInclude\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Include
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Require this application to be served in an isolated browser for users matching this policy.</summary>
            /// <remarks>
            /// 'Client Web Isolation' must be on for the account in order to use this feature.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#isolation_required ZeroTrustAccessPolicy#isolation_required}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isolationRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsolationRequired
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures multi-factor authentication (MFA) settings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#mfa_config ZeroTrustAccessPolicy#mfa_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mfaConfig", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyMfaConfig\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyMfaConfig? MfaConfig
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyMfaConfig?>();
            }

            /// <summary>A custom message that will appear on the purpose justification screen.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#purpose_justification_prompt ZeroTrustAccessPolicy#purpose_justification_prompt}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "purposeJustificationPrompt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PurposeJustificationPrompt
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Require users to enter a justification when they log in to the application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#purpose_justification_required ZeroTrustAccessPolicy#purpose_justification_required}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "purposeJustificationRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PurposeJustificationRequired
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Rules evaluated with an AND logical operator.</summary>
            /// <remarks>
            /// To match the policy, a user must meet all of the Require rules.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#require ZeroTrustAccessPolicy#require}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "require", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequire\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Require
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The amount of time that tokens issued for the application will be valid.</summary>
            /// <remarks>
            /// Must be in the format <c>300ms</c> or <c>2h45m</c>. Valid time units are: ns, us (or µs), ms, s, m, h.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#session_duration ZeroTrustAccessPolicy#session_duration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sessionDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SessionDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
