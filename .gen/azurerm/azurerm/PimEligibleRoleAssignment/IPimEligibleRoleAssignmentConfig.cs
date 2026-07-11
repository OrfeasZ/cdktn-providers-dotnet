using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PimEligibleRoleAssignment
{
    [JsiiInterface(nativeType: typeof(IPimEligibleRoleAssignmentConfig), fullyQualifiedName: "azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentConfig")]
    public interface IPimEligibleRoleAssignmentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Object ID of the principal for this eligible role assignment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/pim_eligible_role_assignment#principal_id PimEligibleRoleAssignment#principal_id}
        /// </remarks>
        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
        string PrincipalId
        {
            get;
        }

        /// <summary>Role definition ID for this eligible role assignment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/pim_eligible_role_assignment#role_definition_id PimEligibleRoleAssignment#role_definition_id}
        /// </remarks>
        [JsiiProperty(name: "roleDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
        string RoleDefinitionId
        {
            get;
        }

        /// <summary>Scope for this eligible role assignment, should be a valid resource ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/pim_eligible_role_assignment#scope PimEligibleRoleAssignment#scope}
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        string Scope
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/pim_eligible_role_assignment#condition PimEligibleRoleAssignment#condition}.</summary>
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Condition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/pim_eligible_role_assignment#condition_version PimEligibleRoleAssignment#condition_version}.</summary>
        [JsiiProperty(name: "conditionVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConditionVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/pim_eligible_role_assignment#id PimEligibleRoleAssignment#id}.</summary>
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

        /// <summary>The justification for this eligible role assignment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/pim_eligible_role_assignment#justification PimEligibleRoleAssignment#justification}
        /// </remarks>
        [JsiiProperty(name: "justification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Justification
        {
            get
            {
                return null;
            }
        }

        /// <summary>schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/pim_eligible_role_assignment#schedule PimEligibleRoleAssignment#schedule}
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentSchedule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentSchedule? Schedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>ticket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/pim_eligible_role_assignment#ticket PimEligibleRoleAssignment#ticket}
        /// </remarks>
        [JsiiProperty(name: "ticket", typeJson: "{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentTicket\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentTicket? Ticket
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/pim_eligible_role_assignment#timeouts PimEligibleRoleAssignment#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPimEligibleRoleAssignmentConfig), fullyQualifiedName: "azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Object ID of the principal for this eligible role assignment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/pim_eligible_role_assignment#principal_id PimEligibleRoleAssignment#principal_id}
            /// </remarks>
            [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
            public string PrincipalId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Role definition ID for this eligible role assignment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/pim_eligible_role_assignment#role_definition_id PimEligibleRoleAssignment#role_definition_id}
            /// </remarks>
            [JsiiProperty(name: "roleDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleDefinitionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Scope for this eligible role assignment, should be a valid resource ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/pim_eligible_role_assignment#scope PimEligibleRoleAssignment#scope}
            /// </remarks>
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
            public string Scope
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/pim_eligible_role_assignment#condition PimEligibleRoleAssignment#condition}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Condition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/pim_eligible_role_assignment#condition_version PimEligibleRoleAssignment#condition_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "conditionVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConditionVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/pim_eligible_role_assignment#id PimEligibleRoleAssignment#id}.</summary>
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

            /// <summary>The justification for this eligible role assignment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/pim_eligible_role_assignment#justification PimEligibleRoleAssignment#justification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "justification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Justification
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/pim_eligible_role_assignment#schedule PimEligibleRoleAssignment#schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentSchedule\"}", isOptional: true)]
            public azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentSchedule? Schedule
            {
                get => GetInstanceProperty<azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentSchedule?>();
            }

            /// <summary>ticket block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/pim_eligible_role_assignment#ticket PimEligibleRoleAssignment#ticket}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ticket", typeJson: "{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentTicket\"}", isOptional: true)]
            public azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentTicket? Ticket
            {
                get => GetInstanceProperty<azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentTicket?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/pim_eligible_role_assignment#timeouts PimEligibleRoleAssignment#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentTimeouts\"}", isOptional: true)]
            public azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentTimeouts?>();
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
