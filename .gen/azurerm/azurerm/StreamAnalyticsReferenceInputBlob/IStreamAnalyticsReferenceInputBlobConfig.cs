using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StreamAnalyticsReferenceInputBlob
{
    [JsiiInterface(nativeType: typeof(IStreamAnalyticsReferenceInputBlobConfig), fullyQualifiedName: "azurerm.streamAnalyticsReferenceInputBlob.StreamAnalyticsReferenceInputBlobConfig")]
    public interface IStreamAnalyticsReferenceInputBlobConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#date_format StreamAnalyticsReferenceInputBlob#date_format}.</summary>
        [JsiiProperty(name: "dateFormat", typeJson: "{\"primitive\":\"string\"}")]
        string DateFormat
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#name StreamAnalyticsReferenceInputBlob#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#path_pattern StreamAnalyticsReferenceInputBlob#path_pattern}.</summary>
        [JsiiProperty(name: "pathPattern", typeJson: "{\"primitive\":\"string\"}")]
        string PathPattern
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#resource_group_name StreamAnalyticsReferenceInputBlob#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>serialization block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#serialization StreamAnalyticsReferenceInputBlob#serialization}
        /// </remarks>
        [JsiiProperty(name: "serialization", typeJson: "{\"fqn\":\"azurerm.streamAnalyticsReferenceInputBlob.StreamAnalyticsReferenceInputBlobSerialization\"}")]
        azurerm.StreamAnalyticsReferenceInputBlob.IStreamAnalyticsReferenceInputBlobSerialization Serialization
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#storage_account_name StreamAnalyticsReferenceInputBlob#storage_account_name}.</summary>
        [JsiiProperty(name: "storageAccountName", typeJson: "{\"primitive\":\"string\"}")]
        string StorageAccountName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#storage_container_name StreamAnalyticsReferenceInputBlob#storage_container_name}.</summary>
        [JsiiProperty(name: "storageContainerName", typeJson: "{\"primitive\":\"string\"}")]
        string StorageContainerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#stream_analytics_job_name StreamAnalyticsReferenceInputBlob#stream_analytics_job_name}.</summary>
        [JsiiProperty(name: "streamAnalyticsJobName", typeJson: "{\"primitive\":\"string\"}")]
        string StreamAnalyticsJobName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#time_format StreamAnalyticsReferenceInputBlob#time_format}.</summary>
        [JsiiProperty(name: "timeFormat", typeJson: "{\"primitive\":\"string\"}")]
        string TimeFormat
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#authentication_mode StreamAnalyticsReferenceInputBlob#authentication_mode}.</summary>
        [JsiiProperty(name: "authenticationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthenticationMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#id StreamAnalyticsReferenceInputBlob#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#storage_account_key StreamAnalyticsReferenceInputBlob#storage_account_key}.</summary>
        [JsiiProperty(name: "storageAccountKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccountKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#timeouts StreamAnalyticsReferenceInputBlob#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.streamAnalyticsReferenceInputBlob.StreamAnalyticsReferenceInputBlobTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StreamAnalyticsReferenceInputBlob.IStreamAnalyticsReferenceInputBlobTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStreamAnalyticsReferenceInputBlobConfig), fullyQualifiedName: "azurerm.streamAnalyticsReferenceInputBlob.StreamAnalyticsReferenceInputBlobConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.StreamAnalyticsReferenceInputBlob.IStreamAnalyticsReferenceInputBlobConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#date_format StreamAnalyticsReferenceInputBlob#date_format}.</summary>
            [JsiiProperty(name: "dateFormat", typeJson: "{\"primitive\":\"string\"}")]
            public string DateFormat
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#name StreamAnalyticsReferenceInputBlob#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#path_pattern StreamAnalyticsReferenceInputBlob#path_pattern}.</summary>
            [JsiiProperty(name: "pathPattern", typeJson: "{\"primitive\":\"string\"}")]
            public string PathPattern
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#resource_group_name StreamAnalyticsReferenceInputBlob#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>serialization block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#serialization StreamAnalyticsReferenceInputBlob#serialization}
            /// </remarks>
            [JsiiProperty(name: "serialization", typeJson: "{\"fqn\":\"azurerm.streamAnalyticsReferenceInputBlob.StreamAnalyticsReferenceInputBlobSerialization\"}")]
            public azurerm.StreamAnalyticsReferenceInputBlob.IStreamAnalyticsReferenceInputBlobSerialization Serialization
            {
                get => GetInstanceProperty<azurerm.StreamAnalyticsReferenceInputBlob.IStreamAnalyticsReferenceInputBlobSerialization>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#storage_account_name StreamAnalyticsReferenceInputBlob#storage_account_name}.</summary>
            [JsiiProperty(name: "storageAccountName", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageAccountName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#storage_container_name StreamAnalyticsReferenceInputBlob#storage_container_name}.</summary>
            [JsiiProperty(name: "storageContainerName", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageContainerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#stream_analytics_job_name StreamAnalyticsReferenceInputBlob#stream_analytics_job_name}.</summary>
            [JsiiProperty(name: "streamAnalyticsJobName", typeJson: "{\"primitive\":\"string\"}")]
            public string StreamAnalyticsJobName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#time_format StreamAnalyticsReferenceInputBlob#time_format}.</summary>
            [JsiiProperty(name: "timeFormat", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeFormat
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#authentication_mode StreamAnalyticsReferenceInputBlob#authentication_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authenticationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthenticationMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#id StreamAnalyticsReferenceInputBlob#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#storage_account_key StreamAnalyticsReferenceInputBlob#storage_account_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccountKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stream_analytics_reference_input_blob#timeouts StreamAnalyticsReferenceInputBlob#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.streamAnalyticsReferenceInputBlob.StreamAnalyticsReferenceInputBlobTimeouts\"}", isOptional: true)]
            public azurerm.StreamAnalyticsReferenceInputBlob.IStreamAnalyticsReferenceInputBlobTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.StreamAnalyticsReferenceInputBlob.IStreamAnalyticsReferenceInputBlobTimeouts?>();
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
