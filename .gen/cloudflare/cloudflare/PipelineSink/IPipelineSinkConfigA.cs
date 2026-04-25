using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineSink
{
    [JsiiInterface(nativeType: typeof(IPipelineSinkConfigA), fullyQualifiedName: "cloudflare.pipelineSink.PipelineSinkConfigA")]
    public interface IPipelineSinkConfigA
    {
        /// <summary>Cloudflare Account ID for the bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#account_id PipelineSink#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>R2 Bucket to write to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#bucket PipelineSink#bucket}
        /// </remarks>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#credentials PipelineSink#credentials}.</summary>
        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigCredentials\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PipelineSink.IPipelineSinkConfigCredentials? Credentials
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls filename prefix/suffix and strategy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#file_naming PipelineSink#file_naming}
        /// </remarks>
        [JsiiProperty(name: "fileNaming", typeJson: "{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigFileNaming\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PipelineSink.IPipelineSinkConfigFileNaming? FileNaming
        {
            get
            {
                return null;
            }
        }

        /// <summary>Jurisdiction this bucket is hosted in.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#jurisdiction PipelineSink#jurisdiction}
        /// </remarks>
        [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Jurisdiction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Table namespace.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#namespace PipelineSink#namespace}
        /// </remarks>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Data-layout partitioning for sinks.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#partitioning PipelineSink#partitioning}
        /// </remarks>
        [JsiiProperty(name: "partitioning", typeJson: "{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigPartitioning\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PipelineSink.IPipelineSinkConfigPartitioning? Partitioning
        {
            get
            {
                return null;
            }
        }

        /// <summary>Subpath within the bucket to write to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#path PipelineSink#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>Rolling policy for file sinks (when &amp; why to close a file and open a new one).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#rolling_policy PipelineSink#rolling_policy}
        /// </remarks>
        [JsiiProperty(name: "rollingPolicy", typeJson: "{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigRollingPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PipelineSink.IPipelineSinkConfigRollingPolicy? RollingPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Table name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#table_name PipelineSink#table_name}
        /// </remarks>
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TableName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Authentication token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#token PipelineSink#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Token
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipelineSinkConfigA), fullyQualifiedName: "cloudflare.pipelineSink.PipelineSinkConfigA")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PipelineSink.IPipelineSinkConfigA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Cloudflare Account ID for the bucket.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#account_id PipelineSink#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>R2 Bucket to write to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#bucket PipelineSink#bucket}
            /// </remarks>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#credentials PipelineSink#credentials}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigCredentials\"}", isOptional: true)]
            public cloudflare.PipelineSink.IPipelineSinkConfigCredentials? Credentials
            {
                get => GetInstanceProperty<cloudflare.PipelineSink.IPipelineSinkConfigCredentials?>();
            }

            /// <summary>Controls filename prefix/suffix and strategy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#file_naming PipelineSink#file_naming}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileNaming", typeJson: "{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigFileNaming\"}", isOptional: true)]
            public cloudflare.PipelineSink.IPipelineSinkConfigFileNaming? FileNaming
            {
                get => GetInstanceProperty<cloudflare.PipelineSink.IPipelineSinkConfigFileNaming?>();
            }

            /// <summary>Jurisdiction this bucket is hosted in.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#jurisdiction PipelineSink#jurisdiction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Jurisdiction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Table namespace.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#namespace PipelineSink#namespace}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Data-layout partitioning for sinks.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#partitioning PipelineSink#partitioning}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "partitioning", typeJson: "{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigPartitioning\"}", isOptional: true)]
            public cloudflare.PipelineSink.IPipelineSinkConfigPartitioning? Partitioning
            {
                get => GetInstanceProperty<cloudflare.PipelineSink.IPipelineSinkConfigPartitioning?>();
            }

            /// <summary>Subpath within the bucket to write to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#path PipelineSink#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Rolling policy for file sinks (when &amp; why to close a file and open a new one).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#rolling_policy PipelineSink#rolling_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rollingPolicy", typeJson: "{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigRollingPolicy\"}", isOptional: true)]
            public cloudflare.PipelineSink.IPipelineSinkConfigRollingPolicy? RollingPolicy
            {
                get => GetInstanceProperty<cloudflare.PipelineSink.IPipelineSinkConfigRollingPolicy?>();
            }

            /// <summary>Table name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#table_name PipelineSink#table_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TableName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Authentication token.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#token PipelineSink#token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Token
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
