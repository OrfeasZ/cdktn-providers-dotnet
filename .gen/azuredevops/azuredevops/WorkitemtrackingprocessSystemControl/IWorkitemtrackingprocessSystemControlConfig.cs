using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.WorkitemtrackingprocessSystemControl
{
    [JsiiInterface(nativeType: typeof(IWorkitemtrackingprocessSystemControlConfig), fullyQualifiedName: "azuredevops.workitemtrackingprocessSystemControl.WorkitemtrackingprocessSystemControlConfig")]
    public interface IWorkitemtrackingprocessSystemControlConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The ID of the system control (e.g., System.AreaPath, System.IterationPath, System.Reason).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_system_control#control_id WorkitemtrackingprocessSystemControl#control_id}
        /// </remarks>
        [JsiiProperty(name: "controlId", typeJson: "{\"primitive\":\"string\"}")]
        string ControlId
        {
            get;
        }

        /// <summary>The ID of the process.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_system_control#process_id WorkitemtrackingprocessSystemControl#process_id}
        /// </remarks>
        [JsiiProperty(name: "processId", typeJson: "{\"primitive\":\"string\"}")]
        string ProcessId
        {
            get;
        }

        /// <summary>The ID (reference name) of the work item type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_system_control#work_item_type_id WorkitemtrackingprocessSystemControl#work_item_type_id}
        /// </remarks>
        [JsiiProperty(name: "workItemTypeId", typeJson: "{\"primitive\":\"string\"}")]
        string WorkItemTypeId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_system_control#id WorkitemtrackingprocessSystemControl#id}.</summary>
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

        /// <summary>Label for the control.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_system_control#label WorkitemtrackingprocessSystemControl#label}
        /// </remarks>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Label
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_system_control#timeouts WorkitemtrackingprocessSystemControl#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.workitemtrackingprocessSystemControl.WorkitemtrackingprocessSystemControlTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.WorkitemtrackingprocessSystemControl.IWorkitemtrackingprocessSystemControlTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the control should be visible.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_system_control#visible WorkitemtrackingprocessSystemControl#visible}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "visible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Visible
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkitemtrackingprocessSystemControlConfig), fullyQualifiedName: "azuredevops.workitemtrackingprocessSystemControl.WorkitemtrackingprocessSystemControlConfig")]
        internal sealed class _Proxy : DeputyBase, azuredevops.WorkitemtrackingprocessSystemControl.IWorkitemtrackingprocessSystemControlConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the system control (e.g., System.AreaPath, System.IterationPath, System.Reason).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_system_control#control_id WorkitemtrackingprocessSystemControl#control_id}
            /// </remarks>
            [JsiiProperty(name: "controlId", typeJson: "{\"primitive\":\"string\"}")]
            public string ControlId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The ID of the process.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_system_control#process_id WorkitemtrackingprocessSystemControl#process_id}
            /// </remarks>
            [JsiiProperty(name: "processId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProcessId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The ID (reference name) of the work item type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_system_control#work_item_type_id WorkitemtrackingprocessSystemControl#work_item_type_id}
            /// </remarks>
            [JsiiProperty(name: "workItemTypeId", typeJson: "{\"primitive\":\"string\"}")]
            public string WorkItemTypeId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_system_control#id WorkitemtrackingprocessSystemControl#id}.</summary>
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

            /// <summary>Label for the control.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_system_control#label WorkitemtrackingprocessSystemControl#label}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Label
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_system_control#timeouts WorkitemtrackingprocessSystemControl#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.workitemtrackingprocessSystemControl.WorkitemtrackingprocessSystemControlTimeouts\"}", isOptional: true)]
            public azuredevops.WorkitemtrackingprocessSystemControl.IWorkitemtrackingprocessSystemControlTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuredevops.WorkitemtrackingprocessSystemControl.IWorkitemtrackingprocessSystemControlTimeouts?>();
            }

            /// <summary>Whether the control should be visible.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_system_control#visible WorkitemtrackingprocessSystemControl#visible}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "visible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Visible
            {
                get => GetInstanceProperty<object?>();
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
