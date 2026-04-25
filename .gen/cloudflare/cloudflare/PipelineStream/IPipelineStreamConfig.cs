using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineStream
{
    [JsiiInterface(nativeType: typeof(IPipelineStreamConfig), fullyQualifiedName: "cloudflare.pipelineStream.PipelineStreamConfig")]
    public interface IPipelineStreamConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Specifies the name of the Stream.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#name PipelineStream#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Specifies the public ID of the account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#account_id PipelineStream#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#format PipelineStream#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"cloudflare.pipelineStream.PipelineStreamFormat\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PipelineStream.IPipelineStreamFormat? Format
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#http PipelineStream#http}.</summary>
        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"cloudflare.pipelineStream.PipelineStreamHttp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PipelineStream.IPipelineStreamHttp? Http
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#schema PipelineStream#schema}.</summary>
        [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"cloudflare.pipelineStream.PipelineStreamSchema\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PipelineStream.IPipelineStreamSchema? Schema
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#worker_binding PipelineStream#worker_binding}.</summary>
        [JsiiProperty(name: "workerBinding", typeJson: "{\"fqn\":\"cloudflare.pipelineStream.PipelineStreamWorkerBinding\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PipelineStream.IPipelineStreamWorkerBinding? WorkerBinding
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipelineStreamConfig), fullyQualifiedName: "cloudflare.pipelineStream.PipelineStreamConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PipelineStream.IPipelineStreamConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the name of the Stream.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#name PipelineStream#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specifies the public ID of the account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#account_id PipelineStream#account_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#format PipelineStream#format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"cloudflare.pipelineStream.PipelineStreamFormat\"}", isOptional: true)]
            public cloudflare.PipelineStream.IPipelineStreamFormat? Format
            {
                get => GetInstanceProperty<cloudflare.PipelineStream.IPipelineStreamFormat?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#http PipelineStream#http}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"cloudflare.pipelineStream.PipelineStreamHttp\"}", isOptional: true)]
            public cloudflare.PipelineStream.IPipelineStreamHttp? Http
            {
                get => GetInstanceProperty<cloudflare.PipelineStream.IPipelineStreamHttp?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#schema PipelineStream#schema}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"cloudflare.pipelineStream.PipelineStreamSchema\"}", isOptional: true)]
            public cloudflare.PipelineStream.IPipelineStreamSchema? Schema
            {
                get => GetInstanceProperty<cloudflare.PipelineStream.IPipelineStreamSchema?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#worker_binding PipelineStream#worker_binding}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "workerBinding", typeJson: "{\"fqn\":\"cloudflare.pipelineStream.PipelineStreamWorkerBinding\"}", isOptional: true)]
            public cloudflare.PipelineStream.IPipelineStreamWorkerBinding? WorkerBinding
            {
                get => GetInstanceProperty<cloudflare.PipelineStream.IPipelineStreamWorkerBinding?>();
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
