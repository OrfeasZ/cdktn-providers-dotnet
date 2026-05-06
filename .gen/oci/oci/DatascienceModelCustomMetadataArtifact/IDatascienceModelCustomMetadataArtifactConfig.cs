using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelCustomMetadataArtifact
{
    [JsiiInterface(nativeType: typeof(IDatascienceModelCustomMetadataArtifactConfig), fullyQualifiedName: "oci.datascienceModelCustomMetadataArtifact.DatascienceModelCustomMetadataArtifactConfig")]
    public interface IDatascienceModelCustomMetadataArtifactConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_custom_metadata_artifact#content_length DatascienceModelCustomMetadataArtifact#content_length}.</summary>
        [JsiiProperty(name: "contentLength", typeJson: "{\"primitive\":\"string\"}")]
        string ContentLength
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_custom_metadata_artifact#metadatum_key_name DatascienceModelCustomMetadataArtifact#metadatum_key_name}.</summary>
        [JsiiProperty(name: "metadatumKeyName", typeJson: "{\"primitive\":\"string\"}")]
        string MetadatumKeyName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_custom_metadata_artifact#model_custom_metadatum_artifact DatascienceModelCustomMetadataArtifact#model_custom_metadatum_artifact}.</summary>
        [JsiiProperty(name: "modelCustomMetadatumArtifact", typeJson: "{\"primitive\":\"string\"}")]
        string ModelCustomMetadatumArtifact
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_custom_metadata_artifact#model_id DatascienceModelCustomMetadataArtifact#model_id}.</summary>
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
        string ModelId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_custom_metadata_artifact#content_disposition DatascienceModelCustomMetadataArtifact#content_disposition}.</summary>
        [JsiiProperty(name: "contentDisposition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContentDisposition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_custom_metadata_artifact#id DatascienceModelCustomMetadataArtifact#id}.</summary>
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_custom_metadata_artifact#timeouts DatascienceModelCustomMetadataArtifact#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.datascienceModelCustomMetadataArtifact.DatascienceModelCustomMetadataArtifactTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceModelCustomMetadataArtifact.IDatascienceModelCustomMetadataArtifactTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceModelCustomMetadataArtifactConfig), fullyQualifiedName: "oci.datascienceModelCustomMetadataArtifact.DatascienceModelCustomMetadataArtifactConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceModelCustomMetadataArtifact.IDatascienceModelCustomMetadataArtifactConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_custom_metadata_artifact#content_length DatascienceModelCustomMetadataArtifact#content_length}.</summary>
            [JsiiProperty(name: "contentLength", typeJson: "{\"primitive\":\"string\"}")]
            public string ContentLength
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_custom_metadata_artifact#metadatum_key_name DatascienceModelCustomMetadataArtifact#metadatum_key_name}.</summary>
            [JsiiProperty(name: "metadatumKeyName", typeJson: "{\"primitive\":\"string\"}")]
            public string MetadatumKeyName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_custom_metadata_artifact#model_custom_metadatum_artifact DatascienceModelCustomMetadataArtifact#model_custom_metadatum_artifact}.</summary>
            [JsiiProperty(name: "modelCustomMetadatumArtifact", typeJson: "{\"primitive\":\"string\"}")]
            public string ModelCustomMetadatumArtifact
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_custom_metadata_artifact#model_id DatascienceModelCustomMetadataArtifact#model_id}.</summary>
            [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
            public string ModelId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_custom_metadata_artifact#content_disposition DatascienceModelCustomMetadataArtifact#content_disposition}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contentDisposition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContentDisposition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_custom_metadata_artifact#id DatascienceModelCustomMetadataArtifact#id}.</summary>
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

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_custom_metadata_artifact#timeouts DatascienceModelCustomMetadataArtifact#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.datascienceModelCustomMetadataArtifact.DatascienceModelCustomMetadataArtifactTimeouts\"}", isOptional: true)]
            public oci.DatascienceModelCustomMetadataArtifact.IDatascienceModelCustomMetadataArtifactTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatascienceModelCustomMetadataArtifact.IDatascienceModelCustomMetadataArtifactTimeouts?>();
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
