using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceSchedule
{
    [JsiiInterface(nativeType: typeof(IDatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsParameters), fullyQualifiedName: "oci.datascienceSchedule.DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsParameters")]
    public interface IDatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#name DatascienceSchedule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#value DatascienceSchedule#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsParameters), fullyQualifiedName: "oci.datascienceSchedule.DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsParameters")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#name DatascienceSchedule#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#value DatascienceSchedule#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
