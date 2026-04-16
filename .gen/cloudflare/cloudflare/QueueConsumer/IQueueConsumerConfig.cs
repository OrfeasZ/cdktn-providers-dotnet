using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.QueueConsumer
{
    [JsiiInterface(nativeType: typeof(IQueueConsumerConfig), fullyQualifiedName: "cloudflare.queueConsumer.QueueConsumerConfig")]
    public interface IQueueConsumerConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>A Resource identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue_consumer#account_id QueueConsumer#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>A Resource identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue_consumer#queue_id QueueConsumer#queue_id}
        /// </remarks>
        [JsiiProperty(name: "queueId", typeJson: "{\"primitive\":\"string\"}")]
        string QueueId
        {
            get;
        }

        /// <summary>Available values: "worker", "http_pull".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue_consumer#type QueueConsumer#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue_consumer#dead_letter_queue QueueConsumer#dead_letter_queue}.</summary>
        [JsiiProperty(name: "deadLetterQueue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeadLetterQueue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of a Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue_consumer#script_name QueueConsumer#script_name}
        /// </remarks>
        [JsiiProperty(name: "scriptName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScriptName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue_consumer#settings QueueConsumer#settings}.</summary>
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"cloudflare.queueConsumer.QueueConsumerSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.QueueConsumer.IQueueConsumerSettings? Settings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQueueConsumerConfig), fullyQualifiedName: "cloudflare.queueConsumer.QueueConsumerConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.QueueConsumer.IQueueConsumerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A Resource identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue_consumer#account_id QueueConsumer#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A Resource identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue_consumer#queue_id QueueConsumer#queue_id}
            /// </remarks>
            [JsiiProperty(name: "queueId", typeJson: "{\"primitive\":\"string\"}")]
            public string QueueId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Available values: "worker", "http_pull".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue_consumer#type QueueConsumer#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue_consumer#dead_letter_queue QueueConsumer#dead_letter_queue}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deadLetterQueue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeadLetterQueue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of a Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue_consumer#script_name QueueConsumer#script_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scriptName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScriptName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue_consumer#settings QueueConsumer#settings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"cloudflare.queueConsumer.QueueConsumerSettings\"}", isOptional: true)]
            public cloudflare.QueueConsumer.IQueueConsumerSettings? Settings
            {
                get => GetInstanceProperty<cloudflare.QueueConsumer.IQueueConsumerSettings?>();
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
