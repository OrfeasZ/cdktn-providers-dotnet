using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskConfigProviderDelegate")]
    public class DataintegrationWorkspaceTaskConfigProviderDelegate : oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskConfigProviderDelegate
    {
        private object? _bindings;

        /// <summary>bindings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#bindings DataintegrationWorkspaceTask#bindings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskConfigProviderDelegateBindings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Bindings
        {
            get => _bindings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskConfigProviderDelegateBindings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskConfigProviderDelegateBindings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _bindings = value;
            }
        }
    }
}
