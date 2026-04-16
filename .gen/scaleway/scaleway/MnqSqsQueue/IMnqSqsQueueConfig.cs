using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.MnqSqsQueue
{
    [JsiiInterface(nativeType: typeof(IMnqSqsQueueConfig), fullyQualifiedName: "scaleway.mnqSqsQueue.MnqSqsQueueConfig")]
    public interface IMnqSqsQueueConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>SQS access key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#access_key MnqSqsQueue#access_key}
        /// </remarks>
        [JsiiProperty(name: "accessKey", typeJson: "{\"primitive\":\"string\"}")]
        string AccessKey
        {
            get;
        }

        /// <summary>SQS secret key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#secret_key MnqSqsQueue#secret_key}
        /// </remarks>
        [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}")]
        string SecretKey
        {
            get;
        }

        /// <summary>Specifies whether to enable content-based deduplication. Allows omitting the deduplication ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#content_based_deduplication MnqSqsQueue#content_based_deduplication}
        /// </remarks>
        [JsiiProperty(name: "contentBasedDeduplication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ContentBasedDeduplication
        {
            get
            {
                return null;
            }
        }

        /// <summary>dead_letter_queue block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#dead_letter_queue MnqSqsQueue#dead_letter_queue}
        /// </remarks>
        [JsiiProperty(name: "deadLetterQueue", typeJson: "{\"fqn\":\"scaleway.mnqSqsQueue.MnqSqsQueueDeadLetterQueue\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.MnqSqsQueue.IMnqSqsQueueDeadLetterQueue? DeadLetterQueue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the queue is a FIFO queue. If true, the queue name must end with .fifo.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#fifo_queue MnqSqsQueue#fifo_queue}
        /// </remarks>
        [JsiiProperty(name: "fifoQueue", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FifoQueue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#id MnqSqsQueue#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of seconds the queue retains a message.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#message_max_age MnqSqsQueue#message_max_age}
        /// </remarks>
        [JsiiProperty(name: "messageMaxAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MessageMaxAge
        {
            get
            {
                return null;
            }
        }

        /// <summary>The maximum size of a message. Should be in bytes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#message_max_size MnqSqsQueue#message_max_size}
        /// </remarks>
        [JsiiProperty(name: "messageMaxSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MessageMaxSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the queue. Conflicts with name_prefix.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#name MnqSqsQueue#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Creates a unique name beginning with the specified prefix. Conflicts with name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#name_prefix MnqSqsQueue#name_prefix}
        /// </remarks>
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>The project_id you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#project_id MnqSqsQueue#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of seconds to wait for a message to arrive in the queue before returning.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#receive_wait_time_seconds MnqSqsQueue#receive_wait_time_seconds}
        /// </remarks>
        [JsiiProperty(name: "receiveWaitTimeSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReceiveWaitTimeSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>The region you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#region MnqSqsQueue#region}
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

        /// <summary>The sqs endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#sqs_endpoint MnqSqsQueue#sqs_endpoint}
        /// </remarks>
        [JsiiProperty(name: "sqsEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SqsEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#timeouts MnqSqsQueue#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.mnqSqsQueue.MnqSqsQueueTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.MnqSqsQueue.IMnqSqsQueueTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of seconds a message is hidden from other consumers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#visibility_timeout_seconds MnqSqsQueue#visibility_timeout_seconds}
        /// </remarks>
        [JsiiProperty(name: "visibilityTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VisibilityTimeoutSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMnqSqsQueueConfig), fullyQualifiedName: "scaleway.mnqSqsQueue.MnqSqsQueueConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.MnqSqsQueue.IMnqSqsQueueConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>SQS access key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#access_key MnqSqsQueue#access_key}
            /// </remarks>
            [JsiiProperty(name: "accessKey", typeJson: "{\"primitive\":\"string\"}")]
            public string AccessKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>SQS secret key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#secret_key MnqSqsQueue#secret_key}
            /// </remarks>
            [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specifies whether to enable content-based deduplication. Allows omitting the deduplication ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#content_based_deduplication MnqSqsQueue#content_based_deduplication}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contentBasedDeduplication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ContentBasedDeduplication
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>dead_letter_queue block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#dead_letter_queue MnqSqsQueue#dead_letter_queue}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deadLetterQueue", typeJson: "{\"fqn\":\"scaleway.mnqSqsQueue.MnqSqsQueueDeadLetterQueue\"}", isOptional: true)]
            public scaleway.MnqSqsQueue.IMnqSqsQueueDeadLetterQueue? DeadLetterQueue
            {
                get => GetInstanceProperty<scaleway.MnqSqsQueue.IMnqSqsQueueDeadLetterQueue?>();
            }

            /// <summary>Whether the queue is a FIFO queue. If true, the queue name must end with .fifo.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#fifo_queue MnqSqsQueue#fifo_queue}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fifoQueue", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FifoQueue
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#id MnqSqsQueue#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of seconds the queue retains a message.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#message_max_age MnqSqsQueue#message_max_age}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "messageMaxAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MessageMaxAge
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The maximum size of a message. Should be in bytes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#message_max_size MnqSqsQueue#message_max_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "messageMaxSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MessageMaxSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The name of the queue. Conflicts with name_prefix.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#name MnqSqsQueue#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Creates a unique name beginning with the specified prefix. Conflicts with name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#name_prefix MnqSqsQueue#name_prefix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The project_id you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#project_id MnqSqsQueue#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of seconds to wait for a message to arrive in the queue before returning.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#receive_wait_time_seconds MnqSqsQueue#receive_wait_time_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "receiveWaitTimeSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReceiveWaitTimeSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The region you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#region MnqSqsQueue#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The sqs endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#sqs_endpoint MnqSqsQueue#sqs_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sqsEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SqsEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#timeouts MnqSqsQueue#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.mnqSqsQueue.MnqSqsQueueTimeouts\"}", isOptional: true)]
            public scaleway.MnqSqsQueue.IMnqSqsQueueTimeouts? Timeouts
            {
                get => GetInstanceProperty<scaleway.MnqSqsQueue.IMnqSqsQueueTimeouts?>();
            }

            /// <summary>The number of seconds a message is hidden from other consumers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#visibility_timeout_seconds MnqSqsQueue#visibility_timeout_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "visibilityTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VisibilityTimeoutSeconds
            {
                get => GetInstanceProperty<double?>();
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
