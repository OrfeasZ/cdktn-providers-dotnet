using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiInterface(nativeType: typeof(IDataintegrationWorkspaceTaskOpConfigValuesConfigParamValuesConfigParamValue), fullyQualifiedName: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOpConfigValuesConfigParamValuesConfigParamValue")]
    public interface IDataintegrationWorkspaceTaskOpConfigValuesConfigParamValuesConfigParamValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#int_value DataintegrationWorkspaceTask#int_value}.</summary>
        [JsiiProperty(name: "intValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IntValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#object_value DataintegrationWorkspaceTask#object_value}.</summary>
        [JsiiProperty(name: "objectValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ObjectValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#parameter_value DataintegrationWorkspaceTask#parameter_value}.</summary>
        [JsiiProperty(name: "parameterValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ParameterValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>ref_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#ref_value DataintegrationWorkspaceTask#ref_value}
        /// </remarks>
        [JsiiProperty(name: "refValue", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOpConfigValuesConfigParamValuesConfigParamValueRefValue\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskOpConfigValuesConfigParamValuesConfigParamValueRefValue? RefValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>root_object_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#root_object_value DataintegrationWorkspaceTask#root_object_value}
        /// </remarks>
        [JsiiProperty(name: "rootObjectValue", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOpConfigValuesConfigParamValuesConfigParamValueRootObjectValue\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskOpConfigValuesConfigParamValuesConfigParamValueRootObjectValue? RootObjectValue
        {
            get
            {
                return null;
            }
        }

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

        [JsiiTypeProxy(nativeType: typeof(IDataintegrationWorkspaceTaskOpConfigValuesConfigParamValuesConfigParamValue), fullyQualifiedName: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOpConfigValuesConfigParamValuesConfigParamValue")]
        internal sealed class _Proxy : DeputyBase, oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskOpConfigValuesConfigParamValuesConfigParamValue
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#int_value DataintegrationWorkspaceTask#int_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "intValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IntValue
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#object_value DataintegrationWorkspaceTask#object_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "objectValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ObjectValue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#parameter_value DataintegrationWorkspaceTask#parameter_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parameterValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ParameterValue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ref_value block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#ref_value DataintegrationWorkspaceTask#ref_value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "refValue", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOpConfigValuesConfigParamValuesConfigParamValueRefValue\"}", isOptional: true)]
            public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskOpConfigValuesConfigParamValuesConfigParamValueRefValue? RefValue
            {
                get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskOpConfigValuesConfigParamValuesConfigParamValueRefValue?>();
            }

            /// <summary>root_object_value block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#root_object_value DataintegrationWorkspaceTask#root_object_value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rootObjectValue", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOpConfigValuesConfigParamValuesConfigParamValueRootObjectValue\"}", isOptional: true)]
            public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskOpConfigValuesConfigParamValuesConfigParamValueRootObjectValue? RootObjectValue
            {
                get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskOpConfigValuesConfigParamValuesConfigParamValueRootObjectValue?>();
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
