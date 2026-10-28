using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentDataSource
{
    [JsiiInterface(nativeType: typeof(IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationSyncScheduleMonthly), fullyQualifiedName: "aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationSyncScheduleMonthly")]
    public interface IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationSyncScheduleMonthly
    {
        /// <summary>day_of_month block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/bedrockagent_data_source#day_of_month BedrockagentDataSource#day_of_month}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationSyncScheduleMonthlyDayOfMonth" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "dayOfMonth", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationSyncScheduleMonthlyDayOfMonth\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DayOfMonth
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationSyncScheduleMonthly), fullyQualifiedName: "aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationSyncScheduleMonthly")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationSyncScheduleMonthly
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>day_of_month block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/bedrockagent_data_source#day_of_month BedrockagentDataSource#day_of_month}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationSyncScheduleMonthlyDayOfMonth" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dayOfMonth", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationSyncScheduleMonthlyDayOfMonth\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DayOfMonth
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
