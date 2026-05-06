using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciStackMonitoringMonitoringTemplateAlarmCondition
{
    [JsiiInterface(nativeType: typeof(IDataOciStackMonitoringMonitoringTemplateAlarmConditionConfig), fullyQualifiedName: "oci.dataOciStackMonitoringMonitoringTemplateAlarmCondition.DataOciStackMonitoringMonitoringTemplateAlarmConditionConfig")]
    public interface IDataOciStackMonitoringMonitoringTemplateAlarmConditionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/stack_monitoring_monitoring_template_alarm_condition#alarm_condition_id DataOciStackMonitoringMonitoringTemplateAlarmCondition#alarm_condition_id}.</summary>
        [JsiiProperty(name: "alarmConditionId", typeJson: "{\"primitive\":\"string\"}")]
        string AlarmConditionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/stack_monitoring_monitoring_template_alarm_condition#monitoring_template_id DataOciStackMonitoringMonitoringTemplateAlarmCondition#monitoring_template_id}.</summary>
        [JsiiProperty(name: "monitoringTemplateId", typeJson: "{\"primitive\":\"string\"}")]
        string MonitoringTemplateId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciStackMonitoringMonitoringTemplateAlarmConditionConfig), fullyQualifiedName: "oci.dataOciStackMonitoringMonitoringTemplateAlarmCondition.DataOciStackMonitoringMonitoringTemplateAlarmConditionConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciStackMonitoringMonitoringTemplateAlarmCondition.IDataOciStackMonitoringMonitoringTemplateAlarmConditionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/stack_monitoring_monitoring_template_alarm_condition#alarm_condition_id DataOciStackMonitoringMonitoringTemplateAlarmCondition#alarm_condition_id}.</summary>
            [JsiiProperty(name: "alarmConditionId", typeJson: "{\"primitive\":\"string\"}")]
            public string AlarmConditionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/stack_monitoring_monitoring_template_alarm_condition#monitoring_template_id DataOciStackMonitoringMonitoringTemplateAlarmCondition#monitoring_template_id}.</summary>
            [JsiiProperty(name: "monitoringTemplateId", typeJson: "{\"primitive\":\"string\"}")]
            public string MonitoringTemplateId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
