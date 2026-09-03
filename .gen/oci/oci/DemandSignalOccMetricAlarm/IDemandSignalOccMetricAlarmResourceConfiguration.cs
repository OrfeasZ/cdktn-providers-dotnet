using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DemandSignalOccMetricAlarm
{
    [JsiiInterface(nativeType: typeof(IDemandSignalOccMetricAlarmResourceConfiguration), fullyQualifiedName: "oci.demandSignalOccMetricAlarm.DemandSignalOccMetricAlarmResourceConfiguration")]
    public interface IDemandSignalOccMetricAlarmResourceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/demand_signal_occ_metric_alarm#resource DemandSignalOccMetricAlarm#resource}.</summary>
        [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}")]
        string Resource
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/demand_signal_occ_metric_alarm#usage_type DemandSignalOccMetricAlarm#usage_type}.</summary>
        [JsiiProperty(name: "usageType", typeJson: "{\"primitive\":\"string\"}")]
        string UsageType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/demand_signal_occ_metric_alarm#compute_hw_generation DemandSignalOccMetricAlarm#compute_hw_generation}.</summary>
        [JsiiProperty(name: "computeHwGeneration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputeHwGeneration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/demand_signal_occ_metric_alarm#hw_generation DemandSignalOccMetricAlarm#hw_generation}.</summary>
        [JsiiProperty(name: "hwGeneration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HwGeneration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/demand_signal_occ_metric_alarm#link_role DemandSignalOccMetricAlarm#link_role}.</summary>
        [JsiiProperty(name: "linkRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LinkRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/demand_signal_occ_metric_alarm#node_type DemandSignalOccMetricAlarm#node_type}.</summary>
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NodeType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/demand_signal_occ_metric_alarm#occ_metric_alarm_provider DemandSignalOccMetricAlarm#occ_metric_alarm_provider}.</summary>
        [JsiiProperty(name: "occMetricAlarmProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OccMetricAlarmProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/demand_signal_occ_metric_alarm#shape DemandSignalOccMetricAlarm#shape}.</summary>
        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Shape
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/demand_signal_occ_metric_alarm#storage_type DemandSignalOccMetricAlarm#storage_type}.</summary>
        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDemandSignalOccMetricAlarmResourceConfiguration), fullyQualifiedName: "oci.demandSignalOccMetricAlarm.DemandSignalOccMetricAlarmResourceConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.DemandSignalOccMetricAlarm.IDemandSignalOccMetricAlarmResourceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/demand_signal_occ_metric_alarm#resource DemandSignalOccMetricAlarm#resource}.</summary>
            [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}")]
            public string Resource
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/demand_signal_occ_metric_alarm#usage_type DemandSignalOccMetricAlarm#usage_type}.</summary>
            [JsiiProperty(name: "usageType", typeJson: "{\"primitive\":\"string\"}")]
            public string UsageType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/demand_signal_occ_metric_alarm#compute_hw_generation DemandSignalOccMetricAlarm#compute_hw_generation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeHwGeneration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputeHwGeneration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/demand_signal_occ_metric_alarm#hw_generation DemandSignalOccMetricAlarm#hw_generation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hwGeneration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HwGeneration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/demand_signal_occ_metric_alarm#link_role DemandSignalOccMetricAlarm#link_role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "linkRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LinkRole
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/demand_signal_occ_metric_alarm#node_type DemandSignalOccMetricAlarm#node_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodeType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/demand_signal_occ_metric_alarm#occ_metric_alarm_provider DemandSignalOccMetricAlarm#occ_metric_alarm_provider}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "occMetricAlarmProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OccMetricAlarmProvider
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/demand_signal_occ_metric_alarm#shape DemandSignalOccMetricAlarm#shape}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Shape
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/demand_signal_occ_metric_alarm#storage_type DemandSignalOccMetricAlarm#storage_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
