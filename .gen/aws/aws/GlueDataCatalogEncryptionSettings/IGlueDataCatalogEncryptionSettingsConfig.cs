using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueDataCatalogEncryptionSettings
{
    [JsiiInterface(nativeType: typeof(IGlueDataCatalogEncryptionSettingsConfig), fullyQualifiedName: "aws.glueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettingsConfig")]
    public interface IGlueDataCatalogEncryptionSettingsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>data_catalog_encryption_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/glue_data_catalog_encryption_settings#data_catalog_encryption_settings GlueDataCatalogEncryptionSettings#data_catalog_encryption_settings}
        /// </remarks>
        [JsiiProperty(name: "dataCatalogEncryptionSettings", typeJson: "{\"fqn\":\"aws.glueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings\"}")]
        aws.GlueDataCatalogEncryptionSettings.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings DataCatalogEncryptionSettings
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/glue_data_catalog_encryption_settings#catalog_id GlueDataCatalogEncryptionSettings#catalog_id}.</summary>
        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CatalogId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/glue_data_catalog_encryption_settings#id GlueDataCatalogEncryptionSettings#id}.</summary>
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

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/glue_data_catalog_encryption_settings#region GlueDataCatalogEncryptionSettings#region}
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

        [JsiiTypeProxy(nativeType: typeof(IGlueDataCatalogEncryptionSettingsConfig), fullyQualifiedName: "aws.glueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettingsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.GlueDataCatalogEncryptionSettings.IGlueDataCatalogEncryptionSettingsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>data_catalog_encryption_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/glue_data_catalog_encryption_settings#data_catalog_encryption_settings GlueDataCatalogEncryptionSettings#data_catalog_encryption_settings}
            /// </remarks>
            [JsiiProperty(name: "dataCatalogEncryptionSettings", typeJson: "{\"fqn\":\"aws.glueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings\"}")]
            public aws.GlueDataCatalogEncryptionSettings.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings DataCatalogEncryptionSettings
            {
                get => GetInstanceProperty<aws.GlueDataCatalogEncryptionSettings.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/glue_data_catalog_encryption_settings#catalog_id GlueDataCatalogEncryptionSettings#catalog_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CatalogId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/glue_data_catalog_encryption_settings#id GlueDataCatalogEncryptionSettings#id}.</summary>
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

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/glue_data_catalog_encryption_settings#region GlueDataCatalogEncryptionSettings#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
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
