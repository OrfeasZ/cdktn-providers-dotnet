using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiInterface(nativeType: typeof(IDataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesPollMaxDurationUnit), fullyQualifiedName: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesPollMaxDurationUnit")]
    public interface IDataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesPollMaxDurationUnit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#string_value DataintegrationWorkspaceTask#string_value}.</summary>
        [JsiiProperty(name: "stringValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StringValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesPollMaxDurationUnit), fullyQualifiedName: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesPollMaxDurationUnit")]
        internal sealed class _Proxy : DeputyBase, oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesPollMaxDurationUnit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#string_value DataintegrationWorkspaceTask#string_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stringValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StringValue
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
