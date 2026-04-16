using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.MnqSnsTopicSubscription
{
    [JsiiInterface(nativeType: typeof(IMnqSnsTopicSubscriptionConfig), fullyQualifiedName: "scaleway.mnqSnsTopicSubscription.MnqSnsTopicSubscriptionConfig")]
    public interface IMnqSnsTopicSubscriptionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>SNS access key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#access_key MnqSnsTopicSubscription#access_key}
        /// </remarks>
        [JsiiProperty(name: "accessKey", typeJson: "{\"primitive\":\"string\"}")]
        string AccessKey
        {
            get;
        }

        /// <summary>Protocol of the SNS Topic Subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#protocol MnqSnsTopicSubscription#protocol}
        /// </remarks>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>SNS secret key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#secret_key MnqSnsTopicSubscription#secret_key}
        /// </remarks>
        [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}")]
        string SecretKey
        {
            get;
        }

        /// <summary>Endpoint of the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#endpoint MnqSnsTopicSubscription#endpoint}
        /// </remarks>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Endpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#id MnqSnsTopicSubscription#id}.</summary>
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

        /// <summary>The project_id you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#project_id MnqSnsTopicSubscription#project_id}
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

        /// <summary>JSON Redrive policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#redrive_policy MnqSnsTopicSubscription#redrive_policy}
        /// </remarks>
        [JsiiProperty(name: "redrivePolicy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RedrivePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>The region you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#region MnqSnsTopicSubscription#region}
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

        /// <summary>SNS endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#sns_endpoint MnqSnsTopicSubscription#sns_endpoint}
        /// </remarks>
        [JsiiProperty(name: "snsEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SnsEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>ARN of the topic.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#topic_arn MnqSnsTopicSubscription#topic_arn}
        /// </remarks>
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TopicArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the topic.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#topic_id MnqSnsTopicSubscription#topic_id}
        /// </remarks>
        [JsiiProperty(name: "topicId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TopicId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMnqSnsTopicSubscriptionConfig), fullyQualifiedName: "scaleway.mnqSnsTopicSubscription.MnqSnsTopicSubscriptionConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.MnqSnsTopicSubscription.IMnqSnsTopicSubscriptionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>SNS access key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#access_key MnqSnsTopicSubscription#access_key}
            /// </remarks>
            [JsiiProperty(name: "accessKey", typeJson: "{\"primitive\":\"string\"}")]
            public string AccessKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Protocol of the SNS Topic Subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#protocol MnqSnsTopicSubscription#protocol}
            /// </remarks>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>SNS secret key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#secret_key MnqSnsTopicSubscription#secret_key}
            /// </remarks>
            [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Endpoint of the subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#endpoint MnqSnsTopicSubscription#endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Endpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#id MnqSnsTopicSubscription#id}.</summary>
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

            /// <summary>The project_id you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#project_id MnqSnsTopicSubscription#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>JSON Redrive policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#redrive_policy MnqSnsTopicSubscription#redrive_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redrivePolicy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RedrivePolicy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The region you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#region MnqSnsTopicSubscription#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>SNS endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#sns_endpoint MnqSnsTopicSubscription#sns_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "snsEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SnsEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ARN of the topic.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#topic_arn MnqSnsTopicSubscription#topic_arn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TopicArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of the topic.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sns_topic_subscription#topic_id MnqSnsTopicSubscription#topic_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "topicId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TopicId
            {
                get => GetInstanceProperty<string?>();
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
