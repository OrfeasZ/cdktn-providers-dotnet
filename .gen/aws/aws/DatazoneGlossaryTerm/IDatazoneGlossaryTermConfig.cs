using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazoneGlossaryTerm
{
    [JsiiInterface(nativeType: typeof(IDatazoneGlossaryTermConfig), fullyQualifiedName: "aws.datazoneGlossaryTerm.DatazoneGlossaryTermConfig")]
    public interface IDatazoneGlossaryTermConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/datazone_glossary_term#glossary_identifier DatazoneGlossaryTerm#glossary_identifier}.</summary>
        [JsiiProperty(name: "glossaryIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string GlossaryIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/datazone_glossary_term#name DatazoneGlossaryTerm#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/datazone_glossary_term#domain_identifier DatazoneGlossaryTerm#domain_identifier}.</summary>
        [JsiiProperty(name: "domainIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DomainIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/datazone_glossary_term#long_description DatazoneGlossaryTerm#long_description}.</summary>
        [JsiiProperty(name: "longDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LongDescription
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/datazone_glossary_term#region DatazoneGlossaryTerm#region}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/datazone_glossary_term#short_description DatazoneGlossaryTerm#short_description}.</summary>
        [JsiiProperty(name: "shortDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ShortDescription
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/datazone_glossary_term#status DatazoneGlossaryTerm#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>term_relations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/datazone_glossary_term#term_relations DatazoneGlossaryTerm#term_relations}
        /// </remarks>
        [JsiiProperty(name: "termRelations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazoneGlossaryTerm.DatazoneGlossaryTermTermRelations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TermRelations
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/datazone_glossary_term#timeouts DatazoneGlossaryTerm#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.datazoneGlossaryTerm.DatazoneGlossaryTermTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DatazoneGlossaryTerm.IDatazoneGlossaryTermTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatazoneGlossaryTermConfig), fullyQualifiedName: "aws.datazoneGlossaryTerm.DatazoneGlossaryTermConfig")]
        internal sealed class _Proxy : DeputyBase, aws.DatazoneGlossaryTerm.IDatazoneGlossaryTermConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/datazone_glossary_term#glossary_identifier DatazoneGlossaryTerm#glossary_identifier}.</summary>
            [JsiiProperty(name: "glossaryIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string GlossaryIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/datazone_glossary_term#name DatazoneGlossaryTerm#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/datazone_glossary_term#domain_identifier DatazoneGlossaryTerm#domain_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domainIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DomainIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/datazone_glossary_term#long_description DatazoneGlossaryTerm#long_description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "longDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LongDescription
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/datazone_glossary_term#region DatazoneGlossaryTerm#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/datazone_glossary_term#short_description DatazoneGlossaryTerm#short_description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shortDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ShortDescription
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/datazone_glossary_term#status DatazoneGlossaryTerm#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>term_relations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/datazone_glossary_term#term_relations DatazoneGlossaryTerm#term_relations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "termRelations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazoneGlossaryTerm.DatazoneGlossaryTermTermRelations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TermRelations
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/datazone_glossary_term#timeouts DatazoneGlossaryTerm#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.datazoneGlossaryTerm.DatazoneGlossaryTermTimeouts\"}", isOptional: true)]
            public aws.DatazoneGlossaryTerm.IDatazoneGlossaryTermTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.DatazoneGlossaryTerm.IDatazoneGlossaryTermTimeouts?>();
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
