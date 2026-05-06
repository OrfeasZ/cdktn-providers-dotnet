using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceApplicationTaskSchedule
{
    [JsiiInterface(nativeType: typeof(IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefParentRef), fullyQualifiedName: "oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefParentRef")]
    public interface IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefParentRef
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#parent DataintegrationWorkspaceApplicationTaskSchedule#parent}.</summary>
        [JsiiProperty(name: "parent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Parent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#root_doc_id DataintegrationWorkspaceApplicationTaskSchedule#root_doc_id}.</summary>
        [JsiiProperty(name: "rootDocId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RootDocId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefParentRef), fullyQualifiedName: "oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefParentRef")]
        internal sealed class _Proxy : DeputyBase, oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefParentRef
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#parent DataintegrationWorkspaceApplicationTaskSchedule#parent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Parent
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#root_doc_id DataintegrationWorkspaceApplicationTaskSchedule#root_doc_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rootDocId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RootDocId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
