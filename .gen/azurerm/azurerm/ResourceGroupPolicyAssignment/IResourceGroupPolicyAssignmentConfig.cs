using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceGroupPolicyAssignment
{
    [JsiiInterface(nativeType: typeof(IResourceGroupPolicyAssignmentConfig), fullyQualifiedName: "azurerm.resourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentConfig")]
    public interface IResourceGroupPolicyAssignmentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#name ResourceGroupPolicyAssignment#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#policy_definition_id ResourceGroupPolicyAssignment#policy_definition_id}.</summary>
        [JsiiProperty(name: "policyDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
        string PolicyDefinitionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#resource_group_id ResourceGroupPolicyAssignment#resource_group_id}.</summary>
        [JsiiProperty(name: "resourceGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#description ResourceGroupPolicyAssignment#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#display_name ResourceGroupPolicyAssignment#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#enforce ResourceGroupPolicyAssignment#enforce}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enforce", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enforce
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#id ResourceGroupPolicyAssignment#id}.</summary>
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

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#identity ResourceGroupPolicyAssignment#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.resourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#location ResourceGroupPolicyAssignment#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Location
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#metadata ResourceGroupPolicyAssignment#metadata}.</summary>
        [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>non_compliance_message block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#non_compliance_message ResourceGroupPolicyAssignment#non_compliance_message}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentNonComplianceMessage" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "nonComplianceMessage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentNonComplianceMessage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NonComplianceMessage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#not_scopes ResourceGroupPolicyAssignment#not_scopes}.</summary>
        [JsiiProperty(name: "notScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NotScopes
        {
            get
            {
                return null;
            }
        }

        /// <summary>overrides block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#overrides ResourceGroupPolicyAssignment#overrides}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentOverrides" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "overrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Overrides
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#parameters ResourceGroupPolicyAssignment#parameters}.</summary>
        [JsiiProperty(name: "parameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Parameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_selectors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#resource_selectors ResourceGroupPolicyAssignment#resource_selectors}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentResourceSelectors" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "resourceSelectors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentResourceSelectors\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceSelectors
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#timeouts ResourceGroupPolicyAssignment#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.resourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResourceGroupPolicyAssignmentConfig), fullyQualifiedName: "azurerm.resourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#name ResourceGroupPolicyAssignment#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#policy_definition_id ResourceGroupPolicyAssignment#policy_definition_id}.</summary>
            [JsiiProperty(name: "policyDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
            public string PolicyDefinitionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#resource_group_id ResourceGroupPolicyAssignment#resource_group_id}.</summary>
            [JsiiProperty(name: "resourceGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#description ResourceGroupPolicyAssignment#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#display_name ResourceGroupPolicyAssignment#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#enforce ResourceGroupPolicyAssignment#enforce}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enforce", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enforce
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#id ResourceGroupPolicyAssignment#id}.</summary>
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

            /// <summary>identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#identity ResourceGroupPolicyAssignment#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.resourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentIdentity\"}", isOptional: true)]
            public azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentIdentity? Identity
            {
                get => GetInstanceProperty<azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentIdentity?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#location ResourceGroupPolicyAssignment#location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Location
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#metadata ResourceGroupPolicyAssignment#metadata}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Metadata
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>non_compliance_message block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#non_compliance_message ResourceGroupPolicyAssignment#non_compliance_message}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentNonComplianceMessage" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nonComplianceMessage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentNonComplianceMessage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NonComplianceMessage
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#not_scopes ResourceGroupPolicyAssignment#not_scopes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NotScopes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>overrides block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#overrides ResourceGroupPolicyAssignment#overrides}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentOverrides" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Overrides
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#parameters ResourceGroupPolicyAssignment#parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Parameters
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>resource_selectors block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#resource_selectors ResourceGroupPolicyAssignment#resource_selectors}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentResourceSelectors" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceSelectors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentResourceSelectors\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceSelectors
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_group_policy_assignment#timeouts ResourceGroupPolicyAssignment#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.resourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentTimeouts\"}", isOptional: true)]
            public azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentTimeouts?>();
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
