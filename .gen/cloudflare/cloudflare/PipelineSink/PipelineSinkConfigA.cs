using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineSink
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.pipelineSink.PipelineSinkConfigA")]
    public class PipelineSinkConfigA : cloudflare.PipelineSink.IPipelineSinkConfigA
    {
        /// <summary>Cloudflare Account ID for the bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#account_id PipelineSink#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public string AccountId
        {
            get;
            set;
        }

        /// <summary>R2 Bucket to write to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#bucket PipelineSink#bucket}
        /// </remarks>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#credentials PipelineSink#credentials}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigCredentials\"}", isOptional: true)]
        public cloudflare.PipelineSink.IPipelineSinkConfigCredentials? Credentials
        {
            get;
            set;
        }

        /// <summary>Controls filename prefix/suffix and strategy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#file_naming PipelineSink#file_naming}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileNaming", typeJson: "{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigFileNaming\"}", isOptional: true)]
        public cloudflare.PipelineSink.IPipelineSinkConfigFileNaming? FileNaming
        {
            get;
            set;
        }

        /// <summary>Jurisdiction this bucket is hosted in.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#jurisdiction PipelineSink#jurisdiction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Jurisdiction
        {
            get;
            set;
        }

        /// <summary>Table namespace.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#namespace PipelineSink#namespace}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        /// <summary>Data-layout partitioning for sinks.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#partitioning PipelineSink#partitioning}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "partitioning", typeJson: "{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigPartitioning\"}", isOptional: true)]
        public cloudflare.PipelineSink.IPipelineSinkConfigPartitioning? Partitioning
        {
            get;
            set;
        }

        /// <summary>Subpath within the bucket to write to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#path PipelineSink#path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }

        /// <summary>Rolling policy for file sinks (when &amp; why to close a file and open a new one).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#rolling_policy PipelineSink#rolling_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rollingPolicy", typeJson: "{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigRollingPolicy\"}", isOptional: true)]
        public cloudflare.PipelineSink.IPipelineSinkConfigRollingPolicy? RollingPolicy
        {
            get;
            set;
        }

        /// <summary>Table name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#table_name PipelineSink#table_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TableName
        {
            get;
            set;
        }

        /// <summary>Authentication token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#token PipelineSink#token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Token
        {
            get;
            set;
        }
    }
}
