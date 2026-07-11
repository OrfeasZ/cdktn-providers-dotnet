using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.WorkitemtrackingprocessControl
{
    [JsiiInterface(nativeType: typeof(IWorkitemtrackingprocessControlContribution), fullyQualifiedName: "azuredevops.workitemtrackingprocessControl.WorkitemtrackingprocessControlContribution")]
    public interface IWorkitemtrackingprocessControlContribution
    {
        /// <summary>The id for the contribution.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_control#contribution_id WorkitemtrackingprocessControl#contribution_id}
        /// </remarks>
        [JsiiProperty(name: "contributionId", typeJson: "{\"primitive\":\"string\"}")]
        string ContributionId
        {
            get;
        }

        /// <summary>The height for the contribution.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_control#height WorkitemtrackingprocessControl#height}
        /// </remarks>
        [JsiiProperty(name: "height", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Height
        {
            get
            {
                return null;
            }
        }

        /// <summary>A dictionary holding key value pairs for contribution inputs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_control#inputs WorkitemtrackingprocessControl#inputs}
        /// </remarks>
        [JsiiProperty(name: "inputs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Inputs
        {
            get
            {
                return null;
            }
        }

        /// <summary>A value indicating if the contribution should be shown on deleted work item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_control#show_on_deleted_work_item WorkitemtrackingprocessControl#show_on_deleted_work_item}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "showOnDeletedWorkItem", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShowOnDeletedWorkItem
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkitemtrackingprocessControlContribution), fullyQualifiedName: "azuredevops.workitemtrackingprocessControl.WorkitemtrackingprocessControlContribution")]
        internal sealed class _Proxy : DeputyBase, azuredevops.WorkitemtrackingprocessControl.IWorkitemtrackingprocessControlContribution
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The id for the contribution.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_control#contribution_id WorkitemtrackingprocessControl#contribution_id}
            /// </remarks>
            [JsiiProperty(name: "contributionId", typeJson: "{\"primitive\":\"string\"}")]
            public string ContributionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The height for the contribution.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_control#height WorkitemtrackingprocessControl#height}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "height", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Height
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>A dictionary holding key value pairs for contribution inputs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_control#inputs WorkitemtrackingprocessControl#inputs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inputs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Inputs
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>A value indicating if the contribution should be shown on deleted work item.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_control#show_on_deleted_work_item WorkitemtrackingprocessControl#show_on_deleted_work_item}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "showOnDeletedWorkItem", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShowOnDeletedWorkItem
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
