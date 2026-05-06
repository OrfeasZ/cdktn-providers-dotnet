using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiInterface(nativeType: typeof(IDataintegrationWorkspaceTaskParametersConfigValues), fullyQualifiedName: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValues")]
    public interface IDataintegrationWorkspaceTaskParametersConfigValues
    {
        /// <summary>config_param_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#config_param_values DataintegrationWorkspaceTask#config_param_values}
        /// </remarks>
        [JsiiProperty(name: "configParamValues", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValues\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesConfigParamValues? ConfigParamValues
        {
            get
            {
                return null;
            }
        }

        /// <summary>parent_ref block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#parent_ref DataintegrationWorkspaceTask#parent_ref}
        /// </remarks>
        [JsiiProperty(name: "parentRef", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesParentRef\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesParentRef? ParentRef
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataintegrationWorkspaceTaskParametersConfigValues), fullyQualifiedName: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValues")]
        internal sealed class _Proxy : DeputyBase, oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValues
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>config_param_values block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#config_param_values DataintegrationWorkspaceTask#config_param_values}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configParamValues", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValues\"}", isOptional: true)]
            public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesConfigParamValues? ConfigParamValues
            {
                get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesConfigParamValues?>();
            }

            /// <summary>parent_ref block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#parent_ref DataintegrationWorkspaceTask#parent_ref}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parentRef", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesParentRef\"}", isOptional: true)]
            public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesParentRef? ParentRef
            {
                get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesParentRef?>();
            }
        }
    }
}
