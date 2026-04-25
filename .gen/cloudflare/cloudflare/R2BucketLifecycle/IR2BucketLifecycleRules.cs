using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketLifecycle
{
    [JsiiInterface(nativeType: typeof(IR2BucketLifecycleRules), fullyQualifiedName: "cloudflare.r2BucketLifecycle.R2BucketLifecycleRules")]
    public interface IR2BucketLifecycleRules
    {
        /// <summary>Conditions that apply to all transitions of this rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_lifecycle#conditions R2BucketLifecycle#conditions}
        /// </remarks>
        [JsiiProperty(name: "conditions", typeJson: "{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesConditions\"}")]
        cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesConditions Conditions
        {
            get;
        }

        /// <summary>Whether or not this rule is in effect.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_lifecycle#enabled R2BucketLifecycle#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Unique identifier for this rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_lifecycle#id R2BucketLifecycle#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>Transition to abort ongoing multipart uploads.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_lifecycle#abort_multipart_uploads_transition R2BucketLifecycle#abort_multipart_uploads_transition}
        /// </remarks>
        [JsiiProperty(name: "abortMultipartUploadsTransition", typeJson: "{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesAbortMultipartUploadsTransition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesAbortMultipartUploadsTransition? AbortMultipartUploadsTransition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Transition to delete objects.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_lifecycle#delete_objects_transition R2BucketLifecycle#delete_objects_transition}
        /// </remarks>
        [JsiiProperty(name: "deleteObjectsTransition", typeJson: "{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesDeleteObjectsTransition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesDeleteObjectsTransition? DeleteObjectsTransition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Transitions to change the storage class of objects.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_lifecycle#storage_class_transitions R2BucketLifecycle#storage_class_transitions}
        /// </remarks>
        [JsiiProperty(name: "storageClassTransitions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesStorageClassTransitions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StorageClassTransitions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IR2BucketLifecycleRules), fullyQualifiedName: "cloudflare.r2BucketLifecycle.R2BucketLifecycleRules")]
        internal sealed class _Proxy : DeputyBase, cloudflare.R2BucketLifecycle.IR2BucketLifecycleRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Conditions that apply to all transitions of this rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_lifecycle#conditions R2BucketLifecycle#conditions}
            /// </remarks>
            [JsiiProperty(name: "conditions", typeJson: "{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesConditions\"}")]
            public cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesConditions Conditions
            {
                get => GetInstanceProperty<cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesConditions>()!;
            }

            /// <summary>Whether or not this rule is in effect.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_lifecycle#enabled R2BucketLifecycle#enabled}
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Unique identifier for this rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_lifecycle#id R2BucketLifecycle#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Transition to abort ongoing multipart uploads.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_lifecycle#abort_multipart_uploads_transition R2BucketLifecycle#abort_multipart_uploads_transition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "abortMultipartUploadsTransition", typeJson: "{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesAbortMultipartUploadsTransition\"}", isOptional: true)]
            public cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesAbortMultipartUploadsTransition? AbortMultipartUploadsTransition
            {
                get => GetInstanceProperty<cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesAbortMultipartUploadsTransition?>();
            }

            /// <summary>Transition to delete objects.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_lifecycle#delete_objects_transition R2BucketLifecycle#delete_objects_transition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deleteObjectsTransition", typeJson: "{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesDeleteObjectsTransition\"}", isOptional: true)]
            public cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesDeleteObjectsTransition? DeleteObjectsTransition
            {
                get => GetInstanceProperty<cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesDeleteObjectsTransition?>();
            }

            /// <summary>Transitions to change the storage class of objects.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_lifecycle#storage_class_transitions R2BucketLifecycle#storage_class_transitions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageClassTransitions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesStorageClassTransitions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StorageClassTransitions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
