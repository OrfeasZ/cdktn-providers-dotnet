using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.WorkitemtrackingprocessGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.workitemtrackingprocessGroup.WorkitemtrackingprocessGroupControlContribution")]
    public class WorkitemtrackingprocessGroupControlContribution : azuredevops.WorkitemtrackingprocessGroup.IWorkitemtrackingprocessGroupControlContribution
    {
        /// <summary>The id for the contribution.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/workitemtrackingprocess_group#contribution_id WorkitemtrackingprocessGroup#contribution_id}
        /// </remarks>
        [JsiiProperty(name: "contributionId", typeJson: "{\"primitive\":\"string\"}")]
        public string ContributionId
        {
            get;
            set;
        }

        /// <summary>The height for the contribution.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/workitemtrackingprocess_group#height WorkitemtrackingprocessGroup#height}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "height", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Height
        {
            get;
            set;
        }

        /// <summary>A dictionary holding key value pairs for contribution inputs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/workitemtrackingprocess_group#inputs WorkitemtrackingprocessGroup#inputs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inputs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Inputs
        {
            get;
            set;
        }

        private object? _showOnDeletedWorkItem;

        /// <summary>A value indicating if the contribution should be shown on deleted work item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/workitemtrackingprocess_group#show_on_deleted_work_item WorkitemtrackingprocessGroup#show_on_deleted_work_item}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "showOnDeletedWorkItem", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ShowOnDeletedWorkItem
        {
            get => _showOnDeletedWorkItem;
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
                _showOnDeletedWorkItem = value;
            }
        }
    }
}
