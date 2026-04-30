using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncTask
{
    [JsiiInterface(nativeType: typeof(IDatasyncTaskSchedule), fullyQualifiedName: "aws.datasyncTask.DatasyncTaskSchedule")]
    public interface IDatasyncTaskSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/datasync_task#schedule_expression DatasyncTask#schedule_expression}.</summary>
        [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}")]
        string ScheduleExpression
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/datasync_task#status DatasyncTask#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncTaskSchedule), fullyQualifiedName: "aws.datasyncTask.DatasyncTaskSchedule")]
        internal sealed class _Proxy : DeputyBase, aws.DatasyncTask.IDatasyncTaskSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/datasync_task#schedule_expression DatasyncTask#schedule_expression}.</summary>
            [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}")]
            public string ScheduleExpression
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/datasync_task#status DatasyncTask#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
