using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringProcessSet
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringProcessSetSpecificationItems), fullyQualifiedName: "oci.stackMonitoringProcessSet.StackMonitoringProcessSetSpecificationItems")]
    public interface IStackMonitoringProcessSetSpecificationItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_process_set#label StackMonitoringProcessSet#label}.</summary>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Label
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_process_set#process_command StackMonitoringProcessSet#process_command}.</summary>
        [JsiiProperty(name: "processCommand", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProcessCommand
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_process_set#process_line_regex_pattern StackMonitoringProcessSet#process_line_regex_pattern}.</summary>
        [JsiiProperty(name: "processLineRegexPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProcessLineRegexPattern
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_process_set#process_user StackMonitoringProcessSet#process_user}.</summary>
        [JsiiProperty(name: "processUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProcessUser
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringProcessSetSpecificationItems), fullyQualifiedName: "oci.stackMonitoringProcessSet.StackMonitoringProcessSetSpecificationItems")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringProcessSet.IStackMonitoringProcessSetSpecificationItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_process_set#label StackMonitoringProcessSet#label}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Label
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_process_set#process_command StackMonitoringProcessSet#process_command}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "processCommand", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProcessCommand
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_process_set#process_line_regex_pattern StackMonitoringProcessSet#process_line_regex_pattern}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "processLineRegexPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProcessLineRegexPattern
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_process_set#process_user StackMonitoringProcessSet#process_user}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "processUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProcessUser
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
