using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceApplicationSchedule
{
    [JsiiInterface(nativeType: typeof(IDataintegrationWorkspaceApplicationScheduleFrequencyDetailsTime), fullyQualifiedName: "oci.dataintegrationWorkspaceApplicationSchedule.DataintegrationWorkspaceApplicationScheduleFrequencyDetailsTime")]
    public interface IDataintegrationWorkspaceApplicationScheduleFrequencyDetailsTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_schedule#hour DataintegrationWorkspaceApplicationSchedule#hour}.</summary>
        [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Hour
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_schedule#minute DataintegrationWorkspaceApplicationSchedule#minute}.</summary>
        [JsiiProperty(name: "minute", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Minute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_schedule#second DataintegrationWorkspaceApplicationSchedule#second}.</summary>
        [JsiiProperty(name: "second", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Second
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataintegrationWorkspaceApplicationScheduleFrequencyDetailsTime), fullyQualifiedName: "oci.dataintegrationWorkspaceApplicationSchedule.DataintegrationWorkspaceApplicationScheduleFrequencyDetailsTime")]
        internal sealed class _Proxy : DeputyBase, oci.DataintegrationWorkspaceApplicationSchedule.IDataintegrationWorkspaceApplicationScheduleFrequencyDetailsTime
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_schedule#hour DataintegrationWorkspaceApplicationSchedule#hour}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Hour
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_schedule#minute DataintegrationWorkspaceApplicationSchedule#minute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minute", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Minute
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_schedule#second DataintegrationWorkspaceApplicationSchedule#second}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "second", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Second
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
