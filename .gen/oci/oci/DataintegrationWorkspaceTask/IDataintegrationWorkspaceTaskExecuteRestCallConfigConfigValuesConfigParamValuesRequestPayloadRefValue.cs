using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiInterface(nativeType: typeof(IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValue), fullyQualifiedName: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValue")]
    public interface IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValue
    {
        /// <summary>config_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#config_values DataintegrationWorkspaceTask#config_values}
        /// </remarks>
        [JsiiProperty(name: "configValues", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValues\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValues? ConfigValues
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#key DataintegrationWorkspaceTask#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Key
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#model_type DataintegrationWorkspaceTask#model_type}.</summary>
        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ModelType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValue), fullyQualifiedName: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValue")]
        internal sealed class _Proxy : DeputyBase, oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValue
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>config_values block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#config_values DataintegrationWorkspaceTask#config_values}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configValues", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValues\"}", isOptional: true)]
            public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValues? ConfigValues
            {
                get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValues?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#key DataintegrationWorkspaceTask#key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Key
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#model_type DataintegrationWorkspaceTask#model_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ModelType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
