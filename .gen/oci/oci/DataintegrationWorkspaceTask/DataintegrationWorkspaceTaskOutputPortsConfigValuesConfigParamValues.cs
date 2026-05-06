using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOutputPortsConfigValuesConfigParamValues")]
    public class DataintegrationWorkspaceTaskOutputPortsConfigValuesConfigParamValues : oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskOutputPortsConfigValuesConfigParamValues
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#int_value DataintegrationWorkspaceTask#int_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "intValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IntValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#object_value DataintegrationWorkspaceTask#object_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ObjectValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#parameter_value DataintegrationWorkspaceTask#parameter_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameterValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ParameterValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#ref_value DataintegrationWorkspaceTask#ref_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "refValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RefValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#root_object_value DataintegrationWorkspaceTask#root_object_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rootObjectValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RootObjectValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#string_value DataintegrationWorkspaceTask#string_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stringValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StringValue
        {
            get;
            set;
        }
    }
}
