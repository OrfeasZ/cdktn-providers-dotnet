using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiInterface(nativeType: typeof(IWorkerVersionExports), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionExports")]
    public interface IWorkerVersionExports
    {
        /// <summary>The kind of export. Available values: "worker", "durable-object".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#type WorkerVersion#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Cache override for this entrypoint. It applies only to `type: worker` entries and overrides the Worker's global `cache_options.enabled` for that entrypoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#cache WorkerVersion#cache}
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

        /// <summary>Destination class name for a `state: renamed` tombstone.</summary>
        /// <remarks>
        /// The
        /// target must appear as a live (<c>created</c>) entry in the same
        /// <c>exports</c> map. Write-only: never present in GET responses.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#renamed_to WorkerVersion#renamed_to}
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

        /// <summary>Lifecycle state of the export entry. Defaults to `created` (a normal, live export) when omitted.</summary>
        /// <remarks>
        /// <c>deleted</c>, <c>renamed</c>, and <c>transferred</c> are tombstones:
        /// write-only lifecycle operations that retire, rename, or hand
        /// off a provisioned Durable Object namespace. They are applied
        /// at upload and are filtered out of GET responses, so a read
        /// only ever returns <c>created</c> or <c>expecting-transfer</c>.
        ///
        /// <c>expecting-transfer</c> is a live export whose data is being
        /// received from another script via the two-phase transfer flow;
        /// it carries <c>storage</c> and <c>transfer_from</c>.
        /// Available values: "created", "deleted", "renamed", "transferred", "expecting-transfer".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#state WorkerVersion#state}
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

        /// <summary>Storage backend for a `type: durable-object` export.</summary>
        /// <remarks>
        /// Required
        /// for live Durable Object entries (<c>created</c> and
        /// <c>expecting-transfer</c>). <c>sqlite</c> selects SQLite-backed storage;
        /// <c>legacy-kv</c> selects the legacy key-value storage.
        /// Available values: "sqlite", "legacy-kv".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#storage WorkerVersion#storage}
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

        /// <summary>Source script for a `state: expecting-transfer` entry.</summary>
        /// <remarks>
        /// The
        /// namespace on this script is materialised from the source
        /// script's data via the pending-transfer flow. Present on reads
        /// for <c>expecting-transfer</c> entries.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#transfer_from WorkerVersion#transfer_from}
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

        /// <summary>Destination script for a `state: transferred` tombstone.</summary>
        /// <remarks>
        /// Must
        /// reference a script in the same account; cross-dispatch-namespace
        /// transfers are rejected. Write-only: never present in GET
        /// responses.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#transferred_to WorkerVersion#transferred_to}
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

            /// <summary>The kind of export. Available values: "worker", "durable-object".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#type WorkerVersion#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Cache override for this entrypoint. It applies only to `type: worker` entries and overrides the Worker's global `cache_options.enabled` for that entrypoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#cache WorkerVersion#cache}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cache", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionExportsCache\"}", isOptional: true)]
            public cloudflare.WorkerVersion.IWorkerVersionExportsCache? Cache
            {
                get => GetInstanceProperty<cloudflare.WorkerVersion.IWorkerVersionExportsCache?>();
            }

            /// <summary>Destination class name for a `state: renamed` tombstone.</summary>
            /// <remarks>
            /// The
            /// target must appear as a live (<c>created</c>) entry in the same
            /// <c>exports</c> map. Write-only: never present in GET responses.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#renamed_to WorkerVersion#renamed_to}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "renamedTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RenamedTo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Lifecycle state of the export entry. Defaults to `created` (a normal, live export) when omitted.</summary>
            /// <remarks>
            /// <c>deleted</c>, <c>renamed</c>, and <c>transferred</c> are tombstones:
            /// write-only lifecycle operations that retire, rename, or hand
            /// off a provisioned Durable Object namespace. They are applied
            /// at upload and are filtered out of GET responses, so a read
            /// only ever returns <c>created</c> or <c>expecting-transfer</c>.
            ///
            /// <c>expecting-transfer</c> is a live export whose data is being
            /// received from another script via the two-phase transfer flow;
            /// it carries <c>storage</c> and <c>transfer_from</c>.
            /// Available values: "created", "deleted", "renamed", "transferred", "expecting-transfer".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#state WorkerVersion#state}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Storage backend for a `type: durable-object` export.</summary>
            /// <remarks>
            /// Required
            /// for live Durable Object entries (<c>created</c> and
            /// <c>expecting-transfer</c>). <c>sqlite</c> selects SQLite-backed storage;
            /// <c>legacy-kv</c> selects the legacy key-value storage.
            /// Available values: "sqlite", "legacy-kv".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#storage WorkerVersion#storage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Storage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Source script for a `state: expecting-transfer` entry.</summary>
            /// <remarks>
            /// The
            /// namespace on this script is materialised from the source
            /// script's data via the pending-transfer flow. Present on reads
            /// for <c>expecting-transfer</c> entries.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#transfer_from WorkerVersion#transfer_from}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transferFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransferFrom
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Destination script for a `state: transferred` tombstone.</summary>
            /// <remarks>
            /// Must
            /// reference a script in the same account; cross-dispatch-namespace
            /// transfers are rejected. Write-only: never present in GET
            /// responses.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#transferred_to WorkerVersion#transferred_to}
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
