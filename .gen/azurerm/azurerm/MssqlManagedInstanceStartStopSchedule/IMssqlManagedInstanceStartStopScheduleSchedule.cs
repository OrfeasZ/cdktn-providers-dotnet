using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlManagedInstanceStartStopSchedule
{
    [JsiiInterface(nativeType: typeof(IMssqlManagedInstanceStartStopScheduleSchedule), fullyQualifiedName: "azurerm.mssqlManagedInstanceStartStopSchedule.MssqlManagedInstanceStartStopScheduleSchedule")]
    public interface IMssqlManagedInstanceStartStopScheduleSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_instance_start_stop_schedule#start_day MssqlManagedInstanceStartStopSchedule#start_day}.</summary>
        [JsiiProperty(name: "startDay", typeJson: "{\"primitive\":\"string\"}")]
        string StartDay
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_instance_start_stop_schedule#start_time MssqlManagedInstanceStartStopSchedule#start_time}.</summary>
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        string StartTime
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_instance_start_stop_schedule#stop_day MssqlManagedInstanceStartStopSchedule#stop_day}.</summary>
        [JsiiProperty(name: "stopDay", typeJson: "{\"primitive\":\"string\"}")]
        string StopDay
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_instance_start_stop_schedule#stop_time MssqlManagedInstanceStartStopSchedule#stop_time}.</summary>
        [JsiiProperty(name: "stopTime", typeJson: "{\"primitive\":\"string\"}")]
        string StopTime
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlManagedInstanceStartStopScheduleSchedule), fullyQualifiedName: "azurerm.mssqlManagedInstanceStartStopSchedule.MssqlManagedInstanceStartStopScheduleSchedule")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlManagedInstanceStartStopSchedule.IMssqlManagedInstanceStartStopScheduleSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_instance_start_stop_schedule#start_day MssqlManagedInstanceStartStopSchedule#start_day}.</summary>
            [JsiiProperty(name: "startDay", typeJson: "{\"primitive\":\"string\"}")]
            public string StartDay
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_instance_start_stop_schedule#start_time MssqlManagedInstanceStartStopSchedule#start_time}.</summary>
            [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
            public string StartTime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_instance_start_stop_schedule#stop_day MssqlManagedInstanceStartStopSchedule#stop_day}.</summary>
            [JsiiProperty(name: "stopDay", typeJson: "{\"primitive\":\"string\"}")]
            public string StopDay
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_instance_start_stop_schedule#stop_time MssqlManagedInstanceStartStopSchedule#stop_time}.</summary>
            [JsiiProperty(name: "stopTime", typeJson: "{\"primitive\":\"string\"}")]
            public string StopTime
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
