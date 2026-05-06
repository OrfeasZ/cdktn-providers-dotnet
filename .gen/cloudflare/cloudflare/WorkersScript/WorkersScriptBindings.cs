using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.workersScript.WorkersScriptBindings")]
    public class WorkersScriptBindings : cloudflare.WorkersScript.IWorkersScriptBindings
    {
        /// <summary>A JavaScript variable name for the binding.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#name WorkersScript#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The kind of resource that the binding provides.</summary>
        /// <remarks>
        /// Available values: "ai", "analytics_engine", "assets", "browser", "d1", "dispatch_namespace", "durable_object_namespace", "hyperdrive", "json", "kv_namespace", "mtls_certificate", "plain_text", "pipelines", "queue", "r2_bucket", "secret_text", "service", "tail_consumer", "vectorize", "version_metadata", "secrets_store_secret", "secret_key".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#type WorkersScript#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Algorithm-specific key parameters. [Learn more](https://developer.mozilla.org/en-US/docs/Web/API/SubtleCrypto/importKey#algorithm).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#algorithm WorkersScript#algorithm}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Algorithm
        {
            get;
            set;
        }

        /// <summary>R2 bucket to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#bucket_name WorkersScript#bucket_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketName
        {
            get;
            set;
        }

        /// <summary>Identifier of the certificate to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#certificate_id WorkersScript#certificate_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateId
        {
            get;
            set;
        }

        /// <summary>The exported class name of the Durable Object.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#class_name WorkersScript#class_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "className", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClassName
        {
            get;
            set;
        }

        /// <summary>The name of the dataset to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#dataset WorkersScript#dataset}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Dataset
        {
            get;
            set;
        }

        /// <summary>The environment of the script_name to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#environment WorkersScript#environment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Environment
        {
            get;
            set;
        }

        /// <summary>Data format of the key. [Learn more](https://developer.mozilla.org/en-US/docs/Web/API/SubtleCrypto/importKey#format). Available values: "raw", "pkcs8", "spki", "jwk".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#format WorkersScript#format}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Format
        {
            get;
            set;
        }

        /// <summary>Identifier of the D1 database to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#id WorkersScript#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Name of the Vectorize index to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#index_name WorkersScript#index_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IndexName
        {
            get;
            set;
        }

        /// <summary>JSON data to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#json WorkersScript#json}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "json", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Json
        {
            get;
            set;
        }

        /// <summary>Base64-encoded key data. Required if `format` is "raw", "pkcs8", or "spki".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#key_base64 WorkersScript#key_base64}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyBase64
        {
            get;
            set;
        }

        /// <summary>Key data in [JSON Web Key](https://developer.mozilla.org/en-US/docs/Web/API/SubtleCrypto/importKey#json_web_key) format. Required if `format` is "jwk".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#key_jwk WorkersScript#key_jwk}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyJwk", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyJwk
        {
            get;
            set;
        }

        /// <summary>Namespace to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#namespace WorkersScript#namespace}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        /// <summary>Namespace identifier tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#namespace_id WorkersScript#namespace_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NamespaceId
        {
            get;
            set;
        }

        /// <summary>Outbound worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#outbound WorkersScript#outbound}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outbound", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptBindingsOutbound\"}", isOptional: true)]
        public cloudflare.WorkersScript.IWorkersScriptBindingsOutbound? Outbound
        {
            get;
            set;
        }

        /// <summary>Name of the Pipeline to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#pipeline WorkersScript#pipeline}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pipeline", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Pipeline
        {
            get;
            set;
        }

        /// <summary>Name of the Queue to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#queue_name WorkersScript#queue_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queueName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QueueName
        {
            get;
            set;
        }

        /// <summary>The script where the Durable Object is defined, if it is external to this Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#script_name WorkersScript#script_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scriptName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScriptName
        {
            get;
            set;
        }

        /// <summary>Name of the secret in the store.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#secret_name WorkersScript#secret_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretName
        {
            get;
            set;
        }

        /// <summary>Name of Worker to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#service WorkersScript#service}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Service
        {
            get;
            set;
        }

        /// <summary>ID of the store containing the secret.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#store_id WorkersScript#store_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StoreId
        {
            get;
            set;
        }

        /// <summary>The text value to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#text WorkersScript#text}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Text
        {
            get;
            set;
        }

        /// <summary>Allowed operations with the key. [Learn more](https://developer.mozilla.org/en-US/docs/Web/API/SubtleCrypto/importKey#keyUsages).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#usages WorkersScript#usages}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Usages
        {
            get;
            set;
        }

        /// <summary>Name of the Workflow to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#workflow_name WorkersScript#workflow_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workflowName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WorkflowName
        {
            get;
            set;
        }
    }
}
