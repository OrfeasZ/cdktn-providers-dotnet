using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.GradientaiAgent
{
    [JsiiInterface(nativeType: typeof(IGradientaiAgentModel), fullyQualifiedName: "digitalocean.gradientaiAgent.GradientaiAgentModel")]
    public interface IGradientaiAgentModel
    {
        /// <summary>agreement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#agreement GradientaiAgent#agreement}
        /// </remarks>
        [JsiiProperty(name: "agreement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentModelAgreement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Agreement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Inference name of the model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#inference_name GradientaiAgent#inference_name}
        /// </remarks>
        [JsiiProperty(name: "inferenceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InferenceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Infernce version of the model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#inference_version GradientaiAgent#inference_version}
        /// </remarks>
        [JsiiProperty(name: "inferenceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InferenceVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates if the Model Base is foundational.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#is_foundational GradientaiAgent#is_foundational}
        /// </remarks>
        [JsiiProperty(name: "isFoundational", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsFoundational
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the Knowledge Base.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#name GradientaiAgent#name}
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

        /// <summary>Parent UUID of the Model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#parent_uuid GradientaiAgent#parent_uuid}
        /// </remarks>
        [JsiiProperty(name: "parentUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ParentUuid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Provider of the Model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#provider GradientaiAgent#provider}
        /// </remarks>
        [JsiiProperty(name: "provider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Provider
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates if the Model upload is complete.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#upload_complete GradientaiAgent#upload_complete}
        /// </remarks>
        [JsiiProperty(name: "uploadComplete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UploadComplete
        {
            get
            {
                return null;
            }
        }

        /// <summary>URL of the Model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#url GradientaiAgent#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Url
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of Usecases for the Model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#usecases GradientaiAgent#usecases}
        /// </remarks>
        [JsiiProperty(name: "usecases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Usecases
        {
            get
            {
                return null;
            }
        }

        /// <summary>versions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#versions GradientaiAgent#versions}
        /// </remarks>
        [JsiiProperty(name: "versions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentModelVersions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Versions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGradientaiAgentModel), fullyQualifiedName: "digitalocean.gradientaiAgent.GradientaiAgentModel")]
        internal sealed class _Proxy : DeputyBase, digitalocean.GradientaiAgent.IGradientaiAgentModel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>agreement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#agreement GradientaiAgent#agreement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "agreement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentModelAgreement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Agreement
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Inference name of the model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#inference_name GradientaiAgent#inference_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inferenceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InferenceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Infernce version of the model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#inference_version GradientaiAgent#inference_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inferenceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InferenceVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicates if the Model Base is foundational.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#is_foundational GradientaiAgent#is_foundational}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isFoundational", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsFoundational
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Name of the Knowledge Base.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#name GradientaiAgent#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Parent UUID of the Model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#parent_uuid GradientaiAgent#parent_uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parentUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ParentUuid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Provider of the Model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#provider GradientaiAgent#provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Provider
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicates if the Model upload is complete.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#upload_complete GradientaiAgent#upload_complete}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uploadComplete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UploadComplete
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>URL of the Model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#url GradientaiAgent#url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Url
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>List of Usecases for the Model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#usecases GradientaiAgent#usecases}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usecases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Usecases
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>versions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_agent#versions GradientaiAgent#versions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "versions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentModelVersions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Versions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
