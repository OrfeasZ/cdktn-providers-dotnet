using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiInterface(nativeType: typeof(IWorkerVersionExports), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionExports")]
    public interface IWorkerVersionExports
    {
        /// <summary>For `type: worker`: Marks this entry as a Worker entrypoint export.</summary>
        /// <remarks>
        /// For <c>type: durable-object</c>: Marks this entry as a Durable Object export.
        /// Available values: "worker", "durable-object".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#type WorkerVersion#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>For `type: worker`: Cache override for this entrypoint. Overrides the Worker's global `cache_options.enabled` for this entrypoint only.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#cache WorkerVersion#cache}
        /// </remarks>
        [JsiiProperty(name: "cache", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionExportsCache\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WorkerVersion.IWorkerVersionExportsCache? Cache
        {
            get
            {
                return null;
            }
        }

        /// <summary>For `type: durable-object` and `state: created`: Name of the container (declared in the upload's `metadata.containers`) that backs this Durable Object. When set, the namespace is container-enabled. Valid only on live entries.</summary>
        /// <remarks>
        /// For <c>state: expecting-transfer</c>: Name of the container (declared in the upload's
        /// <c>metadata.containers</c>) that backs this Durable Object once the
        /// transfer settles. Valid only on live entries.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#container WorkerVersion#container}
        /// </remarks>
        [JsiiProperty(name: "container", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Container
        {
            get
            {
                return null;
            }
        }

        /// <summary>For `state: renamed`: The destination class name.</summary>
        /// <remarks>
        /// Must differ from the source class
        /// (the map key) and must be declared as a live (<c>created</c>) entry
        /// in the same <c>exports</c> map. Write-only: never present in GET
        /// responses.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#renamed_to WorkerVersion#renamed_to}
        /// </remarks>
        [JsiiProperty(name: "renamedTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RenamedTo
        {
            get
            {
                return null;
            }
        }

        /// <summary>For `state: created`: Live export. May be omitted; defaults to `created`.</summary>
        /// <remarks>
        /// For <c>state: deleted</c>: Tombstone that deletes the namespace.
        ///
        /// For <c>state: renamed</c>: Tombstone that renames the namespace's class.
        ///
        /// For <c>state: transferred</c>: Tombstone that transfers the namespace to another script.
        ///
        /// For <c>state: expecting-transfer</c>: Target side of a two-phase transfer.
        /// Available values: "created", "deleted", "renamed", "transferred", "expecting-transfer".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#state WorkerVersion#state}
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        /// <summary>For `type: durable-object` and `state: created`: Durable Object storage backend.</summary>
        /// <remarks>
        /// <c>sqlite</c> is the recommended (and
        /// only) backend for new namespaces. <c>legacy-kv</c> is accepted only for
        /// a class whose namespace already exists as KV-backed; the <c>exports</c>
        /// flow never provisions a new <c>legacy-kv</c> namespace.
        ///
        /// For <c>type: durable-object</c> and <c>state: expecting-transfer</c>: Durable Object storage backend. <c>sqlite</c> is the recommended (and
        /// only) backend for new namespaces. <c>legacy-kv</c> is accepted only for
        /// a class whose namespace already exists as KV-backed; the <c>exports</c>
        /// flow never provisions a new <c>legacy-kv</c> namespace.
        /// Available values: "sqlite", "legacy-kv".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#storage WorkerVersion#storage}
        /// </remarks>
        [JsiiProperty(name: "storage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Storage
        {
            get
            {
                return null;
            }
        }

        /// <summary>For `state: expecting-transfer`: The source script name to receive the namespace from.</summary>
        /// <remarks>
        /// Must be
        /// in the same account and dispatch-namespace context. Present on
        /// reads for <c>expecting-transfer</c> entries.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#transfer_from WorkerVersion#transfer_from}
        /// </remarks>
        [JsiiProperty(name: "transferFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransferFrom
        {
            get
            {
                return null;
            }
        }

        /// <summary>For `state: transferred`: The destination script name.</summary>
        /// <remarks>
        /// Must be in the same account and
        /// the same dispatch-namespace context (or both non-dispatch).
        /// Cross-dispatch-namespace transfers are rejected. Write-only:
        /// never present in GET responses.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#transferred_to WorkerVersion#transferred_to}
        /// </remarks>
        [JsiiProperty(name: "transferredTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransferredTo
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerVersionExports), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionExports")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkerVersion.IWorkerVersionExports
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>For `type: worker`: Marks this entry as a Worker entrypoint export.</summary>
            /// <remarks>
            /// For <c>type: durable-object</c>: Marks this entry as a Durable Object export.
            /// Available values: "worker", "durable-object".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#type WorkerVersion#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>For `type: worker`: Cache override for this entrypoint. Overrides the Worker's global `cache_options.enabled` for this entrypoint only.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#cache WorkerVersion#cache}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cache", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionExportsCache\"}", isOptional: true)]
            public cloudflare.WorkerVersion.IWorkerVersionExportsCache? Cache
            {
                get => GetInstanceProperty<cloudflare.WorkerVersion.IWorkerVersionExportsCache?>();
            }

            /// <summary>For `type: durable-object` and `state: created`: Name of the container (declared in the upload's `metadata.containers`) that backs this Durable Object. When set, the namespace is container-enabled. Valid only on live entries.</summary>
            /// <remarks>
            /// For <c>state: expecting-transfer</c>: Name of the container (declared in the upload's
            /// <c>metadata.containers</c>) that backs this Durable Object once the
            /// transfer settles. Valid only on live entries.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#container WorkerVersion#container}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "container", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Container
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For `state: renamed`: The destination class name.</summary>
            /// <remarks>
            /// Must differ from the source class
            /// (the map key) and must be declared as a live (<c>created</c>) entry
            /// in the same <c>exports</c> map. Write-only: never present in GET
            /// responses.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#renamed_to WorkerVersion#renamed_to}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "renamedTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RenamedTo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For `state: created`: Live export. May be omitted; defaults to `created`.</summary>
            /// <remarks>
            /// For <c>state: deleted</c>: Tombstone that deletes the namespace.
            ///
            /// For <c>state: renamed</c>: Tombstone that renames the namespace's class.
            ///
            /// For <c>state: transferred</c>: Tombstone that transfers the namespace to another script.
            ///
            /// For <c>state: expecting-transfer</c>: Target side of a two-phase transfer.
            /// Available values: "created", "deleted", "renamed", "transferred", "expecting-transfer".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#state WorkerVersion#state}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For `type: durable-object` and `state: created`: Durable Object storage backend.</summary>
            /// <remarks>
            /// <c>sqlite</c> is the recommended (and
            /// only) backend for new namespaces. <c>legacy-kv</c> is accepted only for
            /// a class whose namespace already exists as KV-backed; the <c>exports</c>
            /// flow never provisions a new <c>legacy-kv</c> namespace.
            ///
            /// For <c>type: durable-object</c> and <c>state: expecting-transfer</c>: Durable Object storage backend. <c>sqlite</c> is the recommended (and
            /// only) backend for new namespaces. <c>legacy-kv</c> is accepted only for
            /// a class whose namespace already exists as KV-backed; the <c>exports</c>
            /// flow never provisions a new <c>legacy-kv</c> namespace.
            /// Available values: "sqlite", "legacy-kv".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#storage WorkerVersion#storage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Storage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For `state: expecting-transfer`: The source script name to receive the namespace from.</summary>
            /// <remarks>
            /// Must be
            /// in the same account and dispatch-namespace context. Present on
            /// reads for <c>expecting-transfer</c> entries.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#transfer_from WorkerVersion#transfer_from}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transferFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransferFrom
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For `state: transferred`: The destination script name.</summary>
            /// <remarks>
            /// Must be in the same account and
            /// the same dispatch-namespace context (or both non-dispatch).
            /// Cross-dispatch-namespace transfers are rejected. Write-only:
            /// never present in GET responses.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#transferred_to WorkerVersion#transferred_to}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transferredTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransferredTo
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
