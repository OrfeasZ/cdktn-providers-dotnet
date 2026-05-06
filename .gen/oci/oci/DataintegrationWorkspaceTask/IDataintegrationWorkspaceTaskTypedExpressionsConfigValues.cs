using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiInterface(nativeType: typeof(IDataintegrationWorkspaceTaskTypedExpressionsConfigValues), fullyQualifiedName: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTypedExpressionsConfigValues")]
    public interface IDataintegrationWorkspaceTaskTypedExpressionsConfigValues
    {
        /// <summary>config_param_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#config_param_values DataintegrationWorkspaceTask#config_param_values}
        /// </remarks>
        [JsiiProperty(name: "configParamValues", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTypedExpressionsConfigValuesConfigParamValues\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTypedExpressionsConfigValuesConfigParamValues? ConfigParamValues
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
        [JsiiProperty(name: "parentRef", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTypedExpressionsConfigValuesParentRef\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTypedExpressionsConfigValuesParentRef? ParentRef
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataintegrationWorkspaceTaskTypedExpressionsConfigValues), fullyQualifiedName: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTypedExpressionsConfigValues")]
        internal sealed class _Proxy : DeputyBase, oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTypedExpressionsConfigValues
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>config_param_values block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#config_param_values DataintegrationWorkspaceTask#config_param_values}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configParamValues", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTypedExpressionsConfigValuesConfigParamValues\"}", isOptional: true)]
            public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTypedExpressionsConfigValuesConfigParamValues? ConfigParamValues
            {
                get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTypedExpressionsConfigValuesConfigParamValues?>();
            }

            /// <summary>parent_ref block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#parent_ref DataintegrationWorkspaceTask#parent_ref}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parentRef", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTypedExpressionsConfigValuesParentRef\"}", isOptional: true)]
            public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTypedExpressionsConfigValuesParentRef? ParentRef
            {
                get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTypedExpressionsConfigValuesParentRef?>();
            }
        }
    }
}
