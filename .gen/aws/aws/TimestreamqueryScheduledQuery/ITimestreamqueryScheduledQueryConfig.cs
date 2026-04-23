using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreamqueryScheduledQuery
{
    [JsiiInterface(nativeType: typeof(ITimestreamqueryScheduledQueryConfig), fullyQualifiedName: "aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryConfig")]
    public interface ITimestreamqueryScheduledQueryConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#execution_role_arn TimestreamqueryScheduledQuery#execution_role_arn}.</summary>
        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string ExecutionRoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#name TimestreamqueryScheduledQuery#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#query_string TimestreamqueryScheduledQuery#query_string}.</summary>
        [JsiiProperty(name: "queryString", typeJson: "{\"primitive\":\"string\"}")]
        string QueryString
        {
            get;
        }

        /// <summary>error_report_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#error_report_configuration TimestreamqueryScheduledQuery#error_report_configuration}
        /// </remarks>
        [JsiiProperty(name: "errorReportConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryErrorReportConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ErrorReportConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#kms_key_id TimestreamqueryScheduledQuery#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>last_run_summary block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#last_run_summary TimestreamqueryScheduledQuery#last_run_summary}
        /// </remarks>
        [JsiiProperty(name: "lastRunSummary", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryLastRunSummary\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LastRunSummary
        {
            get
            {
                return null;
            }
        }

        /// <summary>notification_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#notification_configuration TimestreamqueryScheduledQuery#notification_configuration}
        /// </remarks>
        [JsiiProperty(name: "notificationConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryNotificationConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NotificationConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>recently_failed_runs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#recently_failed_runs TimestreamqueryScheduledQuery#recently_failed_runs}
        /// </remarks>
        [JsiiProperty(name: "recentlyFailedRuns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryRecentlyFailedRuns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RecentlyFailedRuns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#region TimestreamqueryScheduledQuery#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>schedule_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#schedule_configuration TimestreamqueryScheduledQuery#schedule_configuration}
        /// </remarks>
        [JsiiProperty(name: "scheduleConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryScheduleConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ScheduleConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#tags TimestreamqueryScheduledQuery#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>target_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#target_configuration TimestreamqueryScheduledQuery#target_configuration}
        /// </remarks>
        [JsiiProperty(name: "targetConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryTargetConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TargetConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#timeouts TimestreamqueryScheduledQuery#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITimestreamqueryScheduledQueryConfig), fullyQualifiedName: "aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryConfig")]
        internal sealed class _Proxy : DeputyBase, aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#execution_role_arn TimestreamqueryScheduledQuery#execution_role_arn}.</summary>
            [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ExecutionRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#name TimestreamqueryScheduledQuery#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#query_string TimestreamqueryScheduledQuery#query_string}.</summary>
            [JsiiProperty(name: "queryString", typeJson: "{\"primitive\":\"string\"}")]
            public string QueryString
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>error_report_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#error_report_configuration TimestreamqueryScheduledQuery#error_report_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "errorReportConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryErrorReportConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ErrorReportConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#kms_key_id TimestreamqueryScheduledQuery#kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>last_run_summary block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#last_run_summary TimestreamqueryScheduledQuery#last_run_summary}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lastRunSummary", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryLastRunSummary\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LastRunSummary
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>notification_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#notification_configuration TimestreamqueryScheduledQuery#notification_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notificationConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryNotificationConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NotificationConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>recently_failed_runs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#recently_failed_runs TimestreamqueryScheduledQuery#recently_failed_runs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recentlyFailedRuns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryRecentlyFailedRuns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RecentlyFailedRuns
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#region TimestreamqueryScheduledQuery#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>schedule_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#schedule_configuration TimestreamqueryScheduledQuery#schedule_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scheduleConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryScheduleConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ScheduleConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#tags TimestreamqueryScheduledQuery#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>target_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#target_configuration TimestreamqueryScheduledQuery#target_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryTargetConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TargetConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreamquery_scheduled_query#timeouts TimestreamqueryScheduledQuery#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryTimeouts\"}", isOptional: true)]
            public aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryTimeouts?>();
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
