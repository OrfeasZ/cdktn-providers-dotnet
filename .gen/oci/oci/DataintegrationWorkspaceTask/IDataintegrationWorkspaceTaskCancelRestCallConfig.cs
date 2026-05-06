using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiInterface(nativeType: typeof(IDataintegrationWorkspaceTaskCancelRestCallConfig), fullyQualifiedName: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskCancelRestCallConfig")]
    public interface IDataintegrationWorkspaceTaskCancelRestCallConfig
    {
        /// <summary>config_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#config_values DataintegrationWorkspaceTask#config_values}
        /// </remarks>
        [JsiiProperty(name: "configValues", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskCancelRestCallConfigConfigValues\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskCancelRestCallConfigConfigValues? ConfigValues
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#method_type DataintegrationWorkspaceTask#method_type}.</summary>
        [JsiiProperty(name: "methodType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MethodType
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#request_headers DataintegrationWorkspaceTask#request_headers}.</summary>
        [JsiiProperty(name: "requestHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? RequestHeaders
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataintegrationWorkspaceTaskCancelRestCallConfig), fullyQualifiedName: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskCancelRestCallConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskCancelRestCallConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>config_values block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#config_values DataintegrationWorkspaceTask#config_values}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configValues", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskCancelRestCallConfigConfigValues\"}", isOptional: true)]
            public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskCancelRestCallConfigConfigValues? ConfigValues
            {
                get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskCancelRestCallConfigConfigValues?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#key DataintegrationWorkspaceTask#key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Key
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#method_type DataintegrationWorkspaceTask#method_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "methodType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MethodType
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#request_headers DataintegrationWorkspaceTask#request_headers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requestHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? RequestHeaders
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
