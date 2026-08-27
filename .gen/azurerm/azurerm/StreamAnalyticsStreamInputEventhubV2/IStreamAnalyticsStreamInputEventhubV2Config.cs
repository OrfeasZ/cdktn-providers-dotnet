using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StreamAnalyticsStreamInputEventhubV2
{
    [JsiiInterface(nativeType: typeof(IStreamAnalyticsStreamInputEventhubV2Config), fullyQualifiedName: "azurerm.streamAnalyticsStreamInputEventhubV2.StreamAnalyticsStreamInputEventhubV2Config")]
    public interface IStreamAnalyticsStreamInputEventhubV2Config : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#eventhub_name StreamAnalyticsStreamInputEventhubV2#eventhub_name}.</summary>
        [JsiiProperty(name: "eventhubName", typeJson: "{\"primitive\":\"string\"}")]
        string EventhubName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#name StreamAnalyticsStreamInputEventhubV2#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>serialization block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#serialization StreamAnalyticsStreamInputEventhubV2#serialization}
        /// </remarks>
        [JsiiProperty(name: "serialization", typeJson: "{\"fqn\":\"azurerm.streamAnalyticsStreamInputEventhubV2.StreamAnalyticsStreamInputEventhubV2Serialization\"}")]
        azurerm.StreamAnalyticsStreamInputEventhubV2.IStreamAnalyticsStreamInputEventhubV2Serialization Serialization
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#servicebus_namespace StreamAnalyticsStreamInputEventhubV2#servicebus_namespace}.</summary>
        [JsiiProperty(name: "servicebusNamespace", typeJson: "{\"primitive\":\"string\"}")]
        string ServicebusNamespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#stream_analytics_job_id StreamAnalyticsStreamInputEventhubV2#stream_analytics_job_id}.</summary>
        [JsiiProperty(name: "streamAnalyticsJobId", typeJson: "{\"primitive\":\"string\"}")]
        string StreamAnalyticsJobId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#authentication_mode StreamAnalyticsStreamInputEventhubV2#authentication_mode}.</summary>
        [JsiiProperty(name: "authenticationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthenticationMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#eventhub_consumer_group_name StreamAnalyticsStreamInputEventhubV2#eventhub_consumer_group_name}.</summary>
        [JsiiProperty(name: "eventhubConsumerGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventhubConsumerGroupName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#id StreamAnalyticsStreamInputEventhubV2#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#partition_key StreamAnalyticsStreamInputEventhubV2#partition_key}.</summary>
        [JsiiProperty(name: "partitionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PartitionKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#shared_access_policy_key StreamAnalyticsStreamInputEventhubV2#shared_access_policy_key}.</summary>
        [JsiiProperty(name: "sharedAccessPolicyKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SharedAccessPolicyKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#shared_access_policy_name StreamAnalyticsStreamInputEventhubV2#shared_access_policy_name}.</summary>
        [JsiiProperty(name: "sharedAccessPolicyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SharedAccessPolicyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#timeouts StreamAnalyticsStreamInputEventhubV2#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.streamAnalyticsStreamInputEventhubV2.StreamAnalyticsStreamInputEventhubV2Timeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StreamAnalyticsStreamInputEventhubV2.IStreamAnalyticsStreamInputEventhubV2Timeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStreamAnalyticsStreamInputEventhubV2Config), fullyQualifiedName: "azurerm.streamAnalyticsStreamInputEventhubV2.StreamAnalyticsStreamInputEventhubV2Config")]
        internal sealed class _Proxy : DeputyBase, azurerm.StreamAnalyticsStreamInputEventhubV2.IStreamAnalyticsStreamInputEventhubV2Config
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#eventhub_name StreamAnalyticsStreamInputEventhubV2#eventhub_name}.</summary>
            [JsiiProperty(name: "eventhubName", typeJson: "{\"primitive\":\"string\"}")]
            public string EventhubName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#name StreamAnalyticsStreamInputEventhubV2#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>serialization block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#serialization StreamAnalyticsStreamInputEventhubV2#serialization}
            /// </remarks>
            [JsiiProperty(name: "serialization", typeJson: "{\"fqn\":\"azurerm.streamAnalyticsStreamInputEventhubV2.StreamAnalyticsStreamInputEventhubV2Serialization\"}")]
            public azurerm.StreamAnalyticsStreamInputEventhubV2.IStreamAnalyticsStreamInputEventhubV2Serialization Serialization
            {
                get => GetInstanceProperty<azurerm.StreamAnalyticsStreamInputEventhubV2.IStreamAnalyticsStreamInputEventhubV2Serialization>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#servicebus_namespace StreamAnalyticsStreamInputEventhubV2#servicebus_namespace}.</summary>
            [JsiiProperty(name: "servicebusNamespace", typeJson: "{\"primitive\":\"string\"}")]
            public string ServicebusNamespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#stream_analytics_job_id StreamAnalyticsStreamInputEventhubV2#stream_analytics_job_id}.</summary>
            [JsiiProperty(name: "streamAnalyticsJobId", typeJson: "{\"primitive\":\"string\"}")]
            public string StreamAnalyticsJobId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#authentication_mode StreamAnalyticsStreamInputEventhubV2#authentication_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authenticationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthenticationMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#eventhub_consumer_group_name StreamAnalyticsStreamInputEventhubV2#eventhub_consumer_group_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventhubConsumerGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventhubConsumerGroupName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#id StreamAnalyticsStreamInputEventhubV2#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#partition_key StreamAnalyticsStreamInputEventhubV2#partition_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "partitionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PartitionKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#shared_access_policy_key StreamAnalyticsStreamInputEventhubV2#shared_access_policy_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sharedAccessPolicyKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SharedAccessPolicyKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#shared_access_policy_name StreamAnalyticsStreamInputEventhubV2#shared_access_policy_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sharedAccessPolicyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SharedAccessPolicyName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_stream_input_eventhub_v2#timeouts StreamAnalyticsStreamInputEventhubV2#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.streamAnalyticsStreamInputEventhubV2.StreamAnalyticsStreamInputEventhubV2Timeouts\"}", isOptional: true)]
            public azurerm.StreamAnalyticsStreamInputEventhubV2.IStreamAnalyticsStreamInputEventhubV2Timeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.StreamAnalyticsStreamInputEventhubV2.IStreamAnalyticsStreamInputEventhubV2Timeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
