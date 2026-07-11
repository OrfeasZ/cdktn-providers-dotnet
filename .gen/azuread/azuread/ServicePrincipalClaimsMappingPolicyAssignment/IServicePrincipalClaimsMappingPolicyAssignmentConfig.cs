using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ServicePrincipalClaimsMappingPolicyAssignment
{
    [JsiiInterface(nativeType: typeof(IServicePrincipalClaimsMappingPolicyAssignmentConfig), fullyQualifiedName: "azuread.servicePrincipalClaimsMappingPolicyAssignment.ServicePrincipalClaimsMappingPolicyAssignmentConfig")]
    public interface IServicePrincipalClaimsMappingPolicyAssignmentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>ID of the claims mapping policy to assign.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_claims_mapping_policy_assignment#claims_mapping_policy_id ServicePrincipalClaimsMappingPolicyAssignment#claims_mapping_policy_id}
        /// </remarks>
        [JsiiProperty(name: "claimsMappingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        string ClaimsMappingPolicyId
        {
            get;
        }

        /// <summary>ID of the service principal for which to assign the policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_claims_mapping_policy_assignment#service_principal_id ServicePrincipalClaimsMappingPolicyAssignment#service_principal_id}
        /// </remarks>
        [JsiiProperty(name: "servicePrincipalId", typeJson: "{\"primitive\":\"string\"}")]
        string ServicePrincipalId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_claims_mapping_policy_assignment#id ServicePrincipalClaimsMappingPolicyAssignment#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_claims_mapping_policy_assignment#timeouts ServicePrincipalClaimsMappingPolicyAssignment#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.servicePrincipalClaimsMappingPolicyAssignment.ServicePrincipalClaimsMappingPolicyAssignmentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.ServicePrincipalClaimsMappingPolicyAssignment.IServicePrincipalClaimsMappingPolicyAssignmentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServicePrincipalClaimsMappingPolicyAssignmentConfig), fullyQualifiedName: "azuread.servicePrincipalClaimsMappingPolicyAssignment.ServicePrincipalClaimsMappingPolicyAssignmentConfig")]
        internal sealed class _Proxy : DeputyBase, azuread.ServicePrincipalClaimsMappingPolicyAssignment.IServicePrincipalClaimsMappingPolicyAssignmentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the claims mapping policy to assign.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_claims_mapping_policy_assignment#claims_mapping_policy_id ServicePrincipalClaimsMappingPolicyAssignment#claims_mapping_policy_id}
            /// </remarks>
            [JsiiProperty(name: "claimsMappingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClaimsMappingPolicyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ID of the service principal for which to assign the policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_claims_mapping_policy_assignment#service_principal_id ServicePrincipalClaimsMappingPolicyAssignment#service_principal_id}
            /// </remarks>
            [JsiiProperty(name: "servicePrincipalId", typeJson: "{\"primitive\":\"string\"}")]
            public string ServicePrincipalId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_claims_mapping_policy_assignment#id ServicePrincipalClaimsMappingPolicyAssignment#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_claims_mapping_policy_assignment#timeouts ServicePrincipalClaimsMappingPolicyAssignment#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.servicePrincipalClaimsMappingPolicyAssignment.ServicePrincipalClaimsMappingPolicyAssignmentTimeouts\"}", isOptional: true)]
            public azuread.ServicePrincipalClaimsMappingPolicyAssignment.IServicePrincipalClaimsMappingPolicyAssignmentTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuread.ServicePrincipalClaimsMappingPolicyAssignment.IServicePrincipalClaimsMappingPolicyAssignmentTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
