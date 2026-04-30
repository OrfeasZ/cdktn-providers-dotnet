using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueClassifier
{
    [JsiiInterface(nativeType: typeof(IGlueClassifierConfig), fullyQualifiedName: "aws.glueClassifier.GlueClassifierConfig")]
    public interface IGlueClassifierConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_classifier#name GlueClassifier#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>csv_classifier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_classifier#csv_classifier GlueClassifier#csv_classifier}
        /// </remarks>
        [JsiiProperty(name: "csvClassifier", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierCsvClassifier\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GlueClassifier.IGlueClassifierCsvClassifier? CsvClassifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>grok_classifier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_classifier#grok_classifier GlueClassifier#grok_classifier}
        /// </remarks>
        [JsiiProperty(name: "grokClassifier", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierGrokClassifier\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GlueClassifier.IGlueClassifierGrokClassifier? GrokClassifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_classifier#id GlueClassifier#id}.</summary>
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

        /// <summary>json_classifier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_classifier#json_classifier GlueClassifier#json_classifier}
        /// </remarks>
        [JsiiProperty(name: "jsonClassifier", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierJsonClassifier\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GlueClassifier.IGlueClassifierJsonClassifier? JsonClassifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_classifier#region GlueClassifier#region}
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

        /// <summary>xml_classifier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_classifier#xml_classifier GlueClassifier#xml_classifier}
        /// </remarks>
        [JsiiProperty(name: "xmlClassifier", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierXmlClassifier\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GlueClassifier.IGlueClassifierXmlClassifier? XmlClassifier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueClassifierConfig), fullyQualifiedName: "aws.glueClassifier.GlueClassifierConfig")]
        internal sealed class _Proxy : DeputyBase, aws.GlueClassifier.IGlueClassifierConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_classifier#name GlueClassifier#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>csv_classifier block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_classifier#csv_classifier GlueClassifier#csv_classifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "csvClassifier", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierCsvClassifier\"}", isOptional: true)]
            public aws.GlueClassifier.IGlueClassifierCsvClassifier? CsvClassifier
            {
                get => GetInstanceProperty<aws.GlueClassifier.IGlueClassifierCsvClassifier?>();
            }

            /// <summary>grok_classifier block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_classifier#grok_classifier GlueClassifier#grok_classifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grokClassifier", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierGrokClassifier\"}", isOptional: true)]
            public aws.GlueClassifier.IGlueClassifierGrokClassifier? GrokClassifier
            {
                get => GetInstanceProperty<aws.GlueClassifier.IGlueClassifierGrokClassifier?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_classifier#id GlueClassifier#id}.</summary>
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

            /// <summary>json_classifier block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_classifier#json_classifier GlueClassifier#json_classifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jsonClassifier", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierJsonClassifier\"}", isOptional: true)]
            public aws.GlueClassifier.IGlueClassifierJsonClassifier? JsonClassifier
            {
                get => GetInstanceProperty<aws.GlueClassifier.IGlueClassifierJsonClassifier?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_classifier#region GlueClassifier#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>xml_classifier block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_classifier#xml_classifier GlueClassifier#xml_classifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "xmlClassifier", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierXmlClassifier\"}", isOptional: true)]
            public aws.GlueClassifier.IGlueClassifierXmlClassifier? XmlClassifier
            {
                get => GetInstanceProperty<aws.GlueClassifier.IGlueClassifierXmlClassifier?>();
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
