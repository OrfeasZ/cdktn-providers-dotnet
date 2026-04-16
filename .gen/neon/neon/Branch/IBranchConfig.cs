using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.Branch
{
    [JsiiInterface(nativeType: typeof(IBranchConfig), fullyQualifiedName: "neon.branch.BranchConfig")]
    public interface IBranchConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Project ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/branch#project_id Branch#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectId
        {
            get;
        }

        /// <summary>Branch name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/branch#name Branch#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the branch to check out.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/branch#parent_id Branch#parent_id}
        /// </remarks>
        [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ParentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Log Sequence Number (LSN) horizon for the data to be present in the new branch. See details: https://neon.tech/docs/reference/glossary/#lsn.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/branch#parent_lsn Branch#parent_lsn}
        /// </remarks>
        [JsiiProperty(name: "parentLsn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ParentLsn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Timestamp horizon for the data to be present in the new branch. **Note**: it's defined as Unix epoch.'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/branch#parent_timestamp Branch#parent_timestamp}
        /// </remarks>
        [JsiiProperty(name: "parentTimestamp", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ParentTimestamp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set to 'yes' to activate, 'no' to deactivate explicitly, and omit to keep the default value.</summary>
        /// <remarks>
        /// Set whether the branch is protected.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/branch#protected Branch#protected}
        /// </remarks>
        [JsiiProperty(name: "protected", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Protected
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBranchConfig), fullyQualifiedName: "neon.branch.BranchConfig")]
        internal sealed class _Proxy : DeputyBase, neon.Branch.IBranchConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Project ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/branch#project_id Branch#project_id}
            /// </remarks>
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Branch name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/branch#name Branch#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of the branch to check out.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/branch#parent_id Branch#parent_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ParentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Log Sequence Number (LSN) horizon for the data to be present in the new branch. See details: https://neon.tech/docs/reference/glossary/#lsn.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/branch#parent_lsn Branch#parent_lsn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parentLsn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ParentLsn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Timestamp horizon for the data to be present in the new branch. **Note**: it's defined as Unix epoch.'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/branch#parent_timestamp Branch#parent_timestamp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parentTimestamp", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ParentTimestamp
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Set to 'yes' to activate, 'no' to deactivate explicitly, and omit to keep the default value.</summary>
            /// <remarks>
            /// Set whether the branch is protected.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/branch#protected Branch#protected}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protected", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Protected
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
