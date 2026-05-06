using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceSchedule
{
    [JsiiInterface(nativeType: typeof(IDatascienceScheduleAction), fullyQualifiedName: "oci.datascienceSchedule.DatascienceScheduleAction")]
    public interface IDatascienceScheduleAction
    {
        /// <summary>action_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#action_details DatascienceSchedule#action_details}
        /// </remarks>
        [JsiiProperty(name: "actionDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetails\"}")]
        oci.DatascienceSchedule.IDatascienceScheduleActionActionDetails ActionDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#action_type DatascienceSchedule#action_type}.</summary>
        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
        string ActionType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceScheduleAction), fullyQualifiedName: "oci.datascienceSchedule.DatascienceScheduleAction")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceSchedule.IDatascienceScheduleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#action_details DatascienceSchedule#action_details}
            /// </remarks>
            [JsiiProperty(name: "actionDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetails\"}")]
            public oci.DatascienceSchedule.IDatascienceScheduleActionActionDetails ActionDetails
            {
                get => GetInstanceProperty<oci.DatascienceSchedule.IDatascienceScheduleActionActionDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#action_type DatascienceSchedule#action_type}.</summary>
            [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
            public string ActionType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
