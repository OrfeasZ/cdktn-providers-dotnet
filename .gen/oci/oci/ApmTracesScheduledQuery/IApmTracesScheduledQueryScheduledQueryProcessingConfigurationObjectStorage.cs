using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmTracesScheduledQuery
{
    [JsiiInterface(nativeType: typeof(IApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage), fullyQualifiedName: "oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage")]
    public interface IApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#bucket ApmTracesScheduledQuery#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Bucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#name_space ApmTracesScheduledQuery#name_space}.</summary>
        [JsiiProperty(name: "nameSpace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NameSpace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#object_name_prefix ApmTracesScheduledQuery#object_name_prefix}.</summary>
        [JsiiProperty(name: "objectNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ObjectNamePrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage), fullyQualifiedName: "oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage")]
        internal sealed class _Proxy : DeputyBase, oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#bucket ApmTracesScheduledQuery#bucket}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Bucket
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#name_space ApmTracesScheduledQuery#name_space}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nameSpace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NameSpace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#object_name_prefix ApmTracesScheduledQuery#object_name_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "objectNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ObjectNamePrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
